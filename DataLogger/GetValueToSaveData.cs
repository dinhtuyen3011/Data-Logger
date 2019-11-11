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
    public partial class GetValueToSaveData : Form
    {
        
        public GetValueToSaveData()
        {
            InitializeComponent();
        }
        public string value { get; private set; }
        public double timeSave { get; private set; }

        private void days_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Mời nhập lại");
                e.Handled = true;
            }
        }

        private void hours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Mời nhập lại");
                e.Handled = true;
            }
        }

        private void minutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Mời nhập lại");
                e.Handled = true;
            }
        }

        private void seconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Mời nhập lại");
                e.Handled = true;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetValueToSaveData_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if((hours.Text != ""))
            {
                    int a = Convert.ToInt32(hours.Text);
                    if (a > 23)
                    {
                        hours.Text = "";
                        if (MessageBox.Show("", "Nhập lại giờ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            e.Cancel = true;
                        }
                        else
                            e.Cancel = false;
                    }
            }
            if ((minutes.Text != ""))
            {
                int b = Convert.ToInt32(minutes.Text);
                if (b > 59)
                {
                    minutes.Text = "";
                    if (MessageBox.Show("", "Nhập lại phút", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        e.Cancel = true;
                    }
                    else
                        e.Cancel = false;
                }
            }
            if ((seconds.Text != ""))
            {
                int b = Convert.ToInt32(seconds.Text);
                if (b > 59)
                {
                    seconds.Text = "";
                    if (MessageBox.Show("", "Nhập lại giây", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        e.Cancel = true;
                    }
                    else
                        e.Cancel = false;
                }
            }
            if ((days.Text == "") && (hours.Text == "") && (minutes.Text == "") && (seconds.Text == ""))
            {
                if (MessageBox.Show("Bạn chưa điền giá trị", "Tiếp tục", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }
        private void GetValueToSaveData_FormClosed(object sender, FormClosedEventArgs e)
        {
            int ds = 0;
            int hs = 0;
            int ms = 0;
            int s = 0;
            if ((days.Text == "")|| (days.Text == "0"))
            {
                days.Text = "";
                
            }
            else
            {
                ds = int.Parse(days.Text);
                days.Text = days.Text + "d";
                
            }
            if ((hours.Text == "")|| (hours.Text == "0"))
            {
                hours.Text = "";
            }
            else
            {
                hs = int.Parse(hours.Text);
                hours.Text = hours.Text + "h";
                
            }
            if ((minutes.Text == "")|| minutes.Text == "0")
            {
                minutes.Text = "";
            }
            else
            {
                ms = int.Parse(minutes.Text);
                minutes.Text = minutes.Text + "m";
                
            }
            if ((seconds.Text == "")|| (seconds.Text == "0"))
            {
                seconds.Text = "";
            }
            else
            {
                s = int.Parse(seconds.Text);
                seconds.Text = seconds.Text + "s";
                
            }
            value = days.Text + hours.Text + minutes.Text + seconds.Text ;
            timeSave = ds * 86400 + hs * 3600 + ms * 60 + s;
        }
    }
}
