namespace AgriTrack
{
    public partial class Dashboard : Form
    {
        public Dashboard(string role)
        {
            InitializeComponent();
            this.Text="AgriTrack - Logged in as: "+role;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseHelper.TestConnection();
        }
    }
}
