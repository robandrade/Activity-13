using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_13
{
    public partial class Form1 : Form
    {

        private bool turnX = true;
        private int[,] matrix = new int[3, 3];

        public Form1()
        {
            InitializeComponent();
        }

        private void button0_0_Click(object sender, EventArgs e)
        {
            if (turnX)
            {
                button0_0.Text = "X";
                matrix[0, 0] = 1;
            }
            else
            {
                button0_0.Text = "O";
                matrix[0, 0] = 2;
            }
            turnX = !turnX;
            checkWinner();
            button0_0.Enabled = false;
        }

        private void button0_1_Click(object sender, EventArgs e)
        {
            if (turnX)
            {
                button0_1.Text = "X";
                matrix[0, 1] = 1;
            }
            else
            {
                button0_1.Text = "O";
                matrix[0, 1] = 2;
            }
            turnX = !turnX;
            checkWinner();
            button0_1.Enabled = false;
        }

        private void button0_2_Click(object sender, EventArgs e)
        {
            if (turnX)
            {
                button0_2.Text = "X";
                matrix[0, 2] = 1;
            }
            else
            {
                button0_2.Text = "O";
                matrix[0, 2] = 2;
            }
            turnX = !turnX;
            checkWinner();
            button0_2.Enabled = false;
        }

        private void button1_0_Click(object sender, EventArgs e)
        {
            if (turnX)
            {
                button1_0.Text = "X";
                matrix[1, 0] = 1;
            }
            else
            {
                button1_0.Text = "O";
                matrix[1, 0] = 2;
            }
            turnX = !turnX;
            checkWinner();
            button1_0.Enabled = false;
        }

        private void button1_1_Click(object sender, EventArgs e)
        {
            if (turnX)
            {
                button1_1.Text = "X";
                matrix[1, 1] = 1;
            }
            else
            {
                button1_1.Text = "O";
                matrix[1, 1] = 2;
            }
            turnX = !turnX;
            checkWinner();
            button1_1.Enabled = false;
        }

        private void button1_2_Click(object sender, EventArgs e)
        {
            if (turnX)
            {
                button1_2.Text = "X";
                matrix[1, 2] = 1;
            }
            else
            {
                button1_2.Text = "O";
                matrix[1, 2] = 2;
            }
            turnX = !turnX;
            checkWinner();
            button1_2.Enabled = false;
        }

        private void button2_0_Click(object sender, EventArgs e)
        {
            if (turnX)
            {
                button2_0.Text = "X";
                matrix[2, 0] = 1;
            }
            else
            {
                button2_0.Text = "O";
                matrix[2, 0] = 2;
            }
            turnX = !turnX;
            checkWinner();
            button2_0.Enabled = false;
        }

        private void button2_1_Click(object sender, EventArgs e)
        {
            if (turnX)
            {
                button2_1.Text = "X";
                matrix[2, 1] = 1;
            }
            else
            {
                button2_1.Text = "O";
                matrix[2, 1] = 2;
            }
            turnX = !turnX;
            checkWinner();
            button2_1.Enabled = false;
        }

        private void button2_2_Click(object sender, EventArgs e)
        {
            if (turnX)
            {
                button2_2.Text = "X";
                matrix[2, 2] = 1;
            }
            else
            {
                button2_2.Text = "O";
                matrix[2, 2] = 2;
            }
            turnX = !turnX;
            checkWinner();
            button2_2.Enabled = false;
        }

        private void checkWinner()
        {
            // Check rows
            if (matrix[0, 0] == matrix[0, 1] && matrix[0, 0] == matrix[0, 2])
            {
                if (matrix[0, 0] == 1)
                    label1.Text = "Player X is the winner";
                else if (matrix[0, 0] == 2)
                    label1.Text = "Player O is the winner";
            }
            else if (matrix[1, 0] == matrix[1, 1] && matrix[1, 0] == matrix[1, 2])
            {
                if (matrix[1, 0] == 1)
                    label1.Text = "Player X is the winner";
                else if (matrix[1, 0] == 2)
                    label1.Text = "Player O is the winner";
            }
            else if (matrix[2, 0] == matrix[2, 1] && matrix[2, 0] == matrix[2, 2])
            {
                if (matrix[2, 0] == 1)
                    label1.Text = "Player X is the winner";
                else if (matrix[2, 0] == 2)
                    label1.Text = "Player O is the winner";
            }
            // Check cols
            if (matrix[0, 0] == matrix[1, 0] && matrix[0, 0] == matrix[2, 0])
            {
                if (matrix[0, 0] == 1)
                    label1.Text = "Player X is the winner";
                else if (matrix[0, 0] == 2)
                    label1.Text = "Player O is the winner";
            }
            else if (matrix[0, 1] == matrix[1, 1] && matrix[0, 1] == matrix[2, 1])
            {
                if (matrix[0, 1] == 1)
                    label1.Text = "Player X is the winner";
                else if (matrix[0, 1] == 2)
                    label1.Text = "Player O is the winner";
            }
            else if (matrix[0, 2] == matrix[1, 2] && matrix[0, 2] == matrix[2, 2])
            {
                if (matrix[0, 2] == 1)
                    label1.Text = "Player X is the winner";
                else if (matrix[0, 2] == 1)
                    label1.Text = "Player O is the winner";
            }

            // Diagonal
            if (matrix[0, 0] == matrix[1, 1] && matrix[0, 0] == matrix[2, 2])
            {
                if (matrix[0, 0] == 1)
                    label1.Text = "Player X is the winner";
                else if (matrix[0, 0] == 1)
                    label1.Text = "Player O is the winner";
            }
            else if (matrix[0, 2] == matrix[1, 1] && matrix[0, 2] == matrix[2, 0])
            {
                if (matrix[0, 2] == 1)
                    label1.Text = "Player X is the winner";
                else if (matrix[0, 2] == 1)
                    label1.Text = "Player O is the winner";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    matrix[i, j] = 0;
        }
    }
}
