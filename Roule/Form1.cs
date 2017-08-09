using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roule
{
    public partial class Form1 : Form
    {
        char[] tab = new char[37];
        int argent,mise;
        public Form1()
        {
            argent = 1000;
            mise = 5;
            tab[0] = 'V';
            tab[1] = tab[3] = tab[5] = tab[7] = tab[9] = tab[12] = tab[14] = tab[16] = tab[18] = tab[19] = tab[21] = tab[23] = tab[25] = tab[27] = tab[30] = tab[32] = tab[34] = tab[36] = 'R';
            tab[2] = tab[4] = tab[6] = tab[8] = tab[10] = tab[11] = tab[13] = tab[15] = tab[17] = tab[20] = tab[22] = tab[24] = tab[26] = tab[28] = tab[29] = tab[31] = tab[33] = tab[35] = 'N';

            InitializeComponent();
            string argtext = argent.ToString();
            Argentbox.Text = argtext + "€";
            misebox.Text = mise.ToString();

        }

        private void butplus5_Click(object sender, EventArgs e)
        {
            mise += 5;
            misebox.Text = mise.ToString();
        }

        private void butplus10_Click(object sender, EventArgs e)
        {
            mise += 10;
            misebox.Text = mise.ToString();
        }

        private void butplus50_Click(object sender, EventArgs e)
        {
            mise += 50;
            misebox.Text = mise.ToString();
        }

        private void butplus100_Click(object sender, EventArgs e)
        {
            mise += 100;
            misebox.Text = mise.ToString();
        }

        private void butmoin5_Click(object sender, EventArgs e)
        {
            if(mise>5)
            { 
            mise -= 5;
            misebox.Text = mise.ToString();
            }
            else
            {
                mise = 5;
                misebox.Text = mise.ToString();

            }
        }

        private void butmoin10_Click(object sender, EventArgs e)
        {
            if (mise > 15)
            {
                mise -= 10;
                misebox.Text = mise.ToString();
            }
            else
            {
                mise = 5;
                misebox.Text = mise.ToString();

            }
        }

        private void butmoin50_Click(object sender, EventArgs e)
        {
                if (mise > 55)
                {
                    mise -= 50;
                    misebox.Text = mise.ToString();
                }
            else
            {
                mise = 5;
                misebox.Text = mise.ToString();

            }
        }

        private void butmoin100_Click(object sender, EventArgs e)
        {
                    if (mise > 105)
                    {
                        mise -= 100;
                        misebox.Text = mise.ToString();
                    }
            else
            {
                mise = 5;
                misebox.Text = mise.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            argent = 1000;
            mise = 5;
            string argtext = argent.ToString();
            Argentbox.Text = argtext + "€";
            misebox.Text = mise.ToString();
            resulroul.Text = null;
        }

      



        public void butchif(object sender)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            int resultchoix = rand.Next(0, 36);
            string resultat = (sender as Button).Text;
            int resul = int.Parse(resultat);
            if (tab[resultchoix]=='R')
            {
                resulroul.ForeColor = Color.Red;
                resulroul.Text = resultchoix.ToString();
            }
            else if(tab[resultchoix] == 'N')
            {
                resulroul.ForeColor = Color.Black;
                resulroul.Text = resultchoix.ToString();
            }
            else
            
                {
                    resulroul.ForeColor = Color.Green;
                    resulroul.Text = resultchoix.ToString();
                }
            

            if (resultchoix == resul)
            {
                argent += (mise * 7);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }

            else
            {
                argent -= (mise * 7);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            PerduGagner(argent);




        }
        private void button1_Click(object sender, EventArgs e)
        {
            butchif(sender);
        }

        private void but112_Click(object sender, EventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            int resultchoix = rand.Next(0, 36);
            if (tab[resultchoix] == 'R')
            {
                resulroul.ForeColor = Color.Red;
                resulroul.Text = resultchoix.ToString();
            }
            else if (tab[resultchoix] == 'N')
            {
                resulroul.ForeColor = Color.Black;
                resulroul.Text = resultchoix.ToString();
            }
            else

            {
                resulroul.ForeColor = Color.Green;
                resulroul.Text = resultchoix.ToString();
            }

            if (resultchoix>0 & resultchoix<=12 )
            {
                argent += (mise * 2);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            else
            {
                argent -= (mise * 2);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            PerduGagner(argent);
        }

        private void but212_Click(object sender, EventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            int resultchoix = rand.Next(0, 36);
            if (tab[resultchoix] == 'R')
            {
                resulroul.ForeColor = Color.Red;
                resulroul.Text = resultchoix.ToString();
            }
            else if (tab[resultchoix] == 'N')
            {
                resulroul.ForeColor = Color.Black;
                resulroul.Text = resultchoix.ToString();
            }
            else

            {
                resulroul.ForeColor = Color.Green;
                resulroul.Text = resultchoix.ToString();
            }

            if (resultchoix >= 13 & resultchoix <= 24)
            {
                argent += (mise * 2);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            else
            {
                argent -= (mise * 2);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            PerduGagner(argent);
        }

        private void but312_Click(object sender, EventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            int resultchoix = rand.Next(0, 36);
            if (tab[resultchoix] == 'R')
            {
                resulroul.ForeColor = Color.Red;
                resulroul.Text = resultchoix.ToString();
            }
            else if (tab[resultchoix] == 'N')
            {
                resulroul.ForeColor = Color.Black;
                resulroul.Text = resultchoix.ToString();
            }
            else

            {
                resulroul.ForeColor = Color.Green;
                resulroul.Text = resultchoix.ToString();
            }

            if (resultchoix > 24 & resultchoix <= 36)
            {
                argent += (mise * 2);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            else
            {
                argent -= (mise * 2);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            PerduGagner(argent);
        }

        private void but1936_Click(object sender, EventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            int resultchoix = rand.Next(0, 36);
            if (tab[resultchoix] == 'R')
            {
                resulroul.ForeColor = Color.Red;
                resulroul.Text = resultchoix.ToString();
            }
            else if (tab[resultchoix] == 'N')
            {
                resulroul.ForeColor = Color.Black;
                resulroul.Text = resultchoix.ToString();
            }
            else

            {
                resulroul.ForeColor = Color.Green;
                resulroul.Text = resultchoix.ToString();
            }

            if (resultchoix > 18 & resultchoix <= 36)
            {
                argent += (mise * 1);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            else
            {
                argent -= (mise * 2);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            PerduGagner(argent);
        }

        private void but118_Click(object sender, EventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            int resultchoix = rand.Next(0, 36);
            if (tab[resultchoix] == 'R')
            {
                resulroul.ForeColor = Color.Red;
                resulroul.Text = resultchoix.ToString();
            }
            else if (tab[resultchoix] == 'N')
            {
                resulroul.ForeColor = Color.Black;
                resulroul.Text = resultchoix.ToString();
            }
            else

            {
                resulroul.ForeColor = Color.Green;
                resulroul.Text = resultchoix.ToString();
            }

            if (resultchoix >0 & resultchoix <= 18)
            {
                argent += (mise * 1);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            else
            {
                argent -= (mise * 1);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            PerduGagner(argent);
        }

        private void butrouge_Click(object sender, EventArgs e)
        {
            char resul = 'R';
            Random rand = new Random((int)DateTime.Now.Ticks);
            int resultchoix = rand.Next(0, 36);
            if (tab[resultchoix] == 'R')
            {
                resulroul.ForeColor = Color.Red;
                resulroul.Text = resultchoix.ToString();
            }
            else if (tab[resultchoix] == 'N')
            {
                resulroul.ForeColor = Color.Black;
                resulroul.Text = resultchoix.ToString();
            }
            else

            {
                resulroul.ForeColor = Color.Green;
                resulroul.Text = resultchoix.ToString();
            }

            if (tab[resultchoix]== resul)
            {
                argent += (mise * 1);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            else
            {
                argent -= (mise * 1);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            PerduGagner(argent);
        }

        private void butnoir_Click(object sender, EventArgs e)
        {
            char resul = 'N';
            Random rand = new Random((int)DateTime.Now.Ticks);
            int resultchoix = rand.Next(0, 36);
            if (tab[resultchoix] == 'R')
            {
                resulroul.ForeColor = Color.Red;
                resulroul.Text = resultchoix.ToString();
            }
            else if (tab[resultchoix] == 'N')
            {
                resulroul.ForeColor = Color.Black;
                resulroul.Text = resultchoix.ToString();
            }
            else

            {
                resulroul.ForeColor = Color.Green;
                resulroul.Text = resultchoix.ToString();
            }

            if (tab[resultchoix] == resul)
            {
                argent += (mise * 1);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            else
            {
                argent -= (mise * 1);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            PerduGagner(argent);
        }

        private void butpair_Click(object sender, EventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            int resultchoix = rand.Next(0, 36);
            if (tab[resultchoix] == 'R')
            {
                resulroul.ForeColor = Color.Red;
                resulroul.Text = resultchoix.ToString();
            }
            else if (tab[resultchoix] == 'N')
            {
                resulroul.ForeColor = Color.Black;
                resulroul.Text = resultchoix.ToString();
            }
            else

            {
                resulroul.ForeColor = Color.Green;
                resulroul.Text = resultchoix.ToString();
            }

            if (resultchoix%2 == 0)
            {
                argent += (mise * 1);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            else
            {
                argent -= (mise * 1);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            PerduGagner(argent);
        }

        private void butimpair_Click(object sender, EventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            int resultchoix = rand.Next(0, 36);
            if (tab[resultchoix] == 'R')
            {
                resulroul.ForeColor = Color.Red;
                resulroul.Text = resultchoix.ToString();
            }
            else if (tab[resultchoix] == 'N')
            {
                resulroul.ForeColor = Color.Black;
                resulroul.Text = resultchoix.ToString();
            }
            else

            {
                resulroul.ForeColor = Color.Green;
                resulroul.Text = resultchoix.ToString();
            }

            if (resultchoix % 2 != 0)
            {
                argent += (mise * 1);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            else
            {
                argent -= (mise * 1);
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            PerduGagner(argent);
        }

        private void but22a1_Click(object sender, EventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            int resultchoix = rand.Next(0, 36);
            int tempo = 0;
            if (tab[resultchoix] == 'R')
            {
                resulroul.ForeColor = Color.Red;
                resulroul.Text = resultchoix.ToString();
            }
            else if (tab[resultchoix] == 'N')
            {
                resulroul.ForeColor = Color.Black;
                resulroul.Text = resultchoix.ToString();
            }
            else

            {
                resulroul.ForeColor = Color.Green;
                resulroul.Text = resultchoix.ToString();
            }

            for (int i = 2; i <= 34; i += 3)
            {
                if (resultchoix == i)
                {
                    tempo++;
                }

            }
            if (tempo != 0)
            {
                argent += mise;
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            else
            {
                argent -= mise;
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            PerduGagner(argent);
        }

        private void but32a1_Click(object sender, EventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            int resultchoix = rand.Next(0, 36);
            int tempo = 0;
            if (tab[resultchoix] == 'R')
            {
                resulroul.ForeColor = Color.Red;
                resulroul.Text = resultchoix.ToString();
            }
            else if (tab[resultchoix] == 'N')
            {
                resulroul.ForeColor = Color.Black;
                resulroul.Text = resultchoix.ToString();
            }
            else

            {
                resulroul.ForeColor = Color.Green;
                resulroul.Text = resultchoix.ToString();
            }

            for (int i = 3; i <= 34; i += 3)
            {
                if (resultchoix == i)
                {
                    tempo++;
                }

            }
            if (tempo != 0)
            {
                argent += mise;
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            else
            {
                argent -= mise;
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
            }
            PerduGagner(argent);
        }



        private void but12a1_Click(object sender, EventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            int resultchoix = rand.Next(0, 36);
            int tempo=0;
            if (tab[resultchoix] == 'R')
            {
                resulroul.ForeColor = Color.Red;
                resulroul.Text = resultchoix.ToString();
            }
            else if (tab[resultchoix] == 'N')
            {
                resulroul.ForeColor = Color.Black;
                resulroul.Text = resultchoix.ToString();
            }
            else

            {
                resulroul.ForeColor = Color.Green;
                resulroul.Text = resultchoix.ToString();
            }

            for (int i=1; i <= 34; i+=3)
            { 
                if (resultchoix == i)
                 {
                    tempo++;
                }

            }
            if(tempo!=0)
            { 
            argent += mise;
            string argtext = argent.ToString();
            Argentbox.Text = argtext + "€";
            }
            else
                {
                argent -= mise;
                string argtext = argent.ToString();
                Argentbox.Text = argtext + "€";
             }
            PerduGagner(argent);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        public void PerduGagner (int arg)
        {
            if (arg <= 0)
            {
                if (MessageBox.Show("Vous avez perdu!\nVoulez vous recommmencer?", "Perdu",
      MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)== DialogResult.Yes)
                {
                    argent = 1000;
                    mise = 5;
                    string argtext = argent.ToString();
                    Argentbox.Text = argtext + "€";
                    misebox.Text = mise.ToString();
                    resulroul.Text = null;
         }
                else
                {

                    Close();
                }
            }
            if (arg >= 10000)
            {
                if (MessageBox.Show("Vous avez gagner!\nVoulez vous recommmencer?", "Gagner",
      MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    argent = 1000;
                    mise = 5;
                    string argtext = argent.ToString();
                    Argentbox.Text = argtext + "€";
                    misebox.Text = mise.ToString();
                    resulroul.Text = null;

                }
                else
                {

                    Close();
                }
            }

        }

    }

    }

