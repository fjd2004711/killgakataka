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
            p.StartInfo.FileName = "CMD.exe";//Ҫ������Ӧ�ó���
            p.StartInfo.UseShellExecute = false;//��ʹ�ò���ϵͳshell����
            p.StartInfo.RedirectStandardInput = true; //�������Ե��ó����������Ϣ
            p.StartInfo.RedirectStandardOutput = true;//���������Ϣ
            p.StartInfo.RedirectStandardError = true;//�����������
            p.StartInfo.CreateNoWindow = true;//����ʾ���򴰿�
            p.Start();//��������
            p.StandardInput.WriteLine("taskkill /im student.exe -t -f");//��CMD���ڷ�����������
            p.StandardInput.AutoFlush = true;//�Զ�ˢ��

            MessageBox.Show("�ر���ɣ������±���������ע����ťע���˻������µ�½���ٵ���رտ��ơ�", "�ر���ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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