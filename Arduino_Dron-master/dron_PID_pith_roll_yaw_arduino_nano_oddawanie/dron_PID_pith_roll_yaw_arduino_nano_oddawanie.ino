#include <Servo.h>
#include <Wire.h>
#include <MPU6050.h>

MPU6050 mpu;

Servo FL, FR, RL, RR;

struct ControlData {
  uint8_t Type;
  uint8_t Power;
  uint8_t FR;
  uint8_t LR;
  uint8_t Rotation;
  uint8_t ControlSum;
};

struct EnginesData {
  uint8_t Type;
  uint8_t Power_FL;
  uint8_t Power_FR;
  uint8_t Power_RL;
  uint8_t Power_RR;
  uint8_t ControlSum;
};
ControlData dataIn;
uint8_t bufer[sizeof(dataIn)];
EnginesData dataOut;

uint8_t counterDataEmpty = 0;
uint8_t counterPrintEngines = 0;
unsigned long lastSendEnginesValues = 0;
//int counterPRY = 0;

Vector gyro, accel;

unsigned long timer = 0;
float timeStep;

float pitch = 0, roll = 0, yaw = 0;

int lastPower = 0;

//Wartosci potrzebne przy wyliczaniu pid
float lastX = 0, lastY = 0, lastZ = 0;
float sumX = 0, sumY = 0, sumZ = 0;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Parametry współczynniki dla PID
float xP = 5, xI = 0, xD = 1;
float yP = 5, yI = 0, yD = 1;
float zP = 5, zI = 0, zD = 1;

float maxSumEr = 40;

int maxPID = 400;

void setup() {
  //Serial.begin(19200);
  Serial.begin(9600);
  delay(1000);
  initEngines();
  initMPU();
  Serial.println("Ok");
}

void loop() {
  getData();

  calculatePYR();

  if (dataIn.Power == 0) { /////////////////////////Przed startem ma być 0
    setEnginesPower(0, 0, 0, 0);
    lastX = 0;
    lastY = 0;
    lastZ = 0;
    sumX = 0;
    sumY = 0;
    sumZ = 0;
  }
  else {
    int actPower = map(dataIn.Power, 0, 255, 0, 1000);

    //Serial.print("X: ");  //Oś przechył przód tył
    float exX = getTilt(dataIn.FR);
    float actX = pitch - exX;
    float corX = PID(actX, lastX, sumX, xP, xI, xD, actPower);
    //Serial.println(corX);

    //Serial.print("Y: ");  //Oś przechył boczny
    float exY = getTilt(dataIn.LR);
    float actY = roll - exY;
    float corY = PID(actY, lastY, sumY, yP, yI, yD, actPower);
    //Serial.println(corY);

    //Serial.print("Z: ");  //Skręty w poziomie
    float exZ = getTilt(dataIn.Rotation);
    float actZ = yaw;// - exZ;
    float corZ = PID(actZ, lastZ, sumZ, zP, zI, zD, actPower);

    if (actPower > lastPower + 200) {
      Serial.println("\t\t\t\t\t\tZa szybko");
    }
    else {
      lastPower = actPower;

      int valFL = actPower + corX - corY - corZ;
      int valFR = actPower + corX + corY + corZ;
      int valRL = actPower - corX - corY + corZ;
      int valRR = actPower - corX + corY - corZ;

      if (counterPrintEngines++ > 20) {
        /*Serial.println("");
          Serial.print("FL: ");
          Serial.print(valFL);
          Serial.print(" FR: ");
          Serial.print(valFR);
          Serial.print(" RL: ");
          Serial.print(valRL);
          Serial.print(" RR: ");
          Serial.print(valRR);
        */Serial.print(" P: ");
        Serial.print(pitch);
        Serial.print(" R: ");
        Serial.print(roll);
        /*Serial.print(" Y: ");
          Serial.println(yaw);
        */ Serial.println();
        counterPrintEngines = 0;
      }
      setEnginesPower(valFL, valFR, valRL, valRR);
    }
  }
}
float getTilt(uint8_t axis) {
  if ( axis == 0 ) {
    return 0;
  }
  float retVal = (axis - 40) / 2 ;
  float maxTilt = 20;
  retVal = min(retVal, maxTilt);
  retVal = max(retVal, - maxTilt);
  return retVal;
}

