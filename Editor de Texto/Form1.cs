using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_Texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader archivos = new System.IO.StreamReader(openFileDialog1.FileName);
            r = archivos.ReadLine();
            richTextBox1.Text = r.ToString();
        
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "Sin Titulo.txt";
            var guardar = saveFileDialog1.ShowDialog();
            if (guardar == DialogResult.OK)
            {
                using (var guardar_archivos = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    guardar_archivos.WriteLine(richTextBox1); 
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void seleccionartodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();

        }

        private void elimarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var c = colorDialog1.ShowDialog();
            if (c == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = fontDialog1.ShowDialog();
            if(frm == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void colorDeFonfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clf = colorDialog1.ShowDialog();
            if (clf == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }
    }
}
