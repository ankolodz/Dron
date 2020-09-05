﻿namespace DronApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanicButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.gyroscop = new System.Windows.Forms.PictureBox();
            this.vertical = new System.Windows.Forms.PictureBox();
            this.horizontal = new System.Windows.Forms.PictureBox();
            this.Engine1 = new CircularProgressBar.CircularProgressBar();
            this.Engine3 = new CircularProgressBar.CircularProgressBar();
            this.Engine2 = new CircularProgressBar.CircularProgressBar();
            this.Engine4 = new CircularProgressBar.CircularProgressBar();
            this.Throtle = new CircularProgressBar.CircularProgressBar();
            this.connectionIco = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gyroscop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionIco)).BeginInit();
            this.SuspendLayout();
            // 
            // PanicButton
            // 
            this.PanicButton.BackColor = System.Drawing.Color.DarkRed;
            this.PanicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PanicButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PanicButton.Location = new System.Drawing.Point(613, 495);
            this.PanicButton.Name = "PanicButton";
            this.PanicButton.Size = new System.Drawing.Size(286, 74);
            this.PanicButton.TabIndex = 4;
            this.PanicButton.Text = "STOP";
            this.PanicButton.UseVisualStyleBackColor = false;
            this.PanicButton.Click += new System.EventHandler(this.PanicButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Engine1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Engine3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Engine4";
            // 
            // update
            // 
            this.update.Enabled = true;
            this.update.Interval = 200;
            this.update.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // gyroscop
            // 
            this.gyroscop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gyroscop.Location = new System.Drawing.Point(42, 307);
            this.gyroscop.Name = "gyroscop";
            this.gyroscop.Size = new System.Drawing.Size(250, 250);
            this.gyroscop.TabIndex = 13;
            this.gyroscop.TabStop = false;
            // 
            // vertical
            // 
            this.vertical.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vertical.Location = new System.Drawing.Point(471, 409);
            this.vertical.Name = "vertical";
            this.vertical.Size = new System.Drawing.Size(25, 160);
            this.vertical.TabIndex = 19;
            this.vertical.TabStop = false;
            // 
            // horizontal
            // 
            this.horizontal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.horizontal.Location = new System.Drawing.Point(401, 544);
            this.horizontal.Name = "horizontal";
            this.horizontal.Size = new System.Drawing.Size(160, 25);
            this.horizontal.TabIndex = 20;
            this.horizontal.TabStop = false;
            // 
            // Engine1
            // 
            this.Engine1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Engine1.AnimationSpeed = 200;
            this.Engine1.BackColor = System.Drawing.Color.Transparent;
            this.Engine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Engine1.ForeColor = System.Drawing.Color.Transparent;
            this.Engine1.InnerColor = System.Drawing.Color.Silver;
            this.Engine1.InnerMargin = 2;
            this.Engine1.InnerWidth = -1;
            this.Engine1.Location = new System.Drawing.Point(401, 4);
            this.Engine1.MarqueeAnimationSpeed = 2000;
            this.Engine1.Maximum = 255;
            this.Engine1.Name = "Engine1";
            this.Engine1.OuterColor = System.Drawing.Color.Gray;
            this.Engine1.OuterMargin = -25;
            this.Engine1.OuterWidth = 26;
            this.Engine1.ProgressColor = System.Drawing.Color.LimeGreen;
            this.Engine1.ProgressWidth = 25;
            this.Engine1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Engine1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Engine1.Size = new System.Drawing.Size(160, 153);
            this.Engine1.StartAngle = 270;
            this.Engine1.SubscriptColor = System.Drawing.Color.WhiteSmoke;
            this.Engine1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Engine1.SubscriptText = "0";
            this.Engine1.SuperscriptColor = System.Drawing.Color.WhiteSmoke;
            this.Engine1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Engine1.SuperscriptText = "%";
            this.Engine1.TabIndex = 25;
            this.Engine1.Text = " ";
            this.Engine1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Engine1.Value = 68;
            // 
            // Engine3
            // 
            this.Engine3.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Engine3.AnimationSpeed = 200;
            this.Engine3.BackColor = System.Drawing.Color.Transparent;
            this.Engine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Engine3.ForeColor = System.Drawing.Color.Transparent;
            this.Engine3.InnerColor = System.Drawing.Color.Silver;
            this.Engine3.InnerMargin = 2;
            this.Engine3.InnerWidth = -1;
            this.Engine3.Location = new System.Drawing.Point(266, 127);
            this.Engine3.MarqueeAnimationSpeed = 2000;
            this.Engine3.Maximum = 255;
            this.Engine3.Name = "Engine3";
            this.Engine3.OuterColor = System.Drawing.Color.Gray;
            this.Engine3.OuterMargin = -25;
            this.Engine3.OuterWidth = 26;
            this.Engine3.ProgressColor = System.Drawing.Color.LimeGreen;
            this.Engine3.ProgressWidth = 25;
            this.Engine3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Engine3.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Engine3.Size = new System.Drawing.Size(159, 155);
            this.Engine3.StartAngle = 270;
            this.Engine3.SubscriptColor = System.Drawing.Color.WhiteSmoke;
            this.Engine3.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Engine3.SubscriptText = "0";
            this.Engine3.SuperscriptColor = System.Drawing.Color.WhiteSmoke;
            this.Engine3.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Engine3.SuperscriptText = "%";
            this.Engine3.TabIndex = 27;
            this.Engine3.Text = " ";
            this.Engine3.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Engine3.Value = 68;
            // 
            // Engine2
            // 
            this.Engine2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Engine2.AnimationSpeed = 200;
            this.Engine2.BackColor = System.Drawing.Color.Transparent;
            this.Engine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Engine2.ForeColor = System.Drawing.Color.Transparent;
            this.Engine2.InnerColor = System.Drawing.Color.Silver;
            this.Engine2.InnerMargin = 2;
            this.Engine2.InnerWidth = -1;
            this.Engine2.Location = new System.Drawing.Point(537, 132);
            this.Engine2.MarqueeAnimationSpeed = 2000;
            this.Engine2.Maximum = 255;
            this.Engine2.Name = "Engine2";
            this.Engine2.OuterColor = System.Drawing.Color.Gray;
            this.Engine2.OuterMargin = -25;
            this.Engine2.OuterWidth = 26;
            this.Engine2.ProgressColor = System.Drawing.Color.LimeGreen;
            this.Engine2.ProgressWidth = 25;
            this.Engine2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Engine2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Engine2.Size = new System.Drawing.Size(160, 153);
            this.Engine2.StartAngle = 270;
            this.Engine2.SubscriptColor = System.Drawing.Color.WhiteSmoke;
            this.Engine2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Engine2.SubscriptText = "0";
            this.Engine2.SuperscriptColor = System.Drawing.Color.WhiteSmoke;
            this.Engine2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Engine2.SuperscriptText = "%";
            this.Engine2.TabIndex = 29;
            this.Engine2.Text = " ";
            this.Engine2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Engine2.Value = 68;
            // 
            // Engine4
            // 
            this.Engine4.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Engine4.AnimationSpeed = 200;
            this.Engine4.BackColor = System.Drawing.Color.Transparent;
            this.Engine4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Engine4.ForeColor = System.Drawing.Color.Transparent;
            this.Engine4.InnerColor = System.Drawing.Color.Silver;
            this.Engine4.InnerMargin = 2;
            this.Engine4.InnerWidth = -1;
            this.Engine4.Location = new System.Drawing.Point(401, 260);
            this.Engine4.MarqueeAnimationSpeed = 2000;
            this.Engine4.Maximum = 255;
            this.Engine4.Name = "Engine4";
            this.Engine4.OuterColor = System.Drawing.Color.Gray;
            this.Engine4.OuterMargin = -25;
            this.Engine4.OuterWidth = 26;
            this.Engine4.ProgressColor = System.Drawing.Color.LimeGreen;
            this.Engine4.ProgressWidth = 25;
            this.Engine4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Engine4.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Engine4.Size = new System.Drawing.Size(160, 153);
            this.Engine4.StartAngle = 270;
            this.Engine4.SubscriptColor = System.Drawing.Color.WhiteSmoke;
            this.Engine4.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Engine4.SubscriptText = "0";
            this.Engine4.SuperscriptColor = System.Drawing.Color.WhiteSmoke;
            this.Engine4.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Engine4.SuperscriptText = "%";
            this.Engine4.TabIndex = 30;
            this.Engine4.Text = " ";
            this.Engine4.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Engine4.Value = 68;
            // 
            // Throtle
            // 
            this.Throtle.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Throtle.AnimationSpeed = 200;
            this.Throtle.BackColor = System.Drawing.Color.Transparent;
            this.Throtle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Throtle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Throtle.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Throtle.InnerMargin = 2;
            this.Throtle.InnerWidth = -1;
            this.Throtle.Location = new System.Drawing.Point(646, 291);
            this.Throtle.MarqueeAnimationSpeed = 2000;
            this.Throtle.Maximum = 255;
            this.Throtle.Name = "Throtle";
            this.Throtle.OuterColor = System.Drawing.Color.Gray;
            this.Throtle.OuterMargin = -25;
            this.Throtle.OuterWidth = 26;
            this.Throtle.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.Throtle.ProgressWidth = 25;
            this.Throtle.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Throtle.Size = new System.Drawing.Size(210, 192);
            this.Throtle.StartAngle = 270;
            this.Throtle.SubscriptColor = System.Drawing.Color.Black;
            this.Throtle.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Throtle.SubscriptText = "0";
            this.Throtle.SuperscriptColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Throtle.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Throtle.SuperscriptText = "%";
            this.Throtle.TabIndex = 31;
            this.Throtle.Text = " ";
            this.Throtle.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Throtle.Value = 68;
            // 
            // connectionIco
            // 
            this.connectionIco.BackColor = System.Drawing.Color.Red;
            this.connectionIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.connectionIco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.connectionIco.Image = ((System.Drawing.Image)(resources.GetObject("connectionIco.Image")));
            this.connectionIco.Location = new System.Drawing.Point(613, 12);
            this.connectionIco.Name = "connectionIco";
            this.connectionIco.Size = new System.Drawing.Size(66, 64);
            this.connectionIco.TabIndex = 32;
            this.connectionIco.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(911, 581);
            this.Controls.Add(this.connectionIco);
            this.Controls.Add(this.Engine3);
            this.Controls.Add(this.Throtle);
            this.Controls.Add(this.Engine4);
            this.Controls.Add(this.Engine2);
            this.Controls.Add(this.Engine1);
            this.Controls.Add(this.horizontal);
            this.Controls.Add(this.vertical);
            this.Controls.Add(this.gyroscop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanicButton);
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ThrotleHendler);
            ((System.ComponentModel.ISupportInitialize)(this.gyroscop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionIco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PanicButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.PictureBox gyroscop;
        private System.Windows.Forms.PictureBox vertical;
        private System.Windows.Forms.PictureBox horizontal;
        private CircularProgressBar.CircularProgressBar Engine1;
        private CircularProgressBar.CircularProgressBar Engine3;
        private CircularProgressBar.CircularProgressBar Engine2;
        private CircularProgressBar.CircularProgressBar Engine4;
        private CircularProgressBar.CircularProgressBar Throtle;
        private System.Windows.Forms.PictureBox connectionIco;
    }
}