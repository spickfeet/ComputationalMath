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
            richTextBoxIntermediateValues.Clear();
            IFunction f;
            List<float> intermediateValues = new List<float>();
            if (comboBoxFunction.SelectedIndex == 0)
            {
                f = new FirstFunction();
                switch (comboBoxMethod.SelectedIndex)
                {
                    case 1:
                        NewtonMethod n = new NewtonMethod();
                        float xn1 = n.FindSolution(-5, f, intermediateValues);
                        PrintIntermediateValues(xn1, intermediateValues);
                        intermediateValues.Clear();

                        float xn2 = n.FindSolution(-4, f, intermediateValues);
                        PrintIntermediateValues(xn2, intermediateValues);
                        intermediateValues.Clear();

                        float xn3 = n.FindSolution(-1, f, intermediateValues);
                        PrintIntermediateValues(xn3, intermediateValues);
                        intermediateValues.Clear();

                        float xn4 = n.FindSolution(3, f, intermediateValues);
                        PrintIntermediateValues(xn4, intermediateValues);
                        intermediateValues.Clear();

                        richTextBoxResult.Text = xn1.ToString() + "\n" + xn2.ToString() + "\n" + xn3.ToString() + "\n" + xn4.ToString();
                        break;
                    case 2:
                        HalfDivision h = new HalfDivision();

                        h.Accuracy = (float)Math.Pow(10, -6);
 
                        float xh1 = h.DoMethod(-6, -4, f, intermediateValues);
                        PrintIntermediateValues(xh1, intermediateValues);
                        intermediateValues.Clear();

                        h.Accuracy = (float)Math.Pow(10, -6);
 
                        float xh2 = h.DoMethod(-4, -2, f, intermediateValues);
                        PrintIntermediateValues(xh2, intermediateValues);
                        intermediateValues.Clear();

                        h.Accuracy = (float)Math.Pow(10, -7);
                        float xh3 = h.DoMethod(-1, 2, f, intermediateValues);
                        PrintIntermediateValues(xh3, intermediateValues);
                        intermediateValues.Clear();

                        h.Accuracy = (float)Math.Pow(10, -6);
                        float xh4 = h.DoMethod(2, 3, f, intermediateValues);
                        PrintIntermediateValues(xh4, intermediateValues);
                        intermediateValues.Clear();

                        richTextBoxResult.Text = xh1.ToString() + "\n" + xh2.ToString() + "\n" + xh3.ToString() + "\n" + xh4.ToString();
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
                        float xn = n.FindSolution(101, f, intermediateValues);
                        PrintIntermediateValues(xn, intermediateValues);

                        intermediateValues.Clear();
                        richTextBoxResult.Text = xn.ToString();
                        break;
                    case 2:
                        HalfDivision h = new HalfDivision();
                        float xh = h.DoMethod(100, 101, f,intermediateValues);
                        PrintIntermediateValues(xh, intermediateValues);
                        richTextBoxResult.Text = xh.ToString();
                        break;


                }
            }

        }


        private void PrintIntermediateValues(float x, List<float> intermediateValues)
        {
            richTextBoxIntermediateValues.Text += "Промежуточные значения для корня " + x + "\n";
            foreach (float intermediateValue in intermediateValues)
            {
                richTextBoxIntermediateValues.Text += intermediateValue + "\n";
            }
        }
    }
}