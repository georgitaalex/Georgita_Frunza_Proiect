
using Georgita_Frunza_Proiect.Models;

namespace Georgita_Frunza_Proiect;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var sportslist = (SSList)BindingContext;
        await App.Database.SaveSSListAsync(sportslist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var sportslist = (SSList)BindingContext;
        await App.Database.DeleteSSListAsync(sportslist);
        await Navigation.PopAsync();
    }

}