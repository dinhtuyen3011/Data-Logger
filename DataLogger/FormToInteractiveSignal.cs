using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLogger
{
    public partial class FormToInteractiveSignal : Form
    {
        public FormToInteractiveSignal()
        {
            InitializeComponent();
        }
        public string funct { get; set; }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormToInteractiveSignal_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < function.Text.Count(); i = i + 3)
            {
                if (function.Text[i] != 'S')
                {
                    MessageBox.Show("Moi nhap lai");
                    e.Cancel = true;
                }
            }
            for (int i = 1; i < function.Text.Count(); i = i + 3)
            {
                if (!Char.IsNumber(function.Text[i]))
                {
                    //string s = function.Text[i];
                    MessageBox.Show("Moi nhap chi so kenh ");
                    e.Cancel = true;
                }
                int s = (int)char.GetNumericValue(function.Text[i]);
                if (s > 4)
                {
                    MessageBox.Show("Moi nhap lai chi so kenh");
                    e.Cancel = true;
                }
            }
            for (int i = 2; i < function.Text.Count(); i = i + 3)
            {
                if (((function.Text[i]) != '+') && (function.Text[i] != '-') && (function.Text[i] != '*') && (function.Text[i] != '/'))
                {
                    MessageBox.Show("Moi nhap lai dau");
                    e.Cancel = true;
                }
            }
        }

        private void FormToInteractiveSignal_FormClosed(object sender, FormClosedEventArgs e)
        {
            funct = function.Text;
        }
    }
}
