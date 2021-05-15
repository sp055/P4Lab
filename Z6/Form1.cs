using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Z6
{
    public partial class Form1 : Form
    {
        //public ToolStripProgressBar toolStripProgress;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(); // dodaje obrazek z pliku tak jak w projektancie
            //pictureBox1.Image.Dispose(); //usuwa obrazek z pamięci
            progressBar1.Increment(10);

            var button = new Button()
            {
                Text = "New Button"
            };
            button.Click += Button_Click;
            button.Tag = "test";
            button.Top = new Random().Next(100);

            panel1.Controls.Add(button);

            SystemSounds.Asterisk.Play();

            SoundPlayer soundPlayer = new SoundPlayer();
            //toolStripProgress.Increment(1);

        }

        private void Button_Click(object sender, EventArgs e)
        {
            
            progressBar1.Value = 0;
            var control = (Control)sender;
            MessageBox.Show($"Został kliknięty przycisk pod nazwą {control.Tag}", $"UWAGA!");

            //toolStripProgress = new ToolStripProgressBar();
            //toolStripProgress.Maximum = 10;
            //toolStripProgress.Step = 1;
            //statusStrip1.Items.Add(toolStripProgress);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.ShowDialog(); //czeka na dane z drugiego formularza

            progressBar1.Maximum = form.Max;// <--
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
