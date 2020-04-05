namespace ZoneCleaner
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
            this.TitleBar = new System.Windows.Forms.Panel();
            this.NamePrint = new System.Windows.Forms.PictureBox();
            this.Minimize_Btn = new System.Windows.Forms.Button();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.MenuBar = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.PictureBox();
            this.MainMenu = new System.Windows.Forms.PictureBox();
            this.Content = new System.Windows.Forms.Panel();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamePrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.TitleBar.BackColor = System.Drawing.Color.SteelBlue;
            this.TitleBar.Controls.Add(this.NamePrint);
            this.TitleBar.Controls.Add(this.Minimize_Btn);
            this.TitleBar.Controls.Add(this.Exit_Btn);
            this.TitleBar.Controls.Add(this.Logo);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(749, 32);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // NamePrint
            // 
            this.NamePrint.Image = global::ZoneCleaner.Properties.Resources.appbar_name;
            this.NamePrint.Location = new System.Drawing.Point(304, 2);
            this.NamePrint.Name = "NamePrint";
            this.NamePrint.Size = new System.Drawing.Size(133, 27);
            this.NamePrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NamePrint.TabIndex = 1;
            this.NamePrint.TabStop = false;
            // 
            // Minimize_Btn
            // 
            this.Minimize_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_Btn.FlatAppearance.BorderSize = 0;
            this.Minimize_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.Minimize_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Btn.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Minimize_Btn.Location = new System.Drawing.Point(671, 0);
            this.Minimize_Btn.Name = "Minimize_Btn";
            this.Minimize_Btn.Size = new System.Drawing.Size(36, 32);
            this.Minimize_Btn.TabIndex = 2;
            this.Minimize_Btn.Text = "_";
            this.Minimize_Btn.UseVisualStyleBackColor = true;
            this.Minimize_Btn.Click += new System.EventHandler(this.Minimize_Btn_Click);
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Btn.FlatAppearance.BorderSize = 0;
            this.Exit_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.Exit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Btn.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Exit_Btn.Location = new System.Drawing.Point(713, 0);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(36, 32);
            this.Exit_Btn.TabIndex = 1;
            this.Exit_Btn.Text = "X";
            this.Exit_Btn.UseVisualStyleBackColor = true;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::ZoneCleaner.Properties.Resources.appbar_radar_screen;
            this.Logo.Location = new System.Drawing.Point(0, -6);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(41, 41);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // MenuBar
            // 
            this.MenuBar.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.MenuBar.BackColor = System.Drawing.Color.SteelBlue;
            this.MenuBar.Controls.Add(this.Info);
            this.MenuBar.Controls.Add(this.MainMenu);
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuBar.Location = new System.Drawing.Point(0, 32);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(41, 302);
            this.MenuBar.TabIndex = 1;
            // 
            // Info
            // 
            this.Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Info.Image = global::ZoneCleaner.Properties.Resources.appbar_information;
            this.Info.Location = new System.Drawing.Point(0, 45);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(41, 39);
            this.Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Info.TabIndex = 3;
            this.Info.TabStop = false;
            this.Info.Click += new System.EventHandler(this.Info_Btn_Click);
            this.Info.MouseLeave += new System.EventHandler(this.Info_Btn_MouseLeave);
            this.Info.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Info_Btn_MouseMove);
            // 
            // MainMenu
            // 
            this.MainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenu.Image = global::ZoneCleaner.Properties.Resources.appbar_tiles_sixteen;
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(41, 39);
            this.MainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainMenu.TabIndex = 2;
            this.MainMenu.TabStop = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Btn_Click);
            this.MainMenu.MouseLeave += new System.EventHandler(this.MainMenu_Btn_MouseLeave);
            this.MainMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_Btn_MouseMove);
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(47, 38);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(690, 284);
            this.Content.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(749, 334);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.TitleBar);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NamePrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.MenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button Minimize_Btn;
        private System.Windows.Forms.Button Exit_Btn;
        private System.Windows.Forms.PictureBox NamePrint;
        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.PictureBox MainMenu;
        private System.Windows.Forms.PictureBox Info;
        public System.Windows.Forms.Panel Content;
    }
}

