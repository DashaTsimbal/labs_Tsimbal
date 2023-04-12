using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();

            if (string.IsNullOrEmpty(textBox1.Text))
                richTextBox1.AppendText("Елемент 1: Порожньо\n");
            else
                richTextBox1.AppendText("Елемент 1: " + textBox1.Text + '\n');

            if (string.IsNullOrEmpty(textBox2.Text))
                richTextBox1.AppendText("Елемент 2: Порожньо\n");
            else
                richTextBox1.AppendText("Елемент 2: " + textBox2.Text + '\n');

            if (string.IsNullOrEmpty(textBox3.Text))
                richTextBox1.AppendText("Елемент 3: Порожньо\n");
            else
                richTextBox1.AppendText("Елемент 3: " + textBox3.Text + '\n');

            if (string.IsNullOrEmpty(textBox4.Text))
                richTextBox1.AppendText("Елемент 4: Порожньо\n");
            else
                richTextBox1.AppendText("Елемент 4: " + textBox4.Text + '\n');

            if (string.IsNullOrEmpty(textBox5.Text))
                richTextBox1.AppendText("Елемент 5: Порожньо\n");
            else
                richTextBox1.AppendText("Елемент 5: " + textBox5.Text + '\n');
        }
    }
}
