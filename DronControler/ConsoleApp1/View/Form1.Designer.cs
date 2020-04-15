namespace DronApp
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Engine1 = new System.Windows.Forms.ProgressBar();
            this.Engine2 = new System.Windows.Forms.ProgressBar();
            this.Engine3 = new System.Windows.Forms.ProgressBar();
            this.Engine4 = new System.Windows.Forms.ProgressBar();
            this.PanicButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Engine1State = new System.Windows.Forms.Label();
            this.Engine2State = new System.Windows.Forms.Label();
            this.Engine3State = new System.Windows.Forms.Label();
            this.Engine4State = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gyroscop = new System.Windows.Forms.PictureBox();
            this.Throtle = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.ThrotleState = new System.Windows.Forms.Label();
            this.OverideControl = new System.Windows.Forms.ProgressBar();
            this.Overide = new System.Windows.Forms.Label();
            this.vertical = new System.Windows.Forms.PictureBox();
            this.horizontal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gyroscop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontal)).BeginInit();
            this.SuspendLayout();
            // 
            // Engine1
            // 
            this.Engine1.ForeColor = System.Drawing.Color.Red;
            this.Engine1.Location = new System.Drawing.Point(12, 25);
            this.Engine1.MarqueeAnimationSpeed = 0;
            this.Engine1.Name = "Engine1";
            this.Engine1.Size = new System.Drawing.Size(237, 23);
            this.Engine1.TabIndex = 0;
            // 
            // Engine2
            // 
            this.Engine2.Location = new System.Drawing.Point(278, 25);
            this.Engine2.MarqueeAnimationSpeed = 0;
            this.Engine2.Name = "Engine2";
            this.Engine2.Size = new System.Drawing.Size(237, 23);
            this.Engine2.TabIndex = 1;
            // 
            // Engine3
            // 
            this.Engine3.Location = new System.Drawing.Point(12, 72);
            this.Engine3.MarqueeAnimationSpeed = 0;
            this.Engine3.Name = "Engine3";
            this.Engine3.Size = new System.Drawing.Size(237, 23);
            this.Engine3.TabIndex = 2;
            // 
            // Engine4
            // 
            this.Engine4.Location = new System.Drawing.Point(278, 72);
            this.Engine4.MarqueeAnimationSpeed = 0;
            this.Engine4.Name = "Engine4";
            this.Engine4.Size = new System.Drawing.Size(237, 23);
            this.Engine4.TabIndex = 3;
            // 
            // PanicButton
            // 
            this.PanicButton.BackColor = System.Drawing.Color.DarkRed;
            this.PanicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PanicButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PanicButton.Location = new System.Drawing.Point(546, 25);
            this.PanicButton.Name = "PanicButton";
            this.PanicButton.Size = new System.Drawing.Size(242, 70);
            this.PanicButton.TabIndex = 4;
            this.PanicButton.Text = "STOP";
            this.PanicButton.UseVisualStyleBackColor = false;
            this.PanicButton.Click += new System.EventHandler(this.PanicButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Engine1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Engine2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Engine3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Engine4";
            // 
            // Engine1State
            // 
            this.Engine1State.AutoSize = true;
            this.Engine1State.Location = new System.Drawing.Point(251, 25);
            this.Engine1State.Name = "Engine1State";
            this.Engine1State.Size = new System.Drawing.Size(21, 13);
            this.Engine1State.TabIndex = 9;
            this.Engine1State.Text = "0%";
            // 
            // Engine2State
            // 
            this.Engine2State.AutoSize = true;
            this.Engine2State.Location = new System.Drawing.Point(519, 25);
            this.Engine2State.Name = "Engine2State";
            this.Engine2State.Size = new System.Drawing.Size(21, 13);
            this.Engine2State.TabIndex = 10;
            this.Engine2State.Text = "0%";
            // 
            // Engine3State
            // 
            this.Engine3State.AutoSize = true;
            this.Engine3State.Location = new System.Drawing.Point(251, 72);
            this.Engine3State.Name = "Engine3State";
            this.Engine3State.Size = new System.Drawing.Size(21, 13);
            this.Engine3State.TabIndex = 11;
            this.Engine3State.Text = "0%";
            // 
            // Engine4State
            // 
            this.Engine4State.AutoSize = true;
            this.Engine4State.Location = new System.Drawing.Point(519, 72);
            this.Engine4State.Name = "Engine4State";
            this.Engine4State.Size = new System.Drawing.Size(21, 13);
            this.Engine4State.TabIndex = 12;
            this.Engine4State.Text = "0%";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gyroscop
            // 
            this.gyroscop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gyroscop.Location = new System.Drawing.Point(12, 123);
            this.gyroscop.Name = "gyroscop";
            this.gyroscop.Size = new System.Drawing.Size(250, 250);
            this.gyroscop.TabIndex = 13;
            this.gyroscop.TabStop = false;
            // 
            // Throtle
            // 
            this.Throtle.Location = new System.Drawing.Point(278, 132);
            this.Throtle.MarqueeAnimationSpeed = 0;
            this.Throtle.Name = "Throtle";
            this.Throtle.Size = new System.Drawing.Size(237, 26);
            this.Throtle.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Throtle";
            // 
            // ThrotleState
            // 
            this.ThrotleState.AutoSize = true;
            this.ThrotleState.Location = new System.Drawing.Point(519, 132);
            this.ThrotleState.Name = "ThrotleState";
            this.ThrotleState.Size = new System.Drawing.Size(21, 13);
            this.ThrotleState.TabIndex = 16;
            this.ThrotleState.Text = "0%";
            // 
            // OverideControl
            // 
            this.OverideControl.Location = new System.Drawing.Point(580, 124);
            this.OverideControl.Name = "OverideControl";
            this.OverideControl.Size = new System.Drawing.Size(36, 34);
            this.OverideControl.TabIndex = 17;
            this.OverideControl.Click += new System.EventHandler(this.Override_Click);
            // 
            // Overide
            // 
            this.Overide.AutoSize = true;
            this.Overide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Overide.Location = new System.Drawing.Point(633, 132);
            this.Overide.Name = "Overide";
            this.Overide.Size = new System.Drawing.Size(68, 20);
            this.Overide.TabIndex = 18;
            this.Overide.Text = "Override";
            // 
            // vertical
            // 
            this.vertical.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vertical.Location = new System.Drawing.Point(376, 164);
            this.vertical.Name = "vertical";
            this.vertical.Size = new System.Drawing.Size(25, 160);
            this.vertical.TabIndex = 19;
            this.vertical.TabStop = false;
            // 
            // horizontal
            // 
            this.horizontal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.horizontal.Location = new System.Drawing.Point(307, 330);
            this.horizontal.Name = "horizontal";
            this.horizontal.Size = new System.Drawing.Size(160, 25);
            this.horizontal.TabIndex = 20;
            this.horizontal.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.horizontal);
            this.Controls.Add(this.vertical);
            this.Controls.Add(this.Overide);
            this.Controls.Add(this.OverideControl);
            this.Controls.Add(this.ThrotleState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Throtle);
            this.Controls.Add(this.gyroscop);
            this.Controls.Add(this.Engine4State);
            this.Controls.Add(this.Engine3State);
            this.Controls.Add(this.Engine2State);
            this.Controls.Add(this.Engine1State);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanicButton);
            this.Controls.Add(this.Engine4);
            this.Controls.Add(this.Engine3);
            this.Controls.Add(this.Engine2);
            this.Controls.Add(this.Engine1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Dron-APP";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ThrotleHendler);
            ((System.ComponentModel.ISupportInitialize)(this.gyroscop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Engine1;
        private System.Windows.Forms.ProgressBar Engine2;
        private System.Windows.Forms.ProgressBar Engine3;
        private System.Windows.Forms.ProgressBar Engine4;
        private System.Windows.Forms.Button PanicButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Engine1State;
        private System.Windows.Forms.Label Engine2State;
        private System.Windows.Forms.Label Engine3State;
        private System.Windows.Forms.Label Engine4State;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox gyroscop;
        private System.Windows.Forms.ProgressBar Throtle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ThrotleState;
        private System.Windows.Forms.ProgressBar OverideControl;
        private System.Windows.Forms.Label Overide;
        private System.Windows.Forms.PictureBox vertical;
        private System.Windows.Forms.PictureBox horizontal;
    }
}