using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace BackPropagationSarita
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 1, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 2000; i++)
            {
                //1
                //0000 - 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                //2
                //0001 - 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                //3
                //0010 - 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                //4
                //0011 - 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                //5
                //0100 - 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                //6
                //0101 - 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                //7
                //0110 - 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                //8
                //0111 - 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                //9
                //1000 - 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                //10
                //1001 - 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                //11
                //1010 - 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                //12
                //1011 - 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                //13
                //1100 - 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                //14
                //1101 - 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                //15
                //1110 - 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                //16
                //1111 - 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.setInputs(2, Convert.ToDouble(textBox3.Text));
            nn.setInputs(3, Convert.ToDouble(textBox4.Text));
            nn.run();
            textBox5.Text = "" + nn.getOuputData(0);
        }
    }
}
