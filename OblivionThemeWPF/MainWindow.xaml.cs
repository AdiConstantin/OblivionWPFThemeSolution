using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Threading;
using OblivionThemeWPF.Models;

namespace OblivionThemeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
            StartTimeUpdate();
        }

        private void StartTimeUpdate()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += Timer_Tick;
            _timer.Start();
            
            // Update immediately
            UpdateTimeDisplay();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTimeDisplay();
        }

        private void UpdateTimeDisplay()
        {
            if (TimeDisplay != null)
            {
                TimeDisplay.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
                e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening link: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void PaymentButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Tag is string url)
            {
                try
                {
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening payment link: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
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
                    MessageBox.Show("Error loading data: " + ex.Message, "Data Loading Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                // Create some sample data if the file doesn't exist
                var sampleData = new List<Person>
                {
                    new Person { Id = 1, FirstName = "Jack", LastName = "Harper", Age = 35, Email = "jack.harper@oblivion.com", Phone = "+1-555-0001", Address = "Sky Tower", City = "New York", Country = "USA", IsActive = true },
                    new Person { Id = 2, FirstName = "Julia", LastName = "Rusakova", Age = 32, Email = "julia.rusakova@oblivion.com", Phone = "+1-555-0002", Address = "Tet Command", City = "Earth", Country = "USA", IsActive = true },
                    new Person { Id = 3, FirstName = "Victoria", LastName = "Olsen", Age = 29, Email = "victoria.olsen@oblivion.com", Phone = "+1-555-0003", Address = "Ground Station", City = "Nevada", Country = "USA", IsActive = false },
                    new Person { Id = 4, FirstName = "Malcolm", LastName = "Beech", Age = 45, Email = "malcolm.beech@resistance.org", Phone = "+1-555-0004", Address = "Underground", City = "Earth", Country = "Unknown", IsActive = true },
                    new Person { Id = 5, FirstName = "Sally", LastName = "Mission Control", Age = 28, Email = "sally@tet.com", Phone = "+1-555-0005", Address = "Orbital Station", City = "Space", Country = "N/A", IsActive = true }
                };
                
                MyDataGrid.ItemsSource = sampleData;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            _timer?.Stop();
            base.OnClosed(e);
        }
    }
}