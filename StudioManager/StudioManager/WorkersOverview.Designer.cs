namespace StudioManager
{
    partial class WorkersOverview
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
            this.dgv_OverviewWorkes = new System.Windows.Forms.DataGridView();
            this.btn_createNewLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OverviewWorkes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_OverviewWorkes
            // 
            this.dgv_OverviewWorkes.AllowUserToAddRows = false;
            this.dgv_OverviewWorkes.AllowUserToDeleteRows = false;
            this.dgv_OverviewWorkes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OverviewWorkes.Enabled = false;
            this.dgv_OverviewWorkes.Location = new System.Drawing.Point(12, 46);
            this.dgv_OverviewWorkes.Name = "dgv_OverviewWorkes";
            this.dgv_OverviewWorkes.ReadOnly = true;
            this.dgv_OverviewWorkes.Size = new System.Drawing.Size(746, 472);
            this.dgv_OverviewWorkes.TabIndex = 0;
            // 
            // btn_createNewLogin
            // 
            this.btn_createNewLogin.Location = new System.Drawing.Point(630, 17);
            this.btn_createNewLogin.Name = "btn_createNewLogin";
            this.btn_createNewLogin.Size = new System.Drawing.Size(128, 23);
            this.btn_createNewLogin.TabIndex = 1;
            this.btn_createNewLogin.Text = "Neuen Login erstellen";
            this.btn_createNewLogin.UseVisualStyleBackColor = true;
            this.btn_createNewLogin.Click += new System.EventHandler(this.btn_createNewLogin_Click);
            // 
            // WorkersOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 530);
            this.Controls.Add(this.btn_createNewLogin);
            this.Controls.Add(this.dgv_OverviewWorkes);
            this.Name = "WorkersOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkersOverview";
            this.Load += new System.EventHandler(this.WorkersOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OverviewWorkes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_OverviewWorkes;
        private System.Windows.Forms.Button btn_createNewLogin;
    }
}