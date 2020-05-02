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
            this.PanicButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.gyroscop = new System.Windows.Forms.PictureBox();
            this.Throtle = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.ThrotleState = new System.Windows.Forms.Label();
            this.vertical = new System.Windows.Forms.PictureBox();
            this.horizontal = new System.Windows.Forms.PictureBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.x3 = new System.Windows.Forms.TextBox();
            this.sendFrame = new System.Windows.Forms.Button();
            this.Engine1 = new CircularProgressBar.CircularProgressBar();
            this.Engine3 = new CircularProgressBar.CircularProgressBar();
            this.Engine2 = new CircularProgressBar.CircularProgressBar();
            this.Engine4 = new CircularProgressBar.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.gyroscop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontal)).BeginInit();
            this.SuspendLayout();
            // 
            // PanicButton
            // 
            this.PanicButton.BackColor = System.Drawing.Color.DarkRed;
            this.PanicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PanicButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PanicButton.Location = new System.Drawing.Point(613, 22);
            this.PanicButton.Name = "PanicButton";
            this.PanicButton.Size = new System.Drawing.Size(175, 74);
            this.PanicButton.TabIndex = 4;
            this.PanicButton.Text = "STOP";
            this.PanicButton.UseVisualStyleBackColor = false;
            this.PanicButton.Click += new System.EventHandler(this.PanicButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Engine1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Engine2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Engine3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Engine4";
            // 
            // update
            // 
            this.update.Enabled = true;
            this.update.Interval = 300;
            this.update.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // gyroscop
            // 
            this.gyroscop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gyroscop.Location = new System.Drawing.Point(10, 4);
            this.gyroscop.Name = "gyroscop";
            this.gyroscop.Size = new System.Drawing.Size(250, 250);
            this.gyroscop.TabIndex = 13;
            this.gyroscop.TabStop = false;
            // 
            // Throtle
            // 
            this.Throtle.Location = new System.Drawing.Point(329, 412);
            this.Throtle.MarqueeAnimationSpeed = 0;
            this.Throtle.Name = "Throtle";
            this.Throtle.Size = new System.Drawing.Size(237, 26);
            this.Throtle.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Throtle";
            // 
            // ThrotleState
            // 
            this.ThrotleState.AutoSize = true;
            this.ThrotleState.Location = new System.Drawing.Point(432, 396);
            this.ThrotleState.Name = "ThrotleState";
            this.ThrotleState.Size = new System.Drawing.Size(21, 13);
            this.ThrotleState.TabIndex = 16;
            this.ThrotleState.Text = "0%";
            // 
            // vertical
            // 
            this.vertical.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vertical.Location = new System.Drawing.Point(117, 260);
            this.vertical.Name = "vertical";
            this.vertical.Size = new System.Drawing.Size(25, 160);
            this.vertical.TabIndex = 19;
            this.vertical.TabStop = false;
            // 
            // horizontal
            // 
            this.horizontal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.horizontal.Location = new System.Drawing.Point(48, 413);
            this.horizontal.Name = "horizontal";
            this.horizontal.Size = new System.Drawing.Size(160, 25);
            this.horizontal.TabIndex = 20;
            this.horizontal.TabStop = false;
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(688, 116);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(100, 20);
            this.x1.TabIndex = 21;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(688, 142);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(100, 20);
            this.x2.TabIndex = 22;
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(688, 168);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(100, 20);
            this.x3.TabIndex = 23;
            // 
            // sendFrame
            // 
            this.sendFrame.Location = new System.Drawing.Point(688, 203);
            this.sendFrame.Name = "sendFrame";
            this.sendFrame.Size = new System.Drawing.Size(75, 23);
            this.sendFrame.TabIndex = 24;
            this.sendFrame.Text = "SEND";
            this.sendFrame.UseVisualStyleBackColor = true;
            this.sendFrame.Click += new System.EventHandler(this.sendFrame_Click);
            // 
            // Engine1
            // 
            this.Engine1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Engine1.AnimationSpeed = 200;
            this.Engine1.BackColor = System.Drawing.Color.Transparent;
            this.Engine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Engine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Engine1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Engine1.InnerMargin = 2;
            this.Engine1.InnerWidth = -1;
            this.Engine1.Location = new System.Drawing.Point(269, 22);
            this.Engine1.MarqueeAnimationSpeed = 2000;
            this.Engine1.Maximum = 255;
            this.Engine1.Name = "Engine1";
            this.Engine1.OuterColor = System.Drawing.Color.Gray;
            this.Engine1.OuterMargin = -25;
            this.Engine1.OuterWidth = 26;
            this.Engine1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Engine1.ProgressWidth = 25;
            this.Engine1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Engine1.Size = new System.Drawing.Size(160, 153);
            this.Engine1.StartAngle = 270;
            this.Engine1.SubscriptColor = System.Drawing.Color.Black;
            this.Engine1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Engine1.SubscriptText = "0";
            this.Engine1.SuperscriptColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Engine1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Engine1.SuperscriptText = "%";
            this.Engine1.TabIndex = 25;
            this.Engine1.Text = " ";
            this.Engine1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // Engine3
            // 
            this.Engine3.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Engine3.AnimationSpeed = 200;
            this.Engine3.BackColor = System.Drawing.Color.Transparent;
            this.Engine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Engine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Engine3.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Engine3.InnerMargin = 2;
            this.Engine3.InnerWidth = -1;
            this.Engine3.Location = new System.Drawing.Point(266, 203);
            this.Engine3.MarqueeAnimationSpeed = 2000;
            this.Engine3.Maximum = 255;
            this.Engine3.Name = "Engine3";
            this.Engine3.OuterColor = System.Drawing.Color.Gray;
            this.Engine3.OuterMargin = -25;
            this.Engine3.OuterWidth = 26;
            this.Engine3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Engine3.ProgressWidth = 25;
            this.Engine3.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Engine3.Size = new System.Drawing.Size(159, 155);
            this.Engine3.StartAngle = 270;
            this.Engine3.SubscriptColor = System.Drawing.Color.Black;
            this.Engine3.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Engine3.SubscriptText = "0";
            this.Engine3.SuperscriptColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Engine3.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Engine3.SuperscriptText = "%";
            this.Engine3.TabIndex = 27;
            this.Engine3.Text = " ";
            this.Engine3.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // Engine2
            // 
            this.Engine2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Engine2.AnimationSpeed = 200;
            this.Engine2.BackColor = System.Drawing.Color.Transparent;
            this.Engine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Engine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Engine2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Engine2.InnerMargin = 2;
            this.Engine2.InnerWidth = -1;
            this.Engine2.Location = new System.Drawing.Point(435, 22);
            this.Engine2.MarqueeAnimationSpeed = 2000;
            this.Engine2.Maximum = 255;
            this.Engine2.Name = "Engine2";
            this.Engine2.OuterColor = System.Drawing.Color.Gray;
            this.Engine2.OuterMargin = -25;
            this.Engine2.OuterWidth = 26;
            this.Engine2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Engine2.ProgressWidth = 25;
            this.Engine2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Engine2.Size = new System.Drawing.Size(160, 153);
            this.Engine2.StartAngle = 270;
            this.Engine2.SubscriptColor = System.Drawing.Color.Black;
            this.Engine2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Engine2.SubscriptText = "0";
            this.Engine2.SuperscriptColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Engine2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Engine2.SuperscriptText = "%";
            this.Engine2.TabIndex = 29;
            this.Engine2.Text = " ";
            this.Engine2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // Engine4
            // 
            this.Engine4.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Engine4.AnimationSpeed = 200;
            this.Engine4.BackColor = System.Drawing.Color.Transparent;
            this.Engine4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Engine4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Engine4.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Engine4.InnerMargin = 2;
            this.Engine4.InnerWidth = -1;
            this.Engine4.Location = new System.Drawing.Point(435, 205);
            this.Engine4.MarqueeAnimationSpeed = 2000;
            this.Engine4.Maximum = 255;
            this.Engine4.Name = "Engine4";
            this.Engine4.OuterColor = System.Drawing.Color.Gray;
            this.Engine4.OuterMargin = -25;
            this.Engine4.OuterWidth = 26;
            this.Engine4.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Engine4.ProgressWidth = 25;
            this.Engine4.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Engine4.Size = new System.Drawing.Size(160, 153);
            this.Engine4.StartAngle = 270;
            this.Engine4.SubscriptColor = System.Drawing.Color.Black;
            this.Engine4.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Engine4.SubscriptText = "0";
            this.Engine4.SuperscriptColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Engine4.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Engine4.SuperscriptText = "%";
            this.Engine4.TabIndex = 30;
            this.Engine4.Text = " ";
            this.Engine4.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Engine4);
            this.Controls.Add(this.Engine2);
            this.Controls.Add(this.Engine3);
            this.Controls.Add(this.Engine1);
            this.Controls.Add(this.sendFrame);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.horizontal);
            this.Controls.Add(this.vertical);
            this.Controls.Add(this.ThrotleState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Throtle);
            this.Controls.Add(this.gyroscop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanicButton);
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Dron-APP";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ThrotleHendler);
            ((System.ComponentModel.ISupportInitialize)(this.gyroscop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PanicButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.PictureBox gyroscop;
        private System.Windows.Forms.ProgressBar Throtle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ThrotleState;
        private System.Windows.Forms.PictureBox vertical;
        private System.Windows.Forms.PictureBox horizontal;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox x3;
        private System.Windows.Forms.Button sendFrame;
        private CircularProgressBar.CircularProgressBar Engine1;
        private CircularProgressBar.CircularProgressBar Engine3;
        private CircularProgressBar.CircularProgressBar Engine2;
        private CircularProgressBar.CircularProgressBar Engine4;
    }
}