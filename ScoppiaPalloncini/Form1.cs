using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoppiaPalloncini
{
    public partial class schermata : Form
    {
        public int larghezzaFinestra;
        public int altezzaFinestra;
        public int punt;
        public int i;
        public string difficolta;
        public int momentoPerLaBomba;
        public bool bombatime;
        public schermata()
        {
            InitializeComponent();            
            larghezzaFinestra = 1920;
            altezzaFinestra = 1080;
            punt = 0;
            difficolta = "";
            bombatime = false;
            i = 0;            
            momentoPerLaBomba = generaNumeroCasuale(10, 250);
            nascondiTutto();
            mostraMenuPrincipale();
        }

        void mostraMenuPrincipale()
        {
            gioca.Visible = true;
            regole.Visible = true;
            esc.Visible = true;
        }

        void mostraTutto()
        {
            tempo.Visible = true;
            tempo1.Visible = true;
            P.Visible = true;
            punteggio.Visible = true;
        }

        void nascondiSecondoMenu()
        {
            simple.Visible = false;
            normal.Visible = false;
            hard.Visible = false;
            indietro2.Visible = false;
        }

        void mostraSecondoMenu()
        {
            simple.Location = new Point(767, 256);
            normal.Location = new Point(767, 383);
            hard.Location = new Point(767, 503);
            indietro2.Location = new Point(775, 633);            
            simple.Visible = true;
            normal.Visible = true;
            hard.Visible = true;
            indietro2.Visible = true;
        }

        void nascondiTutto()
        {
            indietro.Visible = false;
            gioca.Visible = false;
            nascondiTuttiIPalloncini();
            tempo.Visible = false;
            tempo1.Visible = false;
            esc.Visible = false;
            testoRegole.Visible = false;
            regole.Visible = false;
            P.Visible = false;
            punteggio.Visible = false;
            nascondiSecondoMenu();
            indietro2.Visible = false;

        }

        void nascondiTuttiIPalloncini()
        {
            palloncino0.Visible = false;
            palloncino1.Visible = false;
            palloncino2.Visible = false;
            palloncino3.Visible = false;
            palloncino4.Visible = false;
            palloncino5.Visible = false;
            palloncino6.Visible = false;
            palloncino7.Visible = false;
            palloncino8.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int generaNumeroCasuale(int min, int max)
        {
            Random x = new Random();
            return x.Next(min, max);
        }

        private void allargaPalloncini()
        {
            int min = 1;
            int max = 7;

            palloncino0.Height += generaNumeroCasuale(min, max);
            palloncino0.Width += generaNumeroCasuale(min, max);

            palloncino1.Width += generaNumeroCasuale(min, max);
            palloncino1.Height += generaNumeroCasuale(min, max);

            palloncino2.Width += generaNumeroCasuale(min, max);
            palloncino2.Height += generaNumeroCasuale(min, max);

            palloncino3.Width += generaNumeroCasuale(min, max);
            palloncino3.Height += generaNumeroCasuale(min, max);

            palloncino4.Width += generaNumeroCasuale(min, max);
            palloncino4.Height += generaNumeroCasuale(min, max);

            palloncino5.Width += generaNumeroCasuale(min, max);
            palloncino5.Height += generaNumeroCasuale(min, max);

            palloncino6.Width += generaNumeroCasuale(min, max);
            palloncino6.Height += generaNumeroCasuale(min, max);

            palloncino7.Width += generaNumeroCasuale(min, max);
            palloncino7.Height += generaNumeroCasuale(min, max);

            palloncino8.Width += generaNumeroCasuale(min, max);
            palloncino8.Height += generaNumeroCasuale(min, max);

        }

        private void spostaPalloncini()
        {
            int min = 12, max = 25;
            switch(difficolta)
            {
                case "simple":
                     min = 8; max = 20;
                    break;
                case "normal":
                     min = 12; max = 25;
                    break;
                case "hard":
                     min = 20; max = 25;
                    break;
            }

            if (bombatime) bomb.Top += 35;

            palloncino0.Top -= generaNumeroCasuale(min, max);
            palloncino1.Top -= generaNumeroCasuale(min, max);
            palloncino2.Top -= generaNumeroCasuale(min, max);
            palloncino3.Top -= generaNumeroCasuale(min, max);
            palloncino4.Top -= generaNumeroCasuale(min, max);
            palloncino5.Top -= generaNumeroCasuale(min, max);
            palloncino6.Top -= generaNumeroCasuale(min, max);
            palloncino7.Top -= generaNumeroCasuale(min, max);
            palloncino8.Top -= generaNumeroCasuale(min, max);
        }

        private void controlloPalloncini()
        {
            if (bomb.Location.Y <= 2) bombatime = false;
            if (palloncino0.Location.Y < -palloncino0.Height) genera(0);
            if (palloncino1.Location.Y < -palloncino1.Height) genera(1);
            if (palloncino2.Location.Y < -palloncino2.Height) genera(2);
            if (palloncino3.Location.Y < -palloncino3.Height) genera(3);
            if (palloncino4.Location.Y < -palloncino4.Height) genera(4);
            if (palloncino5.Location.Y < -palloncino5.Height) genera(5);
            if (palloncino6.Location.Y < -palloncino6.Height) genera(6);
            if (palloncino7.Location.Y < -palloncino7.Height) genera(7);
            if (palloncino8.Location.Y < -palloncino8.Height) genera(8);
        }

        private void generaBomba()
        {
            bombatime = true;
            int a = generaNumeroCasuale(10, larghezzaFinestra - 10);
            int b = 0;
            palloncino0.Width = 80;
            palloncino0.Height = 80;
            palloncino0.Location = new Point(a, b);
            bomb.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                allargaPalloncini();
                spostaPalloncini();
                controlloPalloncini();
                
                tempo1.Text = (100 - (i/3)).ToString();
                i++;
                if (i == momentoPerLaBomba)
                    generaBomba();
                if ((i/3)>100)
                    vinto();
        }

        private void colpito(int n)
        {
            punt++;
            if (n == 0)
                punt+= 4;
            punteggio.Text = punt.ToString();

            switch(n)
            {
                case 0:
                    palloncino0.Visible = false;
                    break;
                case 1:
                    palloncino1.Visible = false;
                    break;
                case 2:
                    palloncino2.Visible = false;
                    break;
                case 3:
                    palloncino3.Visible = false;
                    break;
                case 4:
                    palloncino4.Visible = false;
                    break;
                case 5:
                    palloncino5.Visible = false;
                    break;
                case 6:
                    palloncino6.Visible = false;
                    break;
                case 7:
                    palloncino7.Visible = false;
                    break;
                case 8:
                    palloncino8.Visible = false;
                    break;
            }
            genera(n);

        }
        private void vinto()
        {
            vittoria.Location = new Point(559, 278);
            vittoria.Text = "SCORE: " + punt.ToString();
            nascondiTutto();
            vittoria.Visible = true;
            timer1.Stop();
        }
        private void genera(int n)
        {
            int a = generaNumeroCasuale(10, larghezzaFinestra-10);
            int b = altezzaFinestra;
            switch (n)
            {
                case 0:
                    palloncino0.Visible = true;
                    palloncino0.Width = 0;
                    palloncino0.Height = 0;
                    palloncino0.Location = new Point(a, b);
                    break;
                case 1:
                    palloncino1.Visible = true;
                    palloncino1.Width = 0;
                    palloncino1.Height = 0;
                    palloncino1.Location = new Point(a, b);
                    break;
                case 2:
                    palloncino2.Visible = true;
                    palloncino2.Width = 0;
                    palloncino2.Height = 0;
                    palloncino2.Location = new Point(a, b);
                    break;
                case 3:
                    palloncino3.Visible = true;
                    palloncino3.Width = 0;
                    palloncino3.Height = 0;
                    palloncino3.Location = new Point(a, b);
                    break;
                case 4:
                    palloncino4.Visible = true;
                    palloncino4.Width = 0;
                    palloncino4.Height = 0;
                    palloncino4.Location = new Point(a, b);
                    break;
                case 5:
                    palloncino5.Visible = true;
                    palloncino5.Width = 0;
                    palloncino5.Height = 0;
                    palloncino5.Location = new Point(a, b);
                    break;
                case 6:
                    palloncino6.Visible = true;
                    palloncino6.Width = 0;
                    palloncino6.Height = 0;
                    palloncino6.Location = new Point(a, b);
                    break;
                case 7:
                    palloncino7.Visible = true;
                    palloncino7.Width = 0;
                    palloncino7.Height = 0;
                    palloncino7.Location = new Point(a, b);
                    break;
                case 8:
                    palloncino8.Visible = true;
                    palloncino8.Width = 0;
                    palloncino8.Height = 0;
                    palloncino8.Location = new Point(a, b);
                    break;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(punt>0)
            {
            punt--;
            punteggio.Text = punt.ToString();
            }
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void palloncino0_Click(object sender, EventArgs e)
        {
            colpito(0);
        }

        private void palloncino1_Click(object sender, EventArgs e)
        {
            colpito(1);
        }

        private void palloncino2_Click(object sender, EventArgs e)
        {
            colpito(2);
        }

        private void palloncino3_Click(object sender, EventArgs e)
        {
            colpito(3);
        }

        private void palloncino4_Click(object sender, EventArgs e)
        {
            colpito(4);
        }

        private void palloncino5_Click(object sender, EventArgs e)
        {
            colpito(5);
        }

        private void palloncino6_Click(object sender, EventArgs e)
        {
            colpito(6);
        }

        private void palloncino7_Click(object sender, EventArgs e)
        {
            colpito(7);
        }

        private void palloncino8_Click(object sender, EventArgs e)
        {
            colpito(8);
        }

        private void bomb_Click(object sender, EventArgs e)
        {
            bomb.Visible = false;
            for (int i = 0; i < 8; i++)
                colpito(i);
        }

        private void gioca_Click(object sender, EventArgs e)
        {
            nascondiTutto();
            mostraSecondoMenu();
            gioca.Visible = false;
        }

        private void regole_Click(object sender, EventArgs e)
        {
            nascondiTutto();
            regole.Top -= 50;
            //regole.Location = new Point(767, 268);
            regole.Visible = true;
            testoRegole.Location = new Point(503, 466);
            testoRegole.Visible = true;
            indietro.Visible = true;
        }

        private void esc_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void indietro_Click(object sender, EventArgs e)
        {
            nascondiTutto();
            regole.Top += 50;
            mostraMenuPrincipale();
        }

        private void simple_Click(object sender, EventArgs e)
        {
            inizia("simple");
        }
        void inizia(string d)
        {
            difficolta = d;
            nascondiTutto();
            titolo.Visible = false;
            timer1.Start();
            mostraTutto();
            for (int i = 0; i < 8; i++)
                genera(i);
        }
        private void normal_Click(object sender, EventArgs e)
        {
            inizia("normal");
        }

        private void hard_Click(object sender, EventArgs e)
        {
            inizia("hard");
        }

        private void indietro2_Click(object sender, EventArgs e)
        {
            nascondiSecondoMenu();
            mostraMenuPrincipale();
        }
    }
}
