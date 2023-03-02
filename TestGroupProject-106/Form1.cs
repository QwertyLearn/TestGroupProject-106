namespace TestGroupProject_106
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bulatov b = new Bulatov();

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = b.Count.ToString();
            b.Step();
        }
    }
}