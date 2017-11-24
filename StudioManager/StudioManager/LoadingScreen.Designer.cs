namespace StudioManager
{
    partial class LoadingScreen
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
            this.txt_rf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_rf
            // 
            this.txt_rf.BackColor = System.Drawing.Color.White;
            this.txt_rf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_rf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_rf.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rf.Location = new System.Drawing.Point(392, 567);
            this.txt_rf.Multiline = true;
            this.txt_rf.Name = "txt_rf";
            this.txt_rf.ReadOnly = true;
            this.txt_rf.Size = new System.Drawing.Size(103, 57);
            this.txt_rf.TabIndex = 0;
            this.txt_rf.Text = "RUPERTI \r\nFITNESS";
            this.txt_rf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::StudioManager.Properties.Resources.logoruperti;
            this.ClientSize = new System.Drawing.Size(494, 623);
            this.ControlBox = false;
            this.Controls.Add(this.txt_rf);
            this.Name = "LoadingScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_rf;
    }
}