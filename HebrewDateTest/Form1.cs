using HebrewDateTest.model;
using System.Xml.Linq;
using static HebrewDateTest.Servise.DateService;
namespace HebrewDateTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateXmlIfNotExist();
            for (int i = 1; i <= 30; i++)
            {
                DayMonthComboBox.Items.Add(i);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            DateModel dm = new(DayComboBox.Text, DayMonthComboBox.Text, MonthComboBox.Text, YearComboBox.Text);
            string res = CalculationResult(dm);
            MessageBox.Show($"{res}");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DateModel dm = new(DayComboBox.Text, DayMonthComboBox.Text, MonthComboBox.Text, YearComboBox.Text);
            AddDate(dm);
            MessageBox.Show("Date entered successfully");
        }
    }
}