float PID(float actualEr, float &lastEr, float &sumEr, float P, float I, float D, int actPower) {
  float actMaxPID = min(actPower * 0.8, maxPID);

  float p_out = (P * actualEr);

  sumEr = (sumEr + actualEr * timeStep);
  if (sumEr > maxSumEr) {
    sumEr = maxSumEr;
  }
  if (sumEr < -maxSumEr) {
    sumEr = -maxSumEr;
  }
  float i_out = I * sumEr;

  float d_out = D * (actualEr - lastEr) / timeStep;
  lastEr = actualEr;

  float output = p_out + i_out + d_out;
  if (output > actMaxPID) {
    output = actMaxPID;
  } else if (output < -(actMaxPID)) {
    output = -(actMaxPID);
  }
  /*Serial.print("p: ");
    Serial.print(p_out);
    /* Serial.print(" i: ");
    Serial.println(i_out);
    Serial.print(" d: ");
    Serial.print(" ");
    Serial.println(d_out);
    /*Serial.print(" out: ");
    Serial.println(output);
    Serial.println(timeStep);/**/
  return output;
}

void getData() {
  if (Serial.available() >= sizeof(dataIn)) {
    Serial.readBytes(bufer, sizeof(dataIn));
    if (checkControlSum(bufer, sizeof(dataIn))) {
      if (bufer[0] == 1) {
        Serial.println("\t\t\t\t\tPanic");
        dataIn.Power = 0;
        lastPower = 0;
        pitch = 0;
        yaw = 0;
        roll = 0;
      }
      else if (bufer[0] == 128 || bufer[0] == 129) {
        memcpy(&dataIn, bufer, sizeof(dataIn));
        Serial.print(dataIn.Type);
        Serial.print(": ");
        Serial.println(dataIn.Power);
      }
      else {
        Serial.println("Blad ramki");
      }
    }
    else {
      Serial.println("Blad danych");
      if (Serial.available()) {
        while (Serial.available()) {
          Serial.read();
          Serial.print("#");
        }
        Serial.println();
      }
    }
  }
  else {
    if (counterDataEmpty++ > 200) {
      Serial.println(".");
      counterDataEmpty = 0;
    }
  }
}
bool checkControlSum(uint8_t* data, byte siz) {
  uint8_t sum = calculateControlSum(data, siz);
  if (data[siz - 1] == sum) {
    return true;
  }
  return false;
}
uint8_t calculateControlSum(uint8_t* data, byte siz) {
  uint8_t sum = 0;
  for (int i = 0; i < siz - 1; i++) {
    sum += data[i];
  }
  return sum;
}

void calculatePYR2() { //Wersja na akcelerometrze
  unsigned long lastTimer = timer;
  float cpitch = 0;
  float croll = 0;
  byte amount = 10;
  for (int i = 0; i < amount; i++) {
    gyro = mpu.readNormalizeGyro();
    accel = mpu.readNormalizeAccel();

    unsigned long lastTimerPRY = timer;
    timer = millis();
    float timeStepPRY = (timer - lastTimerPRY) / 1000.0;

    cpitch += (-(atan2(accel.XAxis, sqrt(accel.YAxis * accel.YAxis + accel.ZAxis * accel.ZAxis)) * 180.0) / M_PI);
    croll += (atan2(accel.YAxis, accel.ZAxis) * 180.0) / M_PI;
    yaw = yaw + gyro.ZAxis * timeStepPRY;
  }
  pitch = cpitch / amount;
  roll = croll / amount;
  timeStep = (timer - lastTimer) / 1000.0;
  /*Serial.print(" Pitch = ");
    Serial.print(pitch);
    Serial.print(" Roll = ");
    Serial.print(roll);
    Serial.print(" Yaw = ");
    Serial.println(yaw);*/
}

void calculatePYR() { //Wersja na żyroskopie
  unsigned long lastTimer = timer;
  float cpitch = 0;
  float croll = 0;
  float cyaw = 0;
  byte amount = 16;
  for (int i = 0; i < amount; i++) {
    gyro = mpu.readNormalizeGyro();
    cpitch = cpitch + gyro.YAxis;
    croll = croll + gyro.XAxis;
    cyaw = cyaw + gyro.ZAxis;
  }
  timer = millis();
  timeStep = (timer - lastTimer) / 1000.0;
  pitch = pitch + cpitch / amount * timeStep;
  roll = roll + croll / amount * timeStep;
  yaw = yaw + cyaw / amount * timeStep;
  /*counterPRY++;
    if(counterPRY>10){
    Serial.print(" Pitch = ");
    Serial.print(pitch);
    Serial.print(" Roll = ");
    Serial.print(roll);
    Serial.print(" Yaw = ");
    Serial.println(yaw);
    }*/
}

void setEnginesPower(int fl, int fr, int rl, int rr) {
  int maxValEngine = 900;
  if (fl <= 0) {
    fl = 0;
  }
  if (fr <= 0) {
    fr = 0;
  }
  if (rl <= 0) {
    rl = 0;
  }
  if (rr <= 0) {
    rr = 0;
  }
  if (fl >= maxValEngine) {
    fl = maxValEngine;
  }
  if (fr >= maxValEngine) {
    fr = maxValEngine;
  }
  if (rl >= maxValEngine) {
    rl = maxValEngine;
  }
  if (rr >= maxValEngine) {
    rr = maxValEngine;
  }

  long sendTimer = millis();
  if (sendTimer > lastSendEnginesValues + 1000) {
    dataOut.Type = 1;
    dataOut.Power_FL = map(fl, 0, 1000, 0, 255);
    dataOut.Power_FR = map(fr, 0, 1000, 0, 255);
    dataOut.Power_RL = map(rl, 0, 1000, 0, 255);
    dataOut.Power_RR = map(rr, 0, 1000, 0, 255);
    memcpy(&bufer, &dataOut, sizeof(dataOut));
    bufer[sizeof(dataOut) - 1] = calculateControlSum(bufer, sizeof(dataOut));
    //Serial.println(bufer[sizeof(dataOut)-1]);
    lastSendEnginesValues = sendTimer;
    //Serial1.write(&bufer, sizeof(dataOut));//Odkomentować aby wysyłać wartości zwrotne - atmega 328 ma jeden serial
  }

  int fl_pov = map(fl, 0, 1000, 1190, 1800);
  if (fl <= 0) {
    fl_pov = 0;
  }
  int fr_pov = map(fr, 0, 1000, 1240, 1800);
  if (fr <= 0) {
    fr_pov = 0;
  }
  int rl_pov = map(rl, 0, 1000, 1190, 1800);
  if (rl <= 0) {
    rl_pov = 0;
  }
  int rr_pov = map(rr, 0, 1000, 1080, 1800);
  if (rr <= 0) {
    rr_pov = 0;
  }

  FL.writeMicroseconds(fl_pov);
  FR.writeMicroseconds(fr_pov);
  RL.writeMicroseconds(rl_pov);
  RR.writeMicroseconds(rr_pov);
}

void initEngines() {
  FL.attach(6);
  FR.attach(5);
  RL.attach(9);
  RR.attach(10);
  setEnginesPower(0, 0, 0, 0);
}

void initMPU() {
  while (!mpu.begin(MPU6050_SCALE_2000DPS, MPU6050_RANGE_2G))
  {
    Serial.println("Could not find a valid MPU6050 sensor, check wiring!");
    delay(500);
  }

  mpu.calibrateGyro();
}
