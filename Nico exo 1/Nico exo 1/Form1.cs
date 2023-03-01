namespace Nico_exo_1;

public partial class Form1 : Form
{
    int touche;
    public Form1()
    {
        InitializeComponent();
        button1.Enabled = false;
    }

    private void verif1(object sender, KeyPressEventArgs e)
    {
        if ((e.KeyChar > '9' || e.KeyChar < '0') && e.KeyChar != ',' && touche == 0)
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

    private void Clicksom(object sender, EventArgs e)
    {
        float var1;
        float var2;
        var1 = float.Parse(textBox1.Text);
        var2 = float.Parse(textBox2.Text);
        float som;
        som = var1 + var2;
        MessageBox.Show("the result is " + som.ToString(), "Résultat", MessageBoxButtons.OK);
    }

    private void TextChanged(object sender, EventArgs e)
    {
        if (textBox1.Text != "" && textBox2.Text != "")
        {
            button1.Enabled = true;
        }
        else
        {
            button1.Enabled = false;
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}
