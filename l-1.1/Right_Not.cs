using System;
using System.Windows.Forms;

namespace l_1._1
{
    public partial class Right_Not : Form
    {
        Form1 form = new Form1();
        string to_answer;
        public string To_answer
        {
            get { return to_answer; }
            set { to_answer = value; }
        }
        public Right_Not()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            to_answer = "Yes";
            this.Close();
        }

        private void No_Click(object sender, EventArgs e)
        {
            to_answer = "No";
            this.Close();
        }
    }
}
