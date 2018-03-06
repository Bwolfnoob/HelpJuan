using System;
using System.Collections.ObjectModel;
using JuanEstebanHelpPopup.ViewModels;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace JuanEstebanHelpPopup
{
	public partial class MainPage : ContentPage
	{

	    public ObservableCollection<FuncionalidadesViewModel> FuncionalidadesA { get; set; } = new ObservableCollection<FuncionalidadesViewModel>();

	    public string Nome { get; set; }
		public MainPage()
		{
			InitializeComponent();
		  //  Lista.ItemsSource = new ObservableCollection<>
		    BindingContext = this;

		    CarregarLista();
		}

	    private void CarregarLista()
	    {
	        FuncionalidadesA.Add(new FuncionalidadesViewModel(){MyImagemMenuA = "icon" , Funcionalidade = "Funcionalidade 01" });
	        FuncionalidadesA.Add(new FuncionalidadesViewModel() { MyImagemMenuA = "icon", Funcionalidade = "Funcionalidade 02" });

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

	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	        await CrossMedia.Current.Initialize();

	        if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
	        {
	            await DisplayAlert("Erro", ":( Nenhuma camera encontrada.", "OK");
	            return;
	        }

	        var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
	        {
	            Directory = "CredDefence",
	            Name = "CredDefence_Foto.jpg",
	            PhotoSize = PhotoSize.Medium
	        });

	        if (file == null)
	        {
	            await DisplayAlert("Title","A operação foi cancelada pelo usuário.","Ok");
	        }
	       
        }
    }
}
