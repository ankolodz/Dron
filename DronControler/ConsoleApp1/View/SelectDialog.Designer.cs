namespace DronApp
{
    partial class SelectDialog
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
            this.ports = new System.Windows.Forms.ComboBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.textInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ports
            // 
            this.ports.FormattingEnabled = true;
            this.ports.Location = new System.Drawing.Point(12, 48);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(272, 21);
            this.ports.TabIndex = 0;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(79, 91);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(138, 41);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // textInfo
            // 
            this.textInfo.AutoSize = true;
            this.textInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textInfo.Location = new System.Drawing.Point(12, 21);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(273, 24);
            this.textInfo.TabIndex = 2;
            this.textInfo.Text = "Wybierz port COM do transmisji";
            // 
            // SelectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 162);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.ports);
            this.Name = "SelectDialog";
            this.Text = "SellectDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ports;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label textInfo;
    }
}