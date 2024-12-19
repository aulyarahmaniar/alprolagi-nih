namespace grup_alpro
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            user nama = new user();
            nama.Show();
            Visible = false;
            
        }
    }
}
