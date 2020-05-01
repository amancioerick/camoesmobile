using MobileCamoes.Model;
using MobileCamoes.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileCamoes.ViewModel
{
    public class DetailViewModel : ViewModelBase
    {

        public DetailViewModel(Serie serie) : base("")
        {
            DetailSerie = serie;
            Name = serie.Name;
        }




        public Serie DetailSerie = new Serie();

        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

    }

    }
    

  

