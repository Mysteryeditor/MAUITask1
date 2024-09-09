using Microsoft.Maui.Controls;

namespace HelloMauiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

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
        private async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
    }
}
