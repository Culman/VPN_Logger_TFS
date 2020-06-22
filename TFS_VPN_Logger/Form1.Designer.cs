namespace TFS_VPN_Logger
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
            this.panelmenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeluser = new System.Windows.Forms.Label();
            this.iconuser = new FontAwesome.Sharp.IconPictureBox();
            this.labelAppheading = new System.Windows.Forms.Label();
            this.panelmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconuser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.LightGray;
            this.panelmenu.Controls.Add(this.panel2);
            this.panelmenu.Controls.Add(this.panel1);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelmenu.Location = new System.Drawing.Point(-1, 0);
            this.panelmenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(1116, 760);
            this.panelmenu.TabIndex = 0;
            this.panelmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmenu_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel2.Location = new System.Drawing.Point(-11, 117);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 818);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.labeluser);
            this.panel1.Controls.Add(this.iconuser);
            this.panel1.Controls.Add(this.labelAppheading);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 117);
            this.panel1.TabIndex = 1;
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.BackColor = System.Drawing.Color.Transparent;
            this.labeluser.Font = new System.Drawing.Font("Exo", 15F, System.Drawing.FontStyle.Bold);
            this.labeluser.ForeColor = System.Drawing.Color.White;
            this.labeluser.Location = new System.Drawing.Point(795, 46);
            this.labeluser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(60, 28);
            this.labeluser.TabIndex = 4;
            this.labeluser.Text = "User:";
            // 
            // iconuser
            // 
            this.iconuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.iconuser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconuser.IconColor = System.Drawing.Color.White;
            this.iconuser.IconSize = 27;
            this.iconuser.Location = new System.Drawing.Point(770, 48);
            this.iconuser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconuser.Name = "iconuser";
            this.iconuser.Size = new System.Drawing.Size(32, 27);
            this.iconuser.TabIndex = 3;
            this.iconuser.TabStop = false;
            // 
            // labelAppheading
            // 
            this.labelAppheading.AutoSize = true;
            this.labelAppheading.Font = new System.Drawing.Font("Exo", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppheading.ForeColor = System.Drawing.Color.White;
            this.labelAppheading.Location = new System.Drawing.Point(12, 30);
            this.labelAppheading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppheading.Name = "labelAppheading";
            this.labelAppheading.Size = new System.Drawing.Size(585, 56);
            this.labelAppheading.TabIndex = 2;
            this.labelAppheading.Text = "TFSCZ/SK VPN Administration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1115, 760);
            this.Controls.Add(this.panelmenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconuser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAppheading;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labeluser;
        private FontAwesome.Sharp.IconPictureBox iconuser;
    }
}

