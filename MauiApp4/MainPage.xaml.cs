namespace MauiApp4;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        var window = new Window
        {
            Page = new NewPage1()
        };
        Application.Current.OpenWindow(window);

    }
}

