using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace JuanEstebanHelpPopup
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private async void OpenPopup(object sender, EventArgs e)
	    {
	        await PopupNavigation.PushAsync(new NamePhonePopUp());
	    }
	}
}
