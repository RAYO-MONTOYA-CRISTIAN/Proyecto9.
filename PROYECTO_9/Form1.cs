namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int numero1, numero2, numero3;
                numero1 = Convert.ToInt32(textNum1.Text);
                numero2 = Convert.ToInt32(textNum2.Text);
                numero3 = Convert.ToInt32(textNum3.Text);
                if (numero1 > numero2 & numero1 > numero3)
                {
                    lblRes.Text = "El número mayor es: " + numero1;
                }
                else if (numero2 > numero1 & numero2 > numero3)
                {
                    lblRes.Text = "El número mayor es: " + numero2;
                }
                else
                {
                    lblRes.Text = "El número mayor es: " + numero3;
                }

            }
        }
    }
}