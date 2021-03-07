using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace UpperStartup
{
    public partial class UpperComputer : Form
    {
        public UpperComputer()
        {
            InitializeComponent();
        }

        private void 串口连接_Click(object sender, EventArgs e)
        {
            if(!串口.IsOpen)
            {
                串口.Open();
                串口连接.Text = "串口已连接";
            }
            else
            {
                串口.Close();
                串口连接.Text = "串口未连接";
            }
        }

        private void 输出_Click(object sender, EventArgs e)
        {
            if (转向.Text == "正")
            {
                串口.Write("T" + "P" + "V" + 电压输出.Text + "/r/n");
            }
            else if (转向.Text == "反")
            {
                串口.Write("T" + "R" + "V" + 电压输出.Text + "/r/n");
            }
        }

        private void 获取_Click(object sender, EventArgs e)
        {
            串口.Write("上位机请求获取信息");
            //多线程停止后进行下一步
            System.Threading.Thread.Sleep(20);

            //获得并解读
            byte[] buffer = new byte[串口.BytesToRead];
            var 总字符串 = 串口.Read(buffer, 0, buffer.Length).ToString();

            //数据归位
            电流显示.Text = Service.截取字符串(总字符串, "I", "V");
            电压显示.Text = Service.截取字符串(总字符串, "V", "F");
            力显示.Text = Service.截取字符串(总字符串, "F", "X");
            位移显示.Text = Service.截取字符串(总字符串, "X", "/r/n");
        }

        private void 清空_Click(object sender, EventArgs e)
        {
            电压输出.Text = "";
        }

        private void 转向_Click(object sender, EventArgs e)
        {
            if(转向.Text == "正")
            {
                转向.Text = "反";
            }
            else if(转向.Text == "反")
            {
                转向.Text = "正";
            }
        }
    }
}
