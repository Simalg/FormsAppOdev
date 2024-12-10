using System.Globalization;

namespace FormsAppOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxyil.Text = "Y�l se�iniz";
            for(int i = 2024; i > 1970; i--)
            {
                comboBoxyil.Items.Add(i);
            }

            comboBoxay.Text = "Ay se�iniz";
            foreach (string monthName in DateTimeFormatInfo.CurrentInfo.MonthNames)
            {
                if (!string.IsNullOrEmpty(monthName))
                {
                    comboBoxay.Items.Add(monthName);
                }
            }

            comboBoxgun.Text = "G�n se�iniz";
            for (int i = 30; i > 0; i--)
            {
                comboBoxgun.Items.Add(i);
            }
        }
    }
}
