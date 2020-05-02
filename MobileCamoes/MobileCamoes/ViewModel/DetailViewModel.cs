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
            Overview = serie.Overview;
            RealeaseDate = serie.ReleaseDate;
            VoteAverage = serie.VoteAverage;
            Poster = serie.Poster;

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
        private string overview;
        public string Overview
        {
            get => overview;
            set
            {
                overview = value;
                OnPropertyChanged();
            }
        }

        private string realeasedate;
        public string RealeaseDate
        {
            get => realeasedate;
            set
            {
                realeasedate = value;
                OnPropertyChanged();
            }
        }


        private double voteaverage;
        public double VoteAverage
        {
            get => voteaverage;
            set
            {
                voteaverage = value;
                OnPropertyChanged();
            }
        }

        private string poster;
        public string Poster
        {
            get => poster;
            set
            {
                poster = value;
                OnPropertyChanged();
            }
        }

    }

    }
    

  

