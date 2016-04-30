using MeloduetBootstrap.KMCCC.Authentication;
using MeloduetBootstrap.KMCCC.Launcher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MeloduetBootstrap.Launcher.Windows
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        public static LauncherCore Core = LauncherCore.Create();

        KMCCC.Launcher.Version[] vers = new KMCCC.Launcher.Version[1];
        private void MainWindow_Load(object sender, EventArgs e)
        {
            vers = Core.GetVersions().ToArray();
            if (vers.Length == 0)
            {
                MessageBox.Show("游戏损坏!", "警告");
                Application.Exit();
            }
            lbVer.Text = vers.Last().Id;
            //如果设置文件存在
            string inifile = Application.StartupPath + @"\.minecraft\set.ini";
            if (System.IO.File.Exists(inifile))
            {
                Config.Java = Util.ConfigOpt.INIGetStringValue(inifile, "Setting", "Java", KMCCC.Tools.SystemTools.FindJava().Last());
                string strRAM = Util.ConfigOpt.INIGetStringValue(inifile, "Setting", "RAM", "1024");
                Config.maxRAM = int.Parse(strRAM);
                Config.nick = Util.ConfigOpt.INIGetStringValue(inifile, "Setting", "NickName", "");
            }
            else
            {
                string java;
                try
                {
                    java = KMCCC.Tools.SystemTools.FindJava().Last();
                }
                catch (Exception)
                {

                    MessageBox.Show("找不到Javaw.exe, 请手动输入");
                    java = MSPDT.Windows.InputForm.Show("提示", "请输入java路径(javaw.exe完整路径)");
                    if (!System.IO.File.Exists(java))
                    {
                        MessageBox.Show("文件不存在!");
                        Application.Exit();
                    }
                    else
                    {
                        if (!(java.EndsWith("javaw.exe"))) {
                            MessageBox.Show("文件不存在!");
                            Application.Exit();
                        }
                    }
                }
                Config.Java = java;
                string nick = MSPDT.Windows.InputForm.Show("提示", "请输入玩家昵称(英文, 字母, 下划线混合)");
                Config.nick = nick;
                Config.maxRAM = 1024;

                Save(inifile);


            }
            txtJava.Text = Config.Java;
            txtMaxRem.Text = Config.maxRAM.ToString();
            txtNick.Text = Config.nick;


        }

        private static void Save(string inifile)
        {
            Util.ConfigOpt.INIWriteValue(inifile, "Setting", "Java", Config.Java);
            Util.ConfigOpt.INIWriteValue(inifile, "Setting", "RAM", Config.maxRAM.ToString());
            Util.ConfigOpt.INIWriteValue(inifile, "Setting", "NickName", Config.nick);
        }
        private static bool Check()
        {
            if (!(System.IO.File.Exists(Config.Java)))
            {
                MessageBox.Show("你的Java路径不对!");
                Config.Java = KMCCC.Tools.SystemTools.FindJava().Last();

                return false;
            }
            return true;

        }
        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void ColorTransformE(object sender, EventArgs e)
        {
            Label l; PictureBox p;
            if (sender is Label)
            {
                l = (Label)sender;
                Color c = Color.FromArgb(l.BackColor.R + 20, l.BackColor.G + 10, l.BackColor.B + 20);
                l.BackColor = c;
            }
            else if (sender is PictureBox)
            {
                p = (PictureBox)sender;
                Color c = Color.FromArgb(p.BackColor.R + 20, p.BackColor.G + 10, p.BackColor.B + 20);
                p.BackColor = c;
            }
        }

        private void ColorTransformL(object sender, EventArgs e)
        {
            Label l; PictureBox p;
            if (sender is Label)
            {
                l = (Label)sender;
                Color c = Color.FromArgb(l.BackColor.R - 20, l.BackColor.G - 10, l.BackColor.B - 20);
                l.BackColor = c;
            }
            else if (sender is PictureBox)
            {
                p = (PictureBox)sender;
                Color c = Color.FromArgb(p.BackColor.R - 20, p.BackColor.G - 10, p.BackColor.B - 20);
                p.BackColor = c;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var ver = vers.Last();
            Check();
            Core.JavaPath = Config.Java;
            var result = Core.Launch(new LaunchOptions
            {
                Version = ver, //Ver为Versions里你要启动的版本名字
                MaxMemory = Config.maxRAM, //最大内存，int类型
                Authenticator = new OfflineAuthenticator(Config.nick), //离线启动，ZhaiSoul那儿为你要设置的游戏名
                                                                       //Authenticator = new YggdrasilLogin("邮箱", "密码", true), // 正版启动，最后一个为是否twitch登录
                Mode = LaunchMode.BmclMode, //启动模式，这个我会在后面解释有哪几种
                                              // Server = new ServerInfo { Address = "119.10.47.168", Port = 25565 }, //设置启动游戏后，自动加入指定IP的服务器，可以不要
                                              //Size = new WindowSize { Height = 768, Width = 1280 } //设置窗口大小，可以不要                

            });
            if (result == null)
            {
                MessageBox.Show("启动出错!");
            }

            timer1.Enabled = true;

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            setPanel.Visible = !setPanel.Visible;
        }

        private void txtNick_TextChanged(object sender, EventArgs e)
        {

            Config.nick = txtNick.Text;
        }

        private void txtJava_TextChanged(object sender, EventArgs e)
        {
            Config.Java = txtJava.Text;

        }

        private void txtMaxRem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Config.maxRAM = int.Parse(txtMaxRem.Text);
            }
            catch (Exception)
            {

                txtMaxRem.Text = "1024";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = (5 - Config.time).ToString() + "...";
            if (Config.time == 5)
            {
                Application.Exit();
            }
            else { Config.time++; }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Save(Application.StartupPath + @"\.minecraft\set.ini");
            }
            catch {
                Application.Exit();
            }
        }
    }
}
