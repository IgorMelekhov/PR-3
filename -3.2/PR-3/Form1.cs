
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PR_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            columns.Validating += columns_Validating;
            lines.Validating += lines_Validating;
        }
        private void columns_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(columns.Text)) errorProvider1.SetError(columns, "Поле не может быть пустым!");
            else if (!uint.TryParse(columns.Text, out _)) errorProvider1.SetError(columns, "В поле должно быть введено целое положительное число!");
            else if (Convert.ToInt32(columns.Text) > 5) errorProvider1.SetError(columns, "Число столбцов не должно быть больше пяти");
            else
            { errorProvider1.Clear(); }
        }
        private void lines_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(lines.Text)) errorProvider2.SetError(lines, "Поле не может быть пустым!");
            else if (!uint.TryParse(lines.Text, out _)) errorProvider2.SetError(lines, "В поле должно быть введено целое положительное число!");
            else if (Convert.ToInt32(lines.Text) > 5) errorProvider2.SetError(lines, "Число строк не должно быть больше пяти");
            else
            { errorProvider2.Clear(); }
        }
        private void CreateAMatrixWithIntegers_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxMatrix.Controls.Clear();
                int count = 0;
                int columns2 = Convert.ToInt32(columns.Text);
                int lines2 = Convert.ToInt32(lines.Text);
                if ((columns2 > 5) || (lines2 > 5))
                {
                    MessageBox.Show("Число столбцов или строк не должно быть больше пяти", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    columns.Clear();
                    lines.Clear();
                }
                else
                {
                    int[,] matrix = new int[lines2, columns2];
                    Random random = new Random();
                    for (int i = 0; i < lines2; i++)
                    {
                        for (int j = 0; j < columns2; j++)
                        {
                            count++;
                            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                            textBox.Name = $"textBox{count}";
                            textBox.Location = new System.Drawing.Point(123 + j * 30, 40 + i * 20);
                            textBox.Size = new System.Drawing.Size(30, 30);
                            textBox.TabIndex = count;
                            textBox.ReadOnly = true;
                            int number = random.Next(-9, 9);
                            matrix[i, j] = number;
                            textBox.Text = number.ToString();
                            groupBoxMatrix.Controls.Add(textBox);

                        }
                    }
                    Summ.Text = (Sum<int[,], int>(matrix, columns2, lines2)).ToString();
                }

            }
            catch { }

        }

        private void CreateAMatrixWithDoubles_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxMatrix.Controls.Clear();
                int columns2 = Convert.ToInt32(columns.Text);
                int lines2 = Convert.ToInt32(lines.Text);
                if ((columns2 > 5) || (lines2 > 5))
                {
                    MessageBox.Show("Число столбцов или строк не должно быть больше пяти", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    columns.Clear();
                    lines.Clear();
                }
                else
                {
                    int count = 0;
                    double[,] matrix = new double[3, 3];
                    Random random = new Random();
                    for (int i = 0; i < lines2; i++)
                    {
                        for (int j = 0; j < columns2; j++)
                        {
                            count++;
                            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                            textBox.Name = $"textBox{count}";
                            textBox.Location = new System.Drawing.Point(123 + j * 30, 40 + i * 20);
                            textBox.Size = new System.Drawing.Size(30, 30);
                            textBox.TabIndex = count;
                            double number = random.NextDouble() * (9 - (-9)) + (-9);
                            matrix[i, j] = Math.Round(number, 1);
                            textBox.Text = Math.Round(number, 1).ToString();
                            groupBoxMatrix.Controls.Add(textBox);

                        }
                    }
                    Summ.Text = (Sum<double[,], double>(matrix, columns2, lines2)).ToString();
                }


            }
            catch { }
        }
        private void button3Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cleanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxMatrix.Controls.Clear();
            lines.Clear();
            columns.Clear();
            Summ.Clear();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

