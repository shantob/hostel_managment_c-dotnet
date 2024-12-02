using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace hostel_managment
{
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            // Sample data for the DataGrid
            var data = new List<Member>
            {
                new Member { SlNo = 1, MemberName = "John Doe", TotalCost = 2000, PaidCost = 1500, DueCost = 500, TotalMill = 20, FixedCost = 300, DateTime = DateTime.Now },
                new Member { SlNo = 2, MemberName = "Jane Smith", TotalCost = 2500, PaidCost = 2000, DueCost = 500, TotalMill = 25, FixedCost = 350, DateTime = DateTime.Now },
                new Member { SlNo = 3, MemberName = "Ali Khan", TotalCost = 3000, PaidCost = 3000, DueCost = 0, TotalMill = 30, FixedCost = 400, DateTime = DateTime.Now }
            };

            DemoDataGrid.ItemsSource = data;
        }
        private void DemoDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Handle selection change here
            var selectedItem = DemoDataGrid.SelectedItem;
            if (selectedItem != null)
            {
                MessageBox.Show($"You selected: {selectedItem}");
            }
        }
        private void add_summery_btn(object sender, RoutedEventArgs e)
        {
            AddSummaryWindow addSummaryWindow = new AddSummaryWindow();
            addSummaryWindow.ShowDialog(); // Show the form as a modal dialog
        }
    }

    // Data model
    public class Member
    {
        public int SlNo { get; set; }
        public string MemberName { get; set; }
        public int TotalCost { get; set; }
        public int PaidCost { get; set; }
        public int DueCost { get; set; }
        public int TotalMill { get; set; }
        public int FixedCost { get; set; }
        public DateTime DateTime { get; set; }
    }
}
