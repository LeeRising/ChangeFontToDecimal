using System;
using System.Windows;

namespace ChangeFontToDecimal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InputFontText.TextChanged += delegate
            {
                OutputText.Text = InputFontText.Text.Length > 0 && InputFontText.Text.Length == 4 ? $"&#x{InputFontText.Text};" : "Wait...";
                if (OutputText.Text != "Wait...")
                    Clipboard.SetText(OutputText.Text);
            };
        }
    }
}