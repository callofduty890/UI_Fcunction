using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 界面窗体UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //进度条
        private void timer1_Tick(object sender, EventArgs e)
        {
            //令每一次进度条的宽增加5;
            this.panel2.Width += 5;
            //判断当前的宽是否达到了背景的宽度
            if (this.panel2.Width>=this.panel1.Width)
            {
                this.timer1.Stop();
            }

        }

        //叠加计次
        int count = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            //在标签文本上追加
            this.label3.Text += ".";
            //累加
            count++;
            //判断如何有四个 .  那么恢复原来的内容：加载系统组件
            if (count==4)
            {
                this.label3.Text = "加载系统组件";
                count = 0; //清空重新开始
            }
        }
    }
}
