

using Georgita_Frunza_Proiect.Models;

namespace Georgita_Frunza_Proiect;

public partial class SSListEntryPage : ContentPage
{
	public SSListEntryPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetSSListsAsync();
    }
    async void OnSSListAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListPage
        {
            BindingContext = new SSList()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ListPage
            {
                BindingContext = e.SelectedItem as SSList
            });
        }
    }

}