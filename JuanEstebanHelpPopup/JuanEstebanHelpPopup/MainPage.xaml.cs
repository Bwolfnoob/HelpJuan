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

        // public ObservableCollection<FuncionalidadesViewModel> FuncionalidadesA { get; set; } = new ObservableCollection<FuncionalidadesViewModel>();

        public ObservableCollection<Funcionalidade> ListaDados { get; set; }
        public string Nome { get; set; }
        public MainPage()
        {
            InitializeComponent();
            //  Lista.ItemsSource = new ObservableCollection<>
            this.ListaDados = new ObservableCollection<Funcionalidade>()
            {
                new Funcionalidade(){Descricao = "Funcionalidade 01" , Observacao = "A prática cotidiana prova que a valorização de fatores subjetivos causa impacto indireto na reavaliação do sistema de participação geral."},
                new Funcionalidade(){Descricao = "Funcionalidade 02" , Observacao = "Pensando mais a longo prazo, a crescente influência da mídia cumpre um papel essencial na formulação dos relacionamentos verticais entre as hierarquias." },
            new Funcionalidade(){Descricao = "Funcionalidade 03" , Observacao = "No mundo atual, a crescente influência da mídia auxilia a preparação e a composição do sistema de formação de quadros que corresponde às necessidades."},
            new Funcionalidade(){Descricao = "Funcionalidade 04" , Observacao = "Neste sentido, a adoção de políticas descentralizadoras talvez venha a ressaltar a relatividade das posturas dos órgãos dirigentes com relação às suas atribuições" },
            new Funcionalidade(){Descricao = "Funcionalidade 05" , Observacao = "Neste sentido, a complexidade dos estudos efetuados promove a alavancagem do impacto na agilidade decisória."}
            };


            this.BindingContext = this;

            CarregarLista();
        }

        private void CarregarLista()
        {
            //  FuncionalidadesA.Add(new FuncionalidadesViewModel(){MyImagemMenuA = "icon" , Funcionalidade = "Funcionalidade 01" });
            //  FuncionalidadesA.Add(new FuncionalidadesViewModel() { MyImagemMenuA = "icon", Funcionalidade = "Funcionalidade 02" });

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
                await DisplayAlert("Title", "A operação foi cancelada pelo usuário.", "Ok");
            }

        }
    }
}
