using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            EventManager.RegisterClassHandler(typeof(Button), Button.ClickEvent, new RoutedEventHandler(ButtonMain));
        }

        private void ButtonMain(object sender, RoutedEventArgs eventArgs)
        {
            Button B = (Button)sender;

            switch (B.Content)
            {
                case "=":
                    string value = new DataTable().Compute(Screen.Text, null).ToString();
                    Screen.Text = value;
                    break;
                case "AC":
                    Screen.Text = "";
                    break;
                default:
                    Screen.Text += B.Content;
                    break;
            }
        }
    }
}