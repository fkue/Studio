namespace StudioManager
{
    partial class WebcamTests
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
            this.pb_webcam = new System.Windows.Forms.PictureBox();
            this.cmb_Webcam = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_webcam)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_webcam
            // 
            this.pb_webcam.BackColor = System.Drawing.Color.Black;
            this.pb_webcam.Location = new System.Drawing.Point(22, 12);
            this.pb_webcam.Name = "pb_webcam";
            this.pb_webcam.Size = new System.Drawing.Size(356, 293);
            this.pb_webcam.TabIndex = 0;
            this.pb_webcam.TabStop = false;
            // 
            // cmb_Webcam
            // 
            this.cmb_Webcam.FormattingEnabled = true;
            this.cmb_Webcam.Location = new System.Drawing.Point(22, 311);
            this.cmb_Webcam.Name = "cmb_Webcam";
            this.cmb_Webcam.Size = new System.Drawing.Size(356, 21);
            this.cmb_Webcam.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start / Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WebcamTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_Webcam);
            this.Controls.Add(this.pb_webcam);
            this.Name = "WebcamTests";
            this.Text = "WebcamTests";
            this.Load += new System.EventHandler(this.WebcamTests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_webcam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_webcam;
        private System.Windows.Forms.ComboBox cmb_Webcam;
        private System.Windows.Forms.Button button1;
    }
}