namespace MeloduetBootstrap.Launcher.Windows
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnSet = new System.Windows.Forms.PictureBox();
            this.lbVer = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.setPanel = new System.Windows.Forms.Panel();
            this.txtMaxRem = new System.Windows.Forms.TextBox();
            this.txtJava = new System.Windows.Forms.TextBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSet)).BeginInit();
            this.setPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "\r\n地址:\r\n延迟:\r\n人数:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meloduet Server";
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnStart.Location = new System.Drawing.Point(480, 18);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnStart.Size = new System.Drawing.Size(120, 35);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "开始游戏!";
            this.toolTip1.SetToolTip(this.btnStart, "开始进行游戏");
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.ColorTransformE);
            this.btnStart.MouseLeave += new System.EventHandler(this.ColorTransformL);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnExit.Image = global::MeloduetBootstrap.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(568, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.toolTip1.SetToolTip(this.btnExit, "退出启动器");
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.ColorTransformE);
            this.btnExit.MouseLeave += new System.EventHandler(this.ColorTransformL);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSet.Image = global::MeloduetBootstrap.Properties.Resources.set_b;
            this.btnSet.Location = new System.Drawing.Point(17, 312);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(32, 32);
            this.btnSet.TabIndex = 5;
            this.btnSet.TabStop = false;
            this.toolTip1.SetToolTip(this.btnSet, "设置");
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            this.btnSet.MouseEnter += new System.EventHandler(this.ColorTransformE);
            this.btnSet.MouseLeave += new System.EventHandler(this.ColorTransformL);
            // 
            // lbVer
            // 
            this.lbVer.AutoSize = true;
            this.lbVer.BackColor = System.Drawing.Color.Transparent;
            this.lbVer.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbVer.Location = new System.Drawing.Point(274, 24);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(74, 20);
            this.lbVer.TabIndex = 6;
            this.lbVer.Text = "扫描版本...";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.ReshowDelay = 10;
            // 
            // setPanel
            // 
            this.setPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.setPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setPanel.Controls.Add(this.txtMaxRem);
            this.setPanel.Controls.Add(this.txtJava);
            this.setPanel.Controls.Add(this.txtNick);
            this.setPanel.Controls.Add(this.label3);
            this.setPanel.Location = new System.Drawing.Point(55, 278);
            this.setPanel.Name = "setPanel";
            this.setPanel.Size = new System.Drawing.Size(340, 66);
            this.setPanel.TabIndex = 7;
            this.setPanel.Visible = false;
            // 
            // txtMaxRem
            // 
            this.txtMaxRem.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtMaxRem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaxRem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMaxRem.ForeColor = System.Drawing.Color.White;
            this.txtMaxRem.Location = new System.Drawing.Point(74, 44);
            this.txtMaxRem.Name = "txtMaxRem";
            this.txtMaxRem.Size = new System.Drawing.Size(263, 16);
            this.txtMaxRem.TabIndex = 4;
            this.txtMaxRem.Text = "1024";
            this.toolTip1.SetToolTip(this.txtMaxRem, "最大内存大小, 单位MiB, 默认为1024");
            this.txtMaxRem.TextChanged += new System.EventHandler(this.txtMaxRem_TextChanged);
            // 
            // txtJava
            // 
            this.txtJava.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtJava.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJava.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJava.ForeColor = System.Drawing.Color.White;
            this.txtJava.Location = new System.Drawing.Point(74, 24);
            this.txtJava.Name = "txtJava";
            this.txtJava.Size = new System.Drawing.Size(263, 16);
            this.txtJava.TabIndex = 3;
            this.txtJava.Text = "Java";
            this.toolTip1.SetToolTip(this.txtJava, "Java路径, 必须是Javaw.exe所在路径");
            this.txtJava.TextChanged += new System.EventHandler(this.txtJava_TextChanged);
            // 
            // txtNick
            // 
            this.txtNick.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtNick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNick.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNick.ForeColor = System.Drawing.Color.White;
            this.txtNick.Location = new System.Drawing.Point(74, 4);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(263, 16);
            this.txtNick.TabIndex = 2;
            this.txtNick.Text = "在这里输入昵称";
            this.toolTip1.SetToolTip(this.txtNick, "昵称应当是英文, 可以使用数字和下划线, 不可以有中文字符");
            this.txtNick.TextChanged += new System.EventHandler(this.txtNick_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 80);
            this.label3.TabIndex = 1;
            this.label3.Text = "昵称\r\nJava\r\n最大内存\r\n\r\n";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTime.ForeColor = System.Drawing.Color.Red;
            this.lbTime.Location = new System.Drawing.Point(274, 159);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 20);
            this.lbTime.TabIndex = 8;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MeloduetBootstrap.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(612, 356);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.setPanel);
            this.Controls.Add(this.lbVer);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Meloduet Server 服务器启动器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSet)).EndInit();
            this.setPanel.ResumeLayout(false);
            this.setPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnStart;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnSet;
        private System.Windows.Forms.Label lbVer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel setPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxRem;
        private System.Windows.Forms.TextBox txtJava;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTime;
    }
}