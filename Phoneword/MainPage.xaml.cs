namespace Phoneword;

public partial class MainPage : ContentPage
{
    async void OnCall(object sender, System.EventArgs e)
    {
        if (await this.DisplayAlert(
            "Dial a NUmber",
            "Would you like to call " + translatedNumber + " ?",
            "Yes",
            "No"))
        {
            //dial the phone
        }
    }

    public MainPage()
    {
    
        InitializeComponent();
    }

    string translatedNumber;

    private void OnTranslate(object sender, EventArgs e)
    {
        string enteredNumber = PhoneNumberText.Text;
        translatedNumber = Phoneword.PhonewordTranslator.ToNumber(enteredNumber);

        if (!string.IsNullOrEmpty(translatedNumber))
        {
            CallButton.IsEnabled = true;
            CallButton.Text = "Call " + translatedNumber;
        }
        else
        {
            CallButton.IsEnabled = false;
            CallButton.Text = "Call";
        }
    }


}

