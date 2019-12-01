namespace ConsoleApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.SuspendLayout();
            // 
            // Engine1
            // 
            this.Engine1.Location = new System.Drawing.Point(12, 25);
            this.Engine1.Name = "Engine1";
            this.Engine1.Size = new System.Drawing.Size(237, 23);
            this.Engine1.TabIndex = 0;
            // 
            // Engine2
            // 
            this.Engine2.Location = new System.Drawing.Point(278, 25);
            this.Engine2.Name = "Engine2";
            this.Engine2.Size = new System.Drawing.Size(237, 23);
            this.Engine2.TabIndex = 1;
            // 
            // Engine3
            // 
            this.Engine3.Location = new System.Drawing.Point(12, 72);
            this.Engine3.Name = "Engine3";
            this.Engine3.Size = new System.Drawing.Size(237, 23);
            this.Engine3.TabIndex = 2;
            // 
            // Engine4
            // 
            this.Engine4.Location = new System.Drawing.Point(278, 72);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}