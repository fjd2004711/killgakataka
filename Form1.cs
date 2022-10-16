namespace gakataka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "CMD.exe";//要启动的应用程序
            p.StartInfo.UseShellExecute = false;//不使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true; //接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;//允许输出信息
            p.StartInfo.RedirectStandardError = true;//允许输出错误
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口
            p.Start();//启动程序
            p.StandardInput.WriteLine("taskkill /im student.exe -t -f");//向CMD窗口发送输入命令
            p.StandardInput.AutoFlush = true;//自动刷新

            MessageBox.Show("关闭完成！若重新被控制请点击注销按钮注销账户，重新登陆后再点击关闭控制。", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://biuioi.com//archives//35");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://biuioi.com");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com//fjd2004711//killgakataka");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            System.Diagnostics.Process.Start("explorer.exe", "https://biuioi.com//archives//35");
        }
    }
    }