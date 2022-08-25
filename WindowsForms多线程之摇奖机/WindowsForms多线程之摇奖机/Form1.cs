using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms多线程之摇奖机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool key = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (key == false)
            {
                key = true;
                button1.Text = "停止";
                Thread th = new Thread(PlayGame);
                th.IsBackground = true;
                th.Start();
            }
            else
            {
                button1.Text = "开始";
                key = false;
                
            }
        }
        public void PlayGame()
        {
            Random r = new Random();
            while (key)
            {
                label1.Text = r.Next(0, 10).ToString();
                label2.Text = r.Next(0, 10).ToString();
                label3.Text = r.Next(0, 10).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
