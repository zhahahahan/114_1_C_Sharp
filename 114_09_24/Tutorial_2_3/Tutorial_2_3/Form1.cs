namespace Tutorial_2_3
{
    public partial class hi : Form
    {
        public hi()
        {
            InitializeComponent();
        }

        private void italian_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buongiorno";

        }

        private void spanishButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buonos dias";
        }

        private void germanButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Guten Morgen";

        }
    }
}
