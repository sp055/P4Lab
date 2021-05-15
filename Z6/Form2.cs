using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z6
{
    public partial class Form2 : Form
    {
        public int Max { get; private set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Max = int.Parse(textBox1.Text);
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            bool result = int.TryParse(textBox1.Text, out _);

            if (!result)
            {
                errorProvider1.SetError(textBox1, "To nie jest poprawna liczba");
                SystemSounds.Exclamation.Play();
            }
        }
    }
}
