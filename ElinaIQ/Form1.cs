using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElinaIQ
{
    public partial class IQ : Form
    {
        public IQ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int iq = int.Parse(textBox2.Text);
            int dead = int.Parse(textBox4.Text);
            int years = 0;
            for( years = int.Parse(textBox3.Text); years < dead; years++)
            {
                MessageBox.Show( "Jmenuji se " + name + " je mi " + years + " a mám " + iq + " iq");
                --iq;
                --iq;



            }
           
           

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
