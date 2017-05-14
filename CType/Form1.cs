using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb.Text = "16-10";
            cb.SelectedIndex = 0;
            cb.Text = "16-8";
            cb.SelectedIndex = 1;
            cb.Text = "16-2";
            cb.SelectedIndex = 2;

            cb.Text = "10-16";
            cb.SelectedIndex = 3;
            cb.Text = "10-8";
            cb.SelectedIndex = 4;
            cb.Text = "10-2";
            cb.SelectedIndex = 5;

            cb.Text = "8-16";
            cb.SelectedIndex = 6;
            cb.Text = "8-10";
            cb.SelectedIndex = 7;
            cb.Text = "8-2";
            cb.SelectedIndex = 8;

            cb.Text = "2-16";
            cb.SelectedIndex = 9;
            cb.Text = "2-10";
            cb.SelectedIndex = 10;
            cb.Text = "2-8";
            cb.SelectedIndex = 11;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string text = textb.Text;
            if (text.Equals(""))
            {
                MessageBox.Show("请输入参数");
                goto cc;
            }
            
            try {
                switch (cb.SelectedIndex)
                {
                    case 0:
                        result.Text = Convert.ToInt32(text, 16) + "";
                        break;
                    case 1:
                        result.Text= Convert.ToString(Convert.ToInt32(text, 16), 8);
                        break;
                    case 2:
                        result.Text = Convert.ToString(Convert.ToInt32(text, 16), 2);
                        break;
                    case 3:
                        result.Text = Convert.ToString(int.Parse(text), 16);
                        break;
                    case 4:
                        result.Text = Convert.ToString(int.Parse(text), 8);
                        break;
                    case 5:
                        result.Text = Convert.ToString(int.Parse(text), 2);
                        break;
                    case 6:                    
                        result.Text = Convert.ToString(Convert.ToInt32(text, 8), 16);
                        break;
                    case 7:
                        result.Text= Convert.ToInt32(text, 8)+"";
                        break;
                    case 8:
                        result.Text = Convert.ToString(Convert.ToInt32(text, 8),2);
                        break;
                    case 9:
                        result.Text = Convert.ToString(Convert.ToInt32(text, 2), 16);
                        break;
                    case 10:
                        result.Text = Convert.ToInt32(text, 2)+"";
                        break;
                    case 11:
                        result.Text = Convert.ToString(Convert.ToInt32(text, 2), 8);
                        break;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                MessageBox.Show("转换出错");
            }


             cc:;

        }
    }
}
