namespace SCOPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;

                label4.Text=progressBar1.Value.ToString() + "%";
            }
            if(progressBar1.Value >= 100)
            {
                timer1.Stop();
                Login a = new Login();
                a.Show();
                this.Hide();
            }
            
        }
    }
}
