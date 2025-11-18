using Backprop;

namespace BPNN
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        bool trained = false;

        public Form1()
        {
            InitializeComponent();
            createbpnn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("0"))
                button1.Text = "1";
            else
                button1.Text = "0";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (button2.Text.Equals("0"))
                button2.Text = "1";
            else
                button2.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text.Equals("0"))
                button3.Text = "1";
            else
                button3.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text.Equals("0"))
                button4.Text = "1";
            else
                button4.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            epochs();
            trained = true;
            textBox3.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(!trained)
            {
                MessageBox.Show("Neural Network Not Trained");
                return;
            }

            nn.setInputs(0, double.Parse(button1.Text));
            nn.setInputs(1, double.Parse(button2.Text));
            nn.setInputs(2, double.Parse(button3.Text));
            nn.setInputs(3, double.Parse(button4.Text));
            nn.run();
            textBox3.Text = "" + Math.Round(nn.getOuputData(0),4);
        }

        private void createbpnn()
        {
            nn = new NeuralNet(4, 55, 1);
        }

        private void epochs()
        {
            for (int i = 0; i < 550; i++)
            {
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            createbpnn();
            trained = false;
            textBox3.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            createbpnn();
            epochs();
            trained = true;
            textBox3.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
