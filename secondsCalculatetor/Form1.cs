using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secondsCalculatetor
{
    public partial class Form1 : Form

        //
        // Sylvanus Edi
        // this is my work
        // 02/05/2019
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seconds;
            try
            {
                //Declaring Variables
               
                seconds = int.Parse(txt_input.Text);

             
            }
            catch
            {
                MessageBox.Show("Enter seconds");
                return;
            }
            String resultText = "";
            if (seconds >= 60)
            {
                resultText += "" + seconds / 60 + " Minutes\n";
            }
            if (seconds >= 3600)
            {
                resultText += "" + seconds / 3600 + "Hours\n";
            }
            if (seconds >= 86400)
            {
                resultText += "" + seconds / 86400 + " Days";
            }

            result.Text = resultText;
        }
    }
}
