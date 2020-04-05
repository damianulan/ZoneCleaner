using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ZoneCleaner
{
    public partial class Front : UserControl
    {
        public static string[] TempExt = { "*.tmp", "*.old", "*.$$$", "Thumbs.db", "*.db", "*.$db", "system.1st", "*.chk", "*.temp", "*._detmp" };

        int[] AllKeys = { 0, 1, 2, 3, 4};
        int i = 0;

        DirectoryInfo PF64 = new DirectoryInfo(Paths.ProgramFiles64);
        DirectoryInfo Curr = new DirectoryInfo(Directory.GetCurrentDirectory());
        string[] ProgramFiles64;
        string[] ProgramFiles86;
        string[] Current;
        string[] Personal;

        //pb = ProgressBar
        double pbUnit;
        int pbWIDTH, pbHEIGHT, pbComplete, operand, AllSeconds;

        Bitmap bmp;
        Graphics g;

        public Front()
        {
            InitializeComponent();

            AllSeconds = AllKeys.Length;
            //get picboxPB dimension
            pbWIDTH = picboxPB.Width;
            pbHEIGHT = picboxPB.Height;

            //pbComplete - This is equal to work completed in % [min = 0 max = 100]
            pbComplete = 0;

            //create bitmap
            bmp = new Bitmap(pbWIDTH, pbHEIGHT);

            //graphics
            g = Graphics.FromImage(bmp);

            //clear graphics
            g.Clear(Color.CadetBlue);

            //load bitmap in picturebox picboxPB
            picboxPB.Image = bmp;

            
        }

        private void Temp_Btn_Click(object sender, EventArgs e)
        {
            pbUnit = pbWIDTH / AllKeys.Length;
            SearchEngineTemp.Enabled = true;
            ProgressBar_On(sender, e);
            SearchEngineTemp.Start();

        }

        private void ProgressBar_On(object sender, EventArgs e)
        {
            Percentage.Visible = true;
            picboxPB.Visible = true;
        }

        private void ProgressBar_Off(object sender, EventArgs e)
        {
            Percentage.Visible = false;
            picboxPB.Visible = false;
        }

        private void Temp_Btn_MouseMove(object sender, MouseEventArgs e)
        {
            Temp_Btn.ForeColor = Color.SteelBlue;
        }

        private void Temp_Btn_MouseLeave(object sender, EventArgs e)
        {
            Temp_Btn.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void Recent_Btn_MouseMove(object sender, MouseEventArgs e)
        {
            Recent_Btn.ForeColor = Color.SteelBlue;
        }

        private void Recent_Btn_MouseLeave(object sender, EventArgs e)
        {
            Recent_Btn.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void IntTmp_Btn_MouseMove(object sender, MouseEventArgs e)
        {
            IntTmp_Btn.ForeColor = Color.SteelBlue;
        }

        private void IntTmp_Btn_MouseLeave(object sender, EventArgs e)
        {
            IntTmp_Btn.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void Cookies_Btn_MouseMove(object sender, MouseEventArgs e)
        {
            Cookies_Btn.ForeColor = Color.SteelBlue;
        }

        private void Cookies_Btn_MouseLeave(object sender, EventArgs e)
        {
            Cookies_Btn.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void Recent_Btn_Click(object sender, EventArgs e)
        {
            ProgressBar_Off(sender, e);
            ProgressBar_On(sender, e);
        }

        private void IntTmp_Btn_Click(object sender, EventArgs e)
        {
            ProgressBar_Off(sender, e);
            ProgressBar_On(sender, e);
        }

        private void Cookies_Btn_Click(object sender, EventArgs e)
        {
            ProgressBar_Off(sender, e);
            ProgressBar_On(sender, e);
        }

        private void ProgressBarEngine(object sender, EventArgs e)
        {
            pbComplete = pbComplete + 1;

            operand = (pbComplete * Convert.ToInt32(pbUnit));

            //clear graphics
            g.Clear(Color.CadetBlue);

            //draw progressbar
            g.FillRectangle(Brushes.SteelBlue, new Rectangle(0, 0, (int)(operand), pbHEIGHT));

            //load bitmap in picturebox picboxPB
            picboxPB.Image = bmp;
            double perc = ((pbUnit * 100) / pbWIDTH) * pbComplete;
            Percentage.Text = perc.ToString() + " %";
        }

        private void SearchEngine_Tick(object sender, EventArgs e)
        {

            if (i == AllKeys[0])
            {
                ProgressBarEngine(sender, e);
            }
            if(i == AllKeys[1])
            {
                ProgressBarEngine(sender, e);
                ProgramFiles64 = System.IO.Directory.GetFiles(Paths.ProgramFiles64, "*.tmp", SearchOption.AllDirectories);
            }
            if (i == AllKeys[2])
            {
                ProgressBarEngine(sender, e);

                ProgramFiles86 = System.IO.Directory.GetFiles(Paths.ProgramFiles86, "*.tmp", SearchOption.AllDirectories);
            }
            if(i == AllKeys[3]) // personal
            {
                ProgressBarEngine(sender, e);

                    string[] tmp1 = System.IO.Directory.GetFiles(Paths.Personal, TempExt[0], SearchOption.AllDirectories);
                    string[] tmp2 = System.IO.Directory.GetFiles(Paths.Personal, TempExt[1], SearchOption.AllDirectories);
                    string[] tmp3 = System.IO.Directory.GetFiles(Paths.Personal, TempExt[2], SearchOption.AllDirectories);
                Personal = new string[tmp1.Length + tmp2.Length + tmp3.Length];
                tmp1.CopyTo(Personal, 0);
                tmp2.CopyTo(Personal, tmp1.Length);
                tmp3.CopyTo(Personal, tmp1.Length+tmp2.Length);
            }
            if(i == AllKeys[4])
            {
                ProgressBarEngine(sender, e);
                int FileSum = ProgramFiles64.Length + ProgramFiles86.Length + Current.Length;
                NumFiles.Text = FileSum.ToString();
                Label_01.Visible = true;
                NumFiles.Visible = true;
                SearchEngineTemp.Stop();
            }
            i++;
        }
    }
}
