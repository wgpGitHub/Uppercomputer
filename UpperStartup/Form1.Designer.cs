
namespace UpperStartup
{
    partial class UpperComputer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Li = new System.Windows.Forms.Label();
            this.力显示 = new System.Windows.Forms.Label();
            this.DianLiu = new System.Windows.Forms.Label();
            this.电流显示 = new System.Windows.Forms.Label();
            this.DianYa = new System.Windows.Forms.Label();
            this.电压显示 = new System.Windows.Forms.Label();
            this.串口 = new System.IO.Ports.SerialPort(this.components);
            this.获取 = new System.Windows.Forms.Button();
            this.输出 = new System.Windows.Forms.Button();
            this.清空 = new System.Windows.Forms.Button();
            this.串口连接 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.电压输出 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.位移显示 = new System.Windows.Forms.Label();
            this.转向 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Li
            // 
            this.Li.AutoSize = true;
            this.Li.Location = new System.Drawing.Point(113, 125);
            this.Li.Name = "Li";
            this.Li.Size = new System.Drawing.Size(22, 15);
            this.Li.TabIndex = 0;
            this.Li.Text = "力";
            // 
            // 力显示
            // 
            this.力显示.AutoSize = true;
            this.力显示.Location = new System.Drawing.Point(156, 125);
            this.力显示.Name = "力显示";
            this.力显示.Size = new System.Drawing.Size(15, 15);
            this.力显示.TabIndex = 1;
            this.力显示.Text = "0";
            // 
            // DianLiu
            // 
            this.DianLiu.AutoSize = true;
            this.DianLiu.Location = new System.Drawing.Point(113, 48);
            this.DianLiu.Name = "DianLiu";
            this.DianLiu.Size = new System.Drawing.Size(37, 15);
            this.DianLiu.TabIndex = 2;
            this.DianLiu.Text = "电流";
            // 
            // 电流显示
            // 
            this.电流显示.AutoSize = true;
            this.电流显示.Location = new System.Drawing.Point(156, 48);
            this.电流显示.Name = "电流显示";
            this.电流显示.Size = new System.Drawing.Size(15, 15);
            this.电流显示.TabIndex = 3;
            this.电流显示.Text = "0";
            // 
            // DianYa
            // 
            this.DianYa.AutoSize = true;
            this.DianYa.Location = new System.Drawing.Point(300, 48);
            this.DianYa.Name = "DianYa";
            this.DianYa.Size = new System.Drawing.Size(37, 15);
            this.DianYa.TabIndex = 4;
            this.DianYa.Text = "电压";
            // 
            // 电压显示
            // 
            this.电压显示.AutoSize = true;
            this.电压显示.Location = new System.Drawing.Point(343, 48);
            this.电压显示.Name = "电压显示";
            this.电压显示.Size = new System.Drawing.Size(15, 15);
            this.电压显示.TabIndex = 5;
            this.电压显示.Text = "0";
            // 
            // 串口
            // 
            this.串口.BaudRate = 115200;
            this.串口.PortName = "COM3";
            // 
            // 获取
            // 
            this.获取.Location = new System.Drawing.Point(116, 270);
            this.获取.Name = "获取";
            this.获取.Size = new System.Drawing.Size(75, 31);
            this.获取.TabIndex = 6;
            this.获取.Text = "获取";
            this.获取.UseVisualStyleBackColor = true;
            this.获取.Click += new System.EventHandler(this.获取_Click);
            // 
            // 输出
            // 
            this.输出.Location = new System.Drawing.Point(198, 269);
            this.输出.Name = "输出";
            this.输出.Size = new System.Drawing.Size(75, 32);
            this.输出.TabIndex = 7;
            this.输出.Text = "输出";
            this.输出.UseVisualStyleBackColor = true;
            this.输出.Click += new System.EventHandler(this.输出_Click);
            // 
            // 清空
            // 
            this.清空.Location = new System.Drawing.Point(280, 269);
            this.清空.Name = "清空";
            this.清空.Size = new System.Drawing.Size(75, 32);
            this.清空.TabIndex = 8;
            this.清空.Text = "清空";
            this.清空.UseVisualStyleBackColor = true;
            this.清空.Click += new System.EventHandler(this.清空_Click);
            // 
            // 串口连接
            // 
            this.串口连接.Location = new System.Drawing.Point(362, 269);
            this.串口连接.Name = "串口连接";
            this.串口连接.Size = new System.Drawing.Size(106, 32);
            this.串口连接.TabIndex = 9;
            this.串口连接.Text = "串口未连接";
            this.串口连接.UseVisualStyleBackColor = true;
            this.串口连接.Click += new System.EventHandler(this.串口连接_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "转向";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "电压";
            // 
            // 电压输出
            // 
            this.电压输出.Location = new System.Drawing.Point(337, 225);
            this.电压输出.Name = "电压输出";
            this.电压输出.Size = new System.Drawing.Size(100, 25);
            this.电压输出.TabIndex = 15;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(300, 125);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(37, 15);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "位移";
            // 
            // 位移显示
            // 
            this.位移显示.AutoSize = true;
            this.位移显示.Location = new System.Drawing.Point(344, 125);
            this.位移显示.Name = "位移显示";
            this.位移显示.Size = new System.Drawing.Size(15, 15);
            this.位移显示.TabIndex = 17;
            this.位移显示.Text = "0";
            // 
            // 转向
            // 
            this.转向.Location = new System.Drawing.Point(149, 225);
            this.转向.Name = "转向";
            this.转向.Size = new System.Drawing.Size(42, 23);
            this.转向.TabIndex = 18;
            this.转向.Text = "正";
            this.转向.UseVisualStyleBackColor = true;
            this.转向.Click += new System.EventHandler(this.转向_Click);
            // 
            // UpperComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.转向);
            this.Controls.Add(this.位移显示);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.电压输出);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.串口连接);
            this.Controls.Add(this.清空);
            this.Controls.Add(this.输出);
            this.Controls.Add(this.获取);
            this.Controls.Add(this.电压显示);
            this.Controls.Add(this.DianYa);
            this.Controls.Add(this.电流显示);
            this.Controls.Add(this.DianLiu);
            this.Controls.Add(this.力显示);
            this.Controls.Add(this.Li);
            this.Name = "UpperComputer";
            this.Text = "测试台上位机";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Li;
        private System.Windows.Forms.Label 力显示;
        private System.Windows.Forms.Label DianLiu;
        private System.Windows.Forms.Label 电流显示;
        private System.Windows.Forms.Label DianYa;
        private System.Windows.Forms.Label 电压显示;
        private System.IO.Ports.SerialPort 串口;
        private System.Windows.Forms.Button 获取;
        private System.Windows.Forms.Button 输出;
        private System.Windows.Forms.Button 清空;
        private System.Windows.Forms.Button 串口连接;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 电压输出;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label 位移显示;
        private System.Windows.Forms.Button 转向;
    }
}

