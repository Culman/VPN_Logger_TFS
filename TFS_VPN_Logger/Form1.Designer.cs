namespace TFS_VPN_Logger
{
    partial class FormMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labeluser = new System.Windows.Forms.Label();
            this.iconuser = new FontAwesome.Sharp.IconPictureBox();
            this.labelAppheading = new System.Windows.Forms.Label();
            this.panelmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconuser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.LightGray;
            this.panelmenu.Controls.Add(this.panel2);
            this.panelmenu.Controls.Add(this.panel1);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelmenu.Location = new System.Drawing.Point(-2, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(1674, 1169);
            this.panelmenu.TabIndex = 0;
            this.panelmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmenu_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel2.Location = new System.Drawing.Point(-16, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 1258);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labeluser);
            this.panel1.Controls.Add(this.iconuser);
            this.panel1.Controls.Add(this.labelAppheading);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1730, 180);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TFS_VPN_Logger.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(4, -31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.BackColor = System.Drawing.Color.Transparent;
            this.labeluser.Font = new System.Drawing.Font("Exo", 15F, System.Drawing.FontStyle.Bold);
            this.labeluser.ForeColor = System.Drawing.Color.White;
            this.labeluser.Location = new System.Drawing.Point(1192, 71);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(90, 42);
            this.labeluser.TabIndex = 4;
            this.labeluser.Text = "User:";
            // 
            // iconuser
            // 
            this.iconuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.iconuser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconuser.IconColor = System.Drawing.Color.White;
            this.iconuser.IconSize = 42;
            this.iconuser.Location = new System.Drawing.Point(1155, 74);
            this.iconuser.Name = "iconuser";
            this.iconuser.Size = new System.Drawing.Size(48, 42);
            this.iconuser.TabIndex = 3;
            this.iconuser.TabStop = false;
            // 
            // labelAppheading
            // 
            this.labelAppheading.AutoSize = true;
            this.labelAppheading.Font = new System.Drawing.Font("Exo", 26F, System.Drawing.FontStyle.Bold);
            this.labelAppheading.ForeColor = System.Drawing.Color.White;
            this.labelAppheading.Location = new System.Drawing.Point(208, 45);
            this.labelAppheading.Name = "labelAppheading";
            this.labelAppheading.Size = new System.Drawing.Size(766, 73);
            this.labelAppheading.TabIndex = 2;
            this.labelAppheading.Text = "TFSCZ/SK VPN Administration";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1672, 1169);
            this.Controls.Add(this.panelmenu);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TFSCZ/SK - VPN Administration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

