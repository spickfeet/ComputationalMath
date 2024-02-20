namespace ComputationalMath
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            IFunction f;
            if (comboBoxFunction.SelectedIndex == 0)
            {
                f = new FirstFunction();
                switch (comboBoxMethod.SelectedIndex)
                {
                    case 1:
                        NewtonMethod n = new NewtonMethod();
                        richTextBoxResult.Text = n.FindSolution(-5, f).ToString() + "\n" + n.FindSolution(-4, f).ToString() + "\n" + n.FindSolution(-1, f).ToString() + "\n" + n.FindSolution(3, f).ToString();
                        break;
                    case 2:

                        HalfDivision h = new HalfDivision();
                        richTextBoxResult.Text = h.DoMethod(-6, -4, f).ToString() + "\n" + h.DoMethod(-4, -2, f).ToString() + "\n" + h.DoMethod(-1, 2, f).ToString() + "\n" + h.DoMethod(1, 4, f).ToString();
                        break;


                }
            }
            else
            {
                f = new SecondFunction();
                switch (comboBoxMethod.SelectedIndex)
                {
                    case 1:
                        NewtonMethod n = new NewtonMethod();
                        richTextBoxResult.Text = n.FindSolution(99, f).ToString();
                        break;
                    case 2:
                        HalfDivision h = new HalfDivision();
                        richTextBoxResult.Text = h.DoMethod(90, 110, f).ToString();
                        break;


                }
            }

        }
    }
}