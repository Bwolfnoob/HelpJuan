using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Database;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace JuanEstebanHelpPopup
{
	public partial class MainPage : ContentPage
	{
	    public string Nome { get; set; }
		public MainPage()
		{
			InitializeComponent();
		  //  Lista.ItemsSource = new ObservableCollection<>

        }

	    private async void OpenPopup(object sender, EventArgs e)
	    {
	        var nome = Nome;

	        var page = new NamePhonePopUp(ref nome);
	        page.Disappearing += (o, args) =>
	        {
	            var b = nome;
	        };

            await PopupNavigation.PushAsync(page: page);
	        var a = nome;
	    }
	}
}
