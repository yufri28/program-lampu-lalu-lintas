using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lampu_lalu_lintas
{
    public partial class Form1 : Form
    {
        int detik;
        int detikT;
        int detikS;
        int detikB;
        int hijauuuu;
        Random r;
        int kepadatanU;
        int kepadatanT;
        int kepadatanS;
        int kepadatanB;
        //int defaulT = 0;

        public Form1()
        {
            InitializeComponent();
            detik = 0;
            detikT = 0;
            detikS = 0;
            detikB = 0;
          
            r = new Random();
            kepadatanU = 0;
            kepadatanT =0;
            kepadatanS =0;
            kepadatanB =0;
            hijauuuu = 0;

        }
        
        private void Btn_start_Click(object sender, EventArgs e)
        {
            pB_merahT.BackColor = Color.Red;
            pB_merahS.BackColor = Color.Red;
            pB_merahB.BackColor = Color.Red;
            pB_merahU.BackColor = Color.Red;
            kepadatanU = r.Next(0, 100);
            //kepadatanT = r.Next(0, 100);
            //kepadatanS = r.Next(0, 100);
            //kepadatanB = r.Next(0, 100);
            Utara.Enabled = true;
            
            if (kepadatanU <= 25)
            {
                detik = 23;
                hijauuuu = 12 + (detik - 23);
            }
            else if (kepadatanU > 25 && kepadatanU <= 50)
            {
                detik = 26;
                hijauuuu = 12 + (detik - 24);
            }
            else
            {
                detik = 34;
                hijauuuu = 12 + (detik - 26);
            }
            
        }
        private void Utara_Tick(object sender, EventArgs e)
        {
            detik--;
            if (detik == 22 )
            {
                pB_merahU.BackColor = Color.White;
                pB_kuningU.BackColor = Color.Yellow;  
            }
            else if (detik == hijauuuu)
            {
                pB_merahU.BackColor = Color.White;
                pB_kuningU.BackColor = Color.White;
                pB_hijauU.BackColor = Color.Green;   
            }
            else if (detik == 5)
            {
                pB_merahU.BackColor = Color.White;
                pB_kuningU.BackColor = Color.Yellow;
                pB_hijauU.BackColor = Color.White;
            }
           
            else if(detik <= 0)
            {
                pB_merahU.BackColor = Color.Red;
                pB_kuningU.BackColor = Color.White;
                pB_hijauU.BackColor = Color.White;
                Utara.Enabled = false;
                Timur.Enabled = true;
                kepadatanT = r.Next(0, 100);
                if (kepadatanT <= 25)
                {
                    detikT = 23;
                    hijauuuu = 12 + (detikT - 23);
                }
                else if (kepadatanT > 25 && kepadatanT <= 50)
                {
                    detikT = 26;
                    hijauuuu = 12 + (detikT - 24);
                }
                else
                {
                    detikT = 34;
                    hijauuuu = 12 + (detikT - 26);
                }
                
                
            }
            lbl_KUtara.Text = kepadatanU.ToString();
            lbl_detikU.Text = detik.ToString();
        }

        private void Timur_Tick(object sender, EventArgs e)
        {
            detikT--;
       
            if (detikT == 22)
            {

                pB_merahT.BackColor = Color.White;
                pB_kuningT.BackColor = Color.Yellow;

            }
            else if (detikT == hijauuuu)
            {

                pB_merahT.BackColor = Color.White;
                pB_kuningT.BackColor = Color.White;
                pB_hijauT.BackColor = Color.Green;

            }
            else if (detikT == 5)
            {
                pB_merahT.BackColor = Color.White;
                pB_kuningT.BackColor = Color.Yellow;
                pB_hijauT.BackColor = Color.White;
            }
            else if (detikT <= 0)
            {
                pB_merahT.BackColor = Color.Red;
                pB_kuningT.BackColor = Color.White;
                pB_hijauT.BackColor = Color.White;
                Timur.Enabled = false;
                Selatan.Enabled = true;
                kepadatanS = r.Next(0, 100);
                
                if (kepadatanS <= 25)
                {
                    detikS = 23;
                    hijauuuu = 12 + (detikS - 23);
                }
                else if (kepadatanS > 25 && kepadatanS <= 50)
                {
                    detikS = 26;
                    hijauuuu = 12 + (detikS - 24);
                }
                else
                {
                    detikS = 34;
                    hijauuuu = 12 + (detikS - 26);
                }
               
               
            }
            lbl_KTimur.Text = kepadatanT.ToString();
            lbl_detikT.Text = detikT.ToString();
        }

        private void Selatan_Tick(object sender, EventArgs e)
        {
            detikS--;
            if (detikS == 22)
            {

                pB_merahS.BackColor = Color.White;
                pB_kuningS.BackColor = Color.Yellow;

            }
            else if (detikS == hijauuuu)
            {
                pB_merahS.BackColor = Color.White;
                pB_kuningS.BackColor = Color.White;
                pB_hijauS.BackColor = Color.Green;
            }
            else if (detikS == 5)
            {
                pB_merahS.BackColor = Color.White;
                pB_kuningS.BackColor = Color.Yellow;
                pB_hijauS.BackColor = Color.White;
            }
            else if (detikS <= 0)
            {
                pB_merahS.BackColor = Color.Red;
                pB_kuningS.BackColor = Color.White;
                pB_hijauS.BackColor = Color.White;
                Selatan.Enabled = false;
                Barat.Enabled = true;
                kepadatanB = r.Next(0, 100);
                detikB = 34;
                if (kepadatanB <= 25)
                {
                    detikB = 23;
                    hijauuuu = 12 + (detikB - 23);
                }
                else if (kepadatanB > 25 && kepadatanB <= 50)
                {
                    detikB = 26;
                    hijauuuu = 12 + (detikB - 24);
                }
                else
                {
                    detikB = 34;
                    hijauuuu = 12 + (detikB - 26);
                }
               
            }
            lbl_KSelatan.Text = kepadatanS.ToString();
            lbl_detikS.Text = detikS.ToString();
        }

        private void Barat_Tick(object sender, EventArgs e)
        {
            detikB--;
            if (detikB == 22)
            {

                pB_merahB.BackColor = Color.White;
                pB_kuningB.BackColor = Color.Yellow;

            }
            else if (detikB == hijauuuu)
            {

                pB_merahB.BackColor = Color.White;
                pB_kuningB.BackColor = Color.White;
                pB_hijauB.BackColor = Color.Green;

            }
            else if (detikB == 5)
            {
                pB_merahB.BackColor = Color.White;
                pB_kuningB.BackColor = Color.Yellow;
                pB_hijauB.BackColor = Color.White;
            }
            else if (detikB <= 0)
            {
                pB_merahB.BackColor = Color.Red;
                pB_kuningB.BackColor = Color.White;
                pB_hijauB.BackColor = Color.White;
                kepadatanU = r.Next(0, 100);
                Barat.Enabled = false;
                Utara.Enabled = true;
                kepadatanU = r.Next(0, 100);
                //lbl_KUtara.Text = defaulT.ToString();
                //lbl_KTimur.Text = defaulT.ToString();
                //lbl_KSelatan.Text = defaulT.ToString();
                //lbl_KBarat.Text = defaulT.ToString();
                if (kepadatanU <= 25)
                {
                    detik = 23;
                }
                else if (kepadatanU > 25 || kepadatanU <= 50)
                {
                    detik = 26;
                }
                else
                {
                    detik = 34;
                }
                
            }
            lbl_KBarat.Text = kepadatanB.ToString();
            lbl_detikB.Text = detikB.ToString();
            
        }

        private void Btn_stop_Click(object sender, EventArgs e)
        {
            detik = 0;
            detikT = 0;
            detikS = 0;
            detikB = 0;
            Utara.Enabled = false;
            Timur.Enabled = false;
            Selatan.Enabled = false;
            Barat.Enabled = false;
            lbl_detikU.Text = detik.ToString();
            lbl_detikT.Text = detikT.ToString();
            lbl_detikS.Text = detikS.ToString();
            lbl_detikB.Text = detikB.ToString();
            pB_merahU.BackColor = Color.White;
            pB_kuningU.BackColor = Color.White;
            pB_hijauU.BackColor = Color.White;
            pB_merahT.BackColor = Color.White;
            pB_kuningT.BackColor = Color.White;
            pB_hijauT.BackColor = Color.White;
            pB_merahS.BackColor = Color.White;
            pB_kuningS.BackColor = Color.White;
            pB_hijauS.BackColor = Color.White;
            pB_merahB.BackColor = Color.White;
            pB_kuningB.BackColor = Color.White;
            pB_hijauB.BackColor = Color.White;
        }

      
    }
}
