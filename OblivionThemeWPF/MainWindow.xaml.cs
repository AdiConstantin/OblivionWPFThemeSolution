using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using OblivionThemeWPF.Models;

namespace OblivionThemeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
            e.Handled = true;
        }

        private void PaymentButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Tag is string url)
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }

        private void LoadData()
        {
            var jsonPath = "data/people.json";
            if (File.Exists(jsonPath))
            {
                try
                {
                    var json = File.ReadAllText(jsonPath);
                    var people = JsonSerializer.Deserialize<List<Person>>(json);
                    MyDataGrid.ItemsSource = people;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("people.json not found at: " + Path.GetFullPath(jsonPath));
            }
        }
    }
}