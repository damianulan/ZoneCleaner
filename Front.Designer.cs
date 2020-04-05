namespace ZoneCleaner
{
    partial class Front
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Temp_Btn = new System.Windows.Forms.Label();
            this.Recent_Btn = new System.Windows.Forms.Label();
            this.IntTmp_Btn = new System.Windows.Forms.Label();
            this.Cookies_Btn = new System.Windows.Forms.Label();
            this.Label_01 = new System.Windows.Forms.Label();
            this.NumFiles = new System.Windows.Forms.Label();
            this.SearchEngineTemp = new System.Windows.Forms.Timer(this.components);
            this.picboxPB = new System.Windows.Forms.PictureBox();
            this.Percentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU GŁÓWNE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "WYBIERZ TYP PLKÓW KTÓRY CHCESZ USUWAĆ";
            // 
            // Temp_Btn
            // 
            this.Temp_Btn.AutoSize = true;
            this.Temp_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Temp_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Temp_Btn.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Temp_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Temp_Btn.Location = new System.Drawing.Point(22, 75);
            this.Temp_Btn.Name = "Temp_Btn";
            this.Temp_Btn.Size = new System.Drawing.Size(144, 64);
            this.Temp_Btn.TabIndex = 2;
            this.Temp_Btn.Text = "TEMPORARY\r\nFILES";
            this.Temp_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Temp_Btn.Click += new System.EventHandler(this.Temp_Btn_Click);
            this.Temp_Btn.MouseLeave += new System.EventHandler(this.Temp_Btn_MouseLeave);
            this.Temp_Btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Temp_Btn_MouseMove);
            // 
            // Recent_Btn
            // 
            this.Recent_Btn.AutoSize = true;
            this.Recent_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Recent_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Recent_Btn.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Recent_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Recent_Btn.Location = new System.Drawing.Point(197, 91);
            this.Recent_Btn.Name = "Recent_Btn";
            this.Recent_Btn.Size = new System.Drawing.Size(154, 32);
            this.Recent_Btn.TabIndex = 3;
            this.Recent_Btn.Text = "RECENT FILES";
            this.Recent_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Recent_Btn.Click += new System.EventHandler(this.Recent_Btn_Click);
            this.Recent_Btn.MouseLeave += new System.EventHandler(this.Recent_Btn_MouseLeave);
            this.Recent_Btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Recent_Btn_MouseMove);
            // 
            // IntTmp_Btn
            // 
            this.IntTmp_Btn.AutoSize = true;
            this.IntTmp_Btn.BackColor = System.Drawing.Color.Transparent;
            this.IntTmp_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IntTmp_Btn.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IntTmp_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IntTmp_Btn.Location = new System.Drawing.Point(380, 59);
            this.IntTmp_Btn.Name = "IntTmp_Btn";
            this.IntTmp_Btn.Size = new System.Drawing.Size(144, 96);
            this.IntTmp_Btn.TabIndex = 4;
            this.IntTmp_Btn.Text = "INTERNET\r\nTEMPORARY\r\nFILES";
            this.IntTmp_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IntTmp_Btn.Click += new System.EventHandler(this.IntTmp_Btn_Click);
            this.IntTmp_Btn.MouseLeave += new System.EventHandler(this.IntTmp_Btn_MouseLeave);
            this.IntTmp_Btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.IntTmp_Btn_MouseMove);
            // 
            // Cookies_Btn
            // 
            this.Cookies_Btn.AutoSize = true;
            this.Cookies_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Cookies_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cookies_Btn.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cookies_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cookies_Btn.Location = new System.Drawing.Point(554, 91);
            this.Cookies_Btn.Name = "Cookies_Btn";
            this.Cookies_Btn.Size = new System.Drawing.Size(108, 32);
            this.Cookies_Btn.TabIndex = 5;
            this.Cookies_Btn.Text = "COOKIES";
            this.Cookies_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cookies_Btn.Click += new System.EventHandler(this.Cookies_Btn_Click);
            this.Cookies_Btn.MouseLeave += new System.EventHandler(this.Cookies_Btn_MouseLeave);
            this.Cookies_Btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cookies_Btn_MouseMove);
            // 
            // Label_01
            // 
            this.Label_01.AutoSize = true;
            this.Label_01.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_01.ForeColor = System.Drawing.Color.SteelBlue;
            this.Label_01.Location = new System.Drawing.Point(59, 227);
            this.Label_01.Name = "Label_01";
            this.Label_01.Size = new System.Drawing.Size(165, 25);
            this.Label_01.TabIndex = 8;
            this.Label_01.Text = "ZNALEZIONE PLIKI:";
            this.Label_01.Visible = false;
            // 
            // NumFiles
            // 
            this.NumFiles.AutoSize = true;
            this.NumFiles.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumFiles.ForeColor = System.Drawing.Color.SteelBlue;
            this.NumFiles.Location = new System.Drawing.Point(230, 227);
            this.NumFiles.Name = "NumFiles";
            this.NumFiles.Size = new System.Drawing.Size(45, 25);
            this.NumFiles.TabIndex = 9;
            this.NumFiles.Text = "293";
            this.NumFiles.Visible = false;
            // 
            // SearchEngineTemp
            // 
            this.SearchEngineTemp.Interval = 1000;
            this.SearchEngineTemp.Tick += new System.EventHandler(this.SearchEngine_Tick);
            // 
            // picboxPB
            // 
            this.picboxPB.Location = new System.Drawing.Point(23, 174);
            this.picboxPB.Name = "picboxPB";
            this.picboxPB.Size = new System.Drawing.Size(640, 20);
            this.picboxPB.TabIndex = 73;
            this.picboxPB.TabStop = false;
            this.picboxPB.Visible = false;
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Percentage.ForeColor = System.Drawing.Color.SteelBlue;
            this.Percentage.Location = new System.Drawing.Point(326, 197);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(42, 25);
            this.Percentage.TabIndex = 74;
            this.Percentage.Text = "0 %";
            this.Percentage.Visible = false;
            // 
            // Front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.picboxPB);
            this.Controls.Add(this.NumFiles);
            this.Controls.Add(this.Label_01);
            this.Controls.Add(this.Cookies_Btn);
            this.Controls.Add(this.IntTmp_Btn);
            this.Controls.Add(this.Recent_Btn);
            this.Controls.Add(this.Temp_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Front";
            this.Size = new System.Drawing.Size(690, 284);
            ((System.ComponentModel.ISupportInitialize)(this.picboxPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Temp_Btn;
        private System.Windows.Forms.Label Recent_Btn;
        private System.Windows.Forms.Label IntTmp_Btn;
        private System.Windows.Forms.Label Cookies_Btn;
        private System.Windows.Forms.Label Label_01;
        private System.Windows.Forms.Label NumFiles;
        private System.Windows.Forms.Timer SearchEngineTemp;
        private System.Windows.Forms.PictureBox picboxPB;
        private System.Windows.Forms.Label Percentage;
    }
}
