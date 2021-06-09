using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathProblems
{
    public partial class Math : Form
    {
        public Random rnd = new Random();
        public int btnindex = -1;
        public int correct = 0;
        public int wrong = 0;
        public Math()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMode.SelectedIndex = 0;
            LoadProblem();
        }

        public void LoadProblem()
        {
            retry:
            int num1 = -1;
            int num2 = -1;
            switch (nmDigits.Value)
            {
                case 1:
                    num1 = rnd.Next(1, 10);
                    num2 = rnd.Next(1, 10);
                    btnAnswer1.Text = rnd.Next(1, 10).ToString();
                    btnAnswer2.Text = rnd.Next(1, 10).ToString();
                    btnAnswer3.Text = rnd.Next(1, 10).ToString();
                    btnAnswer4.Text = rnd.Next(1, 10).ToString();
                    break;
                case 2:
                    num1 = rnd.Next(10, 100);
                    num2 = rnd.Next(10, 100);
                    btnAnswer1.Text = rnd.Next(10, 100).ToString();
                    btnAnswer2.Text = rnd.Next(10, 100).ToString();
                    btnAnswer3.Text = rnd.Next(10, 100).ToString();
                    btnAnswer4.Text = rnd.Next(10, 100).ToString();
                    break;
                case 3:
                    num1 = rnd.Next(100, 1000);
                    num2 = rnd.Next(100, 1000);
                    btnAnswer1.Text = rnd.Next(100, 1000).ToString();
                    btnAnswer2.Text = rnd.Next(100, 1000).ToString();
                    btnAnswer3.Text = rnd.Next(100, 1000).ToString();
                    btnAnswer4.Text = rnd.Next(100, 1000).ToString();
                    break;
                case 4:
                    num1 = rnd.Next(1000, 10000);
                    num2 = rnd.Next(1000, 10000);
                    btnAnswer1.Text = rnd.Next(1000, 10000).ToString();
                    btnAnswer2.Text = rnd.Next(1000, 10000).ToString();
                    btnAnswer3.Text = rnd.Next(1000, 10000).ToString();
                    btnAnswer4.Text = rnd.Next(1000, 10000).ToString();
                    break;
                case 5:
                    num1 = rnd.Next(10000, 100000);
                    num2 = rnd.Next(10000, 100000);
                    btnAnswer1.Text = rnd.Next(10000, 100000).ToString();
                    btnAnswer2.Text = rnd.Next(10000, 100000).ToString();
                    btnAnswer3.Text = rnd.Next(10000, 100000).ToString();
                    btnAnswer4.Text = rnd.Next(10000, 100000).ToString();
                    break;
            }
            
            int equation = 0;

            switch (cbMode.SelectedItem)
            {
                case "Addition":
                    equation = num1 + num2;
                    lblProblem.Text = $"{num1} + {num2} = ?";
                    break;
                case "Subtraction":
                    equation = num1 - num2;
                    lblProblem.Text = $"{num1} - {num2} = ?";
                    break;
                case "Multiply":
                    equation = num1 * num2;
                    lblProblem.Text = $"{num1} × {num2} = ?";
                    break;
                case "Division":
                    equation = num1 / num2;
                    lblProblem.Text = $"{num1} ÷ {num2} = ?";
                    break;
            }

            btnindex = rnd.Next(1, 5);
            switch (btnindex)
            {
                case 1:
                    btnAnswer1.Text = equation.ToString();
                    break;
                case 2:
                    btnAnswer2.Text = equation.ToString();
                    break;
                case 3:
                    btnAnswer3.Text = equation.ToString();
                    break;
                case 4:
                    btnAnswer4.Text = equation.ToString();
                    break;
            }

            if (btnAnswer1.Text == equation.ToString() && btnindex != 1)
                goto retry;
            if (btnAnswer2.Text == equation.ToString() && btnindex != 2)
                goto retry;
            if (btnAnswer3.Text == equation.ToString() && btnindex != 3)
                goto retry;
            if (btnAnswer4.Text == equation.ToString() && btnindex != 4)
                goto retry;

            if (btnAnswer1.Text == btnAnswer2.Text || btnAnswer1.Text == btnAnswer3.Text || btnAnswer1.Text == btnAnswer4.Text || btnAnswer2.Text == btnAnswer3.Text || btnAnswer2.Text == btnAnswer4.Text || btnAnswer3.Text == btnAnswer4.Text)
                goto retry;
        }

        public void UpdateCounter()
        {
            lblCorrectWrong.Text = "Correct Answers: " + correct + "\n" + "Wrong Answers: " + wrong;
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            if (btnindex == 1)
            {
                correct++;
                UpdateCounter();
                MessageBox.Show("Correct!", "Math Problems");
                LoadProblem();
            }
            else
            {
                wrong++;
                UpdateCounter();
                MessageBox.Show("Wrong!", "Math Problems");
            }
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            if (btnindex == 2)
            {
                correct++;
                UpdateCounter();
                MessageBox.Show("Correct!", "Math Problems");
                LoadProblem();
            }
            else
            {
                wrong++;
                UpdateCounter();
                MessageBox.Show("Wrong!", "Math Problems");
            }
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            if (btnindex == 3)
            {
                correct++;
                UpdateCounter();
                MessageBox.Show("Correct!", "Math Problems");
                LoadProblem();
            }
            else
            {
                wrong++;
                UpdateCounter();
                MessageBox.Show("Wrong!", "Math Problems");
            }
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            if (btnindex == 4)
            {
                correct++;
                UpdateCounter();
                MessageBox.Show("Correct!", "Math Problems");
                LoadProblem();
            }
            else
            {
                wrong++;
                UpdateCounter();
                MessageBox.Show("Wrong!", "Math Problems");
            }
        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProblem();
        }

        private void nmDigits_ValueChanged(object sender, EventArgs e)
        {
            LoadProblem();
        }
    }
}