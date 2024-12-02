using System;
using System.Windows;

namespace hostel_managment
{
    public partial class AddSummaryWindow : Window
    {
        public AddSummaryWindow()
        {
            InitializeComponent();
            LoadMembers(); // Load sample data
        }

        private void LoadMembers()
        {
            // Sample member data for ComboBox
            MemberComboBox.Items.Add("John Doe");
            MemberComboBox.Items.Add("Jane Smith");
            MemberComboBox.Items.Add("Ali Khan");
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added");
            // Collect the form data
          /*  string selectedMember = MemberComboBox.SelectedItem?.ToString();
            int.TryParse(TotalCostTextBox.Text, out int totalCost);
            int.TryParse(PaidCostTextBox.Text, out int paidCost);
            int.TryParse(DueCostTextBox.Text, out int dueCost);

            // For now, just show a message (You can save data to a database here)
            MessageBox.Show($"Member: {selectedMember}\nTotal Cost: {totalCost}\nPaid Cost: {paidCost}\nDue Cost: {dueCost}", "Summary Submitted");
            */
            this.Close(); // Close the popup after submission
        }
    }
}
