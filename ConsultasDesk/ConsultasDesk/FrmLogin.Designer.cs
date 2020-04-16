namespace ConsultasDesk
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panelEsq = new System.Windows.Forms.Panel();
            this.btnCad = new System.Windows.Forms.Button();
            this.lblEasyHealth = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.PanelDir = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.panelEsq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.PanelDir.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEsq
            // 
            this.panelEsq.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelEsq.Controls.Add(this.btnCad);
            this.panelEsq.Controls.Add(this.lblEasyHealth);
            this.panelEsq.Controls.Add(this.picBox);
            this.panelEsq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEsq.Location = new System.Drawing.Point(0, 0);
            this.panelEsq.Name = "panelEsq";
            this.panelEsq.Size = new System.Drawing.Size(301, 575);
            this.panelEsq.TabIndex = 0;
            // 
            // btnCad
            // 
            this.btnCad.BackColor = System.Drawing.Color.White;
            this.btnCad.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCad.FlatAppearance.BorderSize = 2;
            this.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad.Location = new System.Drawing.Point(43, 485);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(210, 36);
            this.btnCad.TabIndex = 5;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = false;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // lblEasyHealth
            // 
            this.lblEasyHealth.AutoSize = true;
            this.lblEasyHealth.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEasyHealth.Location = new System.Drawing.Point(72, 339);
            this.lblEasyHealth.Name = "lblEasyHealth";
            this.lblEasyHealth.Size = new System.Drawing.Size(136, 44);
            this.lblEasyHealth.TabIndex = 1;
            this.lblEasyHealth.Text = "Easy Health    \r\n    Solutions";
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(43, 71);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(194, 174);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // PanelDir
            // 
            this.PanelDir.BackColor = System.Drawing.Color.White;
            this.PanelDir.Controls.Add(this.btnClose);
            this.PanelDir.Controls.Add(this.btnLog);
            this.PanelDir.Controls.Add(this.txtPass);
            this.PanelDir.Controls.Add(this.lblPass);
            this.PanelDir.Controls.Add(this.txtLog);
            this.PanelDir.Controls.Add(this.lblLog);
            this.PanelDir.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelDir.Location = new System.Drawing.Point(300, 0);
            this.PanelDir.Name = "PanelDir";
            this.PanelDir.Size = new System.Drawing.Size(305, 575);
            this.PanelDir.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(262, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLog.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLog.FlatAppearance.BorderSize = 2;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(48, 485);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(210, 36);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Log-In";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click_1);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(48, 133);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(164, 26);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(44, 109);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(59, 21);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Senha";
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(48, 75);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(164, 27);
            this.txtLog.TabIndex = 1;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(44, 51);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(55, 21);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "Log in";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(605, 575);
            this.Controls.Add(this.PanelDir);
            this.Controls.Add(this.panelEsq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelEsq.ResumeLayout(false);
            this.panelEsq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.PanelDir.ResumeLayout(false);
            this.PanelDir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEsq;
        private System.Windows.Forms.Label lblEasyHealth;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Panel PanelDir;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnClose;
    }
}

