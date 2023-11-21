namespace Exercicio_11
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

        private void bngnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();



            if (colorDialog.ShowDialog() == DialogResult.OK)
                label1.ForeColor = colorDialog.Color;

            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog.Font;
            }


        }

        private void letraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog.Font;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm_2 = new Form1();
            frm_2.ShowDialog();

        }
    }
}