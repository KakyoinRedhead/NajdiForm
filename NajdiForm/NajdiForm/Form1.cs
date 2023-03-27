namespace NajdiForm
{
    public partial class Form1 : Form
    {
        FormWin form2 = new FormWin();
        FormSchova form = new FormSchova();
        public Form1()
        {
            InitializeComponent();
            StartSingelton.Instance.OnWon += Show;
        }
        static Rectangle Bounds = Screen.PrimaryScreen.Bounds;
        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int numForms = r.Next(20, 50);

            form2.StartPosition = FormStartPosition.Manual;
            StartSingelton.Instance.OnWon += form2.Close;
            form2.Location = new Point(r.Next(0, Bounds.Width - form2.Width), r.Next(0, Bounds.Height - form2.Height));
            form2.Show();

            for (int i = 0; i < numForms; i++)
            {
                FormSchova form = new();
                StartSingelton.Instance.OnWon += form.Close;
                StartSingelton.Instance.OnLose += Breake;
                form.StartPosition = FormStartPosition.Manual;
                form.Location = new Point(r.Next(0, Bounds.Width - form.Width), r.Next(0, Bounds.Height - form.Height));
                form.Show();
            }
            Hide();

          
        }

        public void Breake()
        {
            while (true)
            {
                form.Show();
                form2.Show();
                

            }
        }
    }
}