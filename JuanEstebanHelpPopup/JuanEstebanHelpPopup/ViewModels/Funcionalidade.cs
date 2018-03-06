using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace JuanEstebanHelpPopup.ViewModels
{
    public class Funcionalidade: ViewModelBase
    {
        private bool _visible;

        public bool Visible
        {
            get { return _visible; }
            set
            {
                OnPropertyChanged("Visible");
                _visible = value;
            }
        }
        
        private string _icone;

        public string Icone
        {
            get { return _icone; }
            set { OnPropertyChanged("Icone");
                _icone = value; }
        }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { OnPropertyChanged("Descricao"); _descricao = value; }
        }

        private string _observacao;

        public string Observacao
        {
            get { return _observacao; }
            set { OnPropertyChanged("Observacao"); _observacao = value; }
        }

        private ICommand _iconeCommand;

        public ICommand IconeCommand
        {
            get { return _iconeCommand; }
            set { OnPropertyChanged("IconeCommand"); _iconeCommand = value; }
        }

        public Funcionalidade()
        {
            Icone = "ic_keyboard_arrow_right_black_24dp";
            IconeCommand = new Command(() =>
            {
                Visible = !Visible;

                if (Visible)
                {
                    Icone = "ic_keyboard_arrow_down_black_24dp";
                }
                else
                {
                    Icone = "ic_keyboard_arrow_right_black_24dp";
                }
            });
        }

    }
}
