using System;
using System.Windows.Forms;

namespace l_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_About_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void button_Area_Click(object sender, EventArgs e)
        {
            double wide, length;
            try
            {
                wide = Convert.ToDouble(textBox_Wide.Text);
                length = Convert.ToDouble(textBox_Length.Text);
                if (wide < 0 || length < 0)
                {
                    MessageBox.Show("Uncorrect input." + "\n" + "Enter length and wide");
                    button_Area.Text = "Area";
                }
                else
                { 
                    Rectangle rectangle = new Rectangle();

                    rectangle.Wide = wide;
                    rectangle.Length = length;

                    textBox_Area.Text = (rectangle.Area(wide, length)).ToString();

                    button_Area.Text = "Done";
                    textBox_Area.Enabled   = !textBox_Area.Enabled;
                    textBox_Wide.Enabled   = !textBox_Wide.Enabled;
                    textBox_Length.Enabled = !textBox_Length.Enabled;

                    Right_Not right_Not = new Right_Not();
                    right_Not.label_ans.Text = textBox_Wide.Text;
                    right_Not.ShowDialog();
                    Answer_label.Text = right_Not.To_answer;
                }
            }
            catch (FormatException)
            {
                if (textBox_Length.Text == "" || textBox_Wide.Text == "")
                {
                    MessageBox.Show("Uncorrect input." + "\n" + "Enter length and wide");
                    button_Area.Text = "Area";
                }
                else
                {
                    DialogResult result = MessageBox.Show("Uncorrect input.\n" + "Wrong format of data.\n" + "Repeat?", "Error",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) ;
                    switch (result)
                    {
                        case DialogResult.Yes:
                            textBox_Length.Text = "";
                            textBox_Wide.Text = "";
                            button_Area.Text = "Area";
                            break;
                        case DialogResult.No:
                            this.Close();
                            break;
                    }
                }
            }
        }

        private void button_Clean_Click(object sender, EventArgs e)
        {
            textBox_Length.Text = "";
            textBox_Wide.Text   = "";
            textBox_Area.Text   = "";
            button_Area.Text    = "Area";
            Answer_label.Text = "Unknown";

            textBox_Area.Enabled = !textBox_Area.Enabled;
            textBox_Wide.Enabled = !textBox_Wide.Enabled;
            textBox_Length.Enabled = !textBox_Length.Enabled;
        }
    }
}
