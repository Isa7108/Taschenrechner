namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                float zahl1 = float.Parse(textBox1.Text);
                float zahl2 = float.Parse(textBox2.Text);

                float result = zahl1 + zahl2;

                textBox3.Text = result.ToString();
            }
            catch
            {

                MessageBox.Show("ungültiger wert");

            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                float zahl1 = float.Parse(textBox1.Text);
                float zahl2 = float.Parse(textBox2.Text);

                float result = zahl1 - zahl2;

                textBox3.Text = result.ToString();
            }
            catch
            {

                MessageBox.Show("ungültiger wert");

            }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                float zahl1 = float.Parse(textBox1.Text);
                float zahl2 = float.Parse(textBox2.Text);

                float result = zahl1 * zahl2;

                textBox3.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("ungültiger wert");
            }
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                float zahl1 = float.Parse(textBox1.Text);
                float zahl2 = float.Parse(textBox2.Text);

                float result = zahl1 / zahl2;

                textBox3.Text = result.ToString();
            }
            catch
            {


                MessageBox.Show("ungültiger wert");
            }
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                float zahl1 = float.Parse(textBox1.Text);
                float zahl2 = float.Parse(textBox2.Text);

                float result = zahl2 / zahl1 * 100;

                textBox3.Text = result.ToString() + "%";
            }
            catch
            {
                MessageBox.Show("ungültiger wert");
            }
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                ulong num = ulong.Parse(textBox1.Text);
                ulong result = Fakultaet(num);
                textBox3.Text = result.ToString();
            }
            catch
            {

                MessageBox.Show("ungültiger wert");
            }
        }

        public static ulong Fakultaet(ulong num)
        {

            ulong result = 1;
            for (ulong i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;

        }

        private void Button7_Click_1(object sender, EventArgs e)
        {

            while (true)
            {
                MessageBox.Show("ungültiger wert");


            }

        }

      
    }
}