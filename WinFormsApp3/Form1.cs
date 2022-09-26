namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (true)
            {
              if(MessageBox.Show("Có giòn không","Thông báo",MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    break;
                }
            }
        }

        public static void Login()
        {
            HttpClient client = new HttpClient();
            
        }
    }
}