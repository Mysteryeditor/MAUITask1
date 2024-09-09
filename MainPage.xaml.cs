using Microsoft.Maui.Controls;

namespace HelloMauiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Event handler to update the label based on the entry field text
        private void OnUpdateLabelClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryField.Text))
            {
                updatedLabel.Text = $"You entered: {entryField.Text}";
            }
            else
            {
                updatedLabel.Text = "Please enter some text.";
            }
        }

        // Event handler to navigate to the About Page
        private async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
    }
}
