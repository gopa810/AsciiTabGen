using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AsciiTabGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StringBuilder sb = new StringBuilder();

            for (int i = 128; i < 256; i+=16)
            {
                for (int j = 0; j < 16; j++)
                {
                    sb.AppendFormat("{0}: {1}  ", i + j, Convert.ToChar(i + j));
                }
                sb.AppendLine();
            }

            richTextBox1.Text = sb.ToString();
        }
    }
}
