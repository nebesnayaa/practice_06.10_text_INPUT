using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace practice_06._10_text_INPUT
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void inputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!IsLetter(e.Text))
            {
                e.Handled = true;
            }
        }

        private bool IsLetter(string input)
        {
            // Перевірка, чи введено літеру [A-Z] або [А-Я]
            return Regex.IsMatch(input, @"^[A-ZА-Я]$");
        }
    }
}
