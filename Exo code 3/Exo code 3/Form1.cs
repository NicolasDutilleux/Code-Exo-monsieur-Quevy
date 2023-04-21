namespace Exo_code_3
{
    public partial class Form1 : Form
    {

        int touche;
        Color color;
        int red;
        int green;
        int blue;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void WhenScrollR(object sender, ScrollEventArgs e)
        {
            textBox1.TextChanged -= new EventHandler(Rouge_Change);
            textBox1.Text = (vScrollBar1.Value).ToString();
            textBox1.TextChanged += new EventHandler(Rouge_Change);
            red = vScrollBar1.Value;
            Color c = Color.FromArgb(255, red, green, blue);
            panel1.BackColor = c;
            long hexa = long.Parse(textBox1.Text);
            textBox4.Text = Convert.ToString(hexa, 16);
        }

        private void WhenScrollG(object sender, ScrollEventArgs e)
        {
            textBox2.TextChanged -= new EventHandler(Green_Change);
            textBox2.Text = (vScrollBar2.Value).ToString();
            textBox2.TextChanged += new EventHandler(Green_Change);
            green = vScrollBar2.Value;
            Color c = Color.FromArgb(255, red, green, blue);
            panel1.BackColor = c;
            long hexa = long.Parse(textBox2.Text);
            textBox5.Text = Convert.ToString(hexa, 16);
        }

        private void WhenScrollB(object sender, ScrollEventArgs e)
        {
            textBox3.TextChanged -= new EventHandler(Blue_Change);
            textBox3.Text = (vScrollBar3.Value).ToString();
            textBox3.TextChanged += new EventHandler(Blue_Change);
            blue = vScrollBar3.Value;
            Color c = Color.FromArgb(255, red, green, blue);
            panel1.BackColor = c;
            long hexa = long.Parse(textBox3.Text);
            textBox6.Text = Convert.ToString(hexa, 16);
        }

        private void Rouge_Change(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if (int.Parse(textBox1.Text)>255)
            { 
                textBox1.Text = "255";
            }

            vScrollBar1.Value = int.Parse(textBox1.Text);
            red = int.Parse(textBox1.Text);
            Color c = Color.FromArgb(255, red, green, blue);
            panel1.BackColor = c;
            
            long hexa = long.Parse(textBox1.Text);
            textBox4.Text = Convert.ToString(hexa, 16);
        }

        private void Green_Change(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if (int.Parse(textBox2.Text) > 255)
            {
                textBox2.Text = "255";
            }
            vScrollBar2.Value = int.Parse(textBox2.Text);
            green = int.Parse(textBox2.Text);
            Color c = Color.FromArgb(255, red, green, blue);
            panel1.BackColor = c;
            long hexa = long.Parse(textBox2.Text);
            textBox5.Text = Convert.ToString(hexa, 16);
        }

        private void Blue_Change(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            if (int.Parse(textBox3.Text) > 255)
            {
                textBox3.Text = "255";
            }
            vScrollBar3.Value = int.Parse(textBox3.Text);
            blue = int.Parse(textBox3.Text);
            Color c = Color.FromArgb(255, red, green, blue);
            panel1.BackColor = c;
            long hexa = long.Parse(textBox3.Text);
            textBox6.Text = Convert.ToString(hexa, 16);


        }

        private void verif1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && touche == 0)
            {
                e.Handled = true;
            }
            
        }

        private void verif2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                touche = 1;
            }
            else
            {
                touche = 0;
            }
        }
    }
}