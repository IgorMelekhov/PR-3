
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_3
{
    public partial class Form1 : Form
    {
        static public T2 Sum<T1, T2>(T1 matrix,int columns,int lines)
        {
            T2 sum = default;
            bool negative = false;
            dynamic dmatrix = matrix;
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (negative == true) sum += Math.Abs((dmatrix[i, j]));
                    if (dmatrix[i, j] < 0) negative = true;
                }
            }
            return sum;
        }
    }
}