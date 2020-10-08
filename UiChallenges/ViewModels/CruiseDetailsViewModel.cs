using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace UiChallenges.ViewModels
{
    public class CruiseDetailsViewModel
    {
        public CruiseDetail Cruise { get; }

        public ICommand LikeClickedCommand { get; set; }

        public CruiseDetailsViewModel(Cruise cruise)
        {
            Cruise = CruiseDetail.FromCruise(cruise);

            LikeClickedCommand = new Command(OnLikeClicked);
        }

        private void OnLikeClicked()
        {
            Cruise.Liked = !Cruise.Liked;

        }
    }

    public class CruiseDetail : Cruise
    {
        private bool _hasBus;
        private bool _hasTour;
        private bool _hasMap;
        private bool _hasFood;
        private bool _hasHotel;

        public static CruiseDetail FromCruise(Cruise cruise) => new CruiseDetail
        {
            Description = cruise.Description,
            Image1 = cruise.Image1,
            Image2 = cruise.Image2,
            Image3 = cruise.Image3,
            Liked = cruise.Liked,
            Price = cruise.Price,
            TitleFirst = cruise.TitleFirst,
            TitleLast = cruise.TitleLast,
            Rating = cruise.Rating
        };

        public bool HasBus
        {
            get => _hasBus;
            set
            {
                _hasBus = value;
                NotifyPropertyChanged(nameof(HasBus));
                NotifyPropertyChanged(nameof(HasAll));
            }
        }

        public bool HasTour
        {
            get => _hasTour;
            set
            {
                _hasTour = value;
                NotifyPropertyChanged(nameof(HasTour));
                NotifyPropertyChanged(nameof(HasAll));
            }
        }

        public bool HasMap
        {
            get => _hasMap;
            set
            {
                _hasMap = value;
                NotifyPropertyChanged(nameof(HasMap));
                NotifyPropertyChanged(nameof(HasAll));
            }
        }

        public bool HasFood
        {
            get => _hasFood;
            set
            {
                _hasFood = value;
                NotifyPropertyChanged(nameof(HasFood));
                NotifyPropertyChanged(nameof(HasAll));
            }
        }

        public bool HasHotel
        {
            get => _hasHotel;
            set
            {
                _hasHotel = value;
                NotifyPropertyChanged(nameof(HasHotel));
                NotifyPropertyChanged(nameof(HasAll));
            }
        }

        public bool HasAll => HasBus && HasTour && HasMap && HasFood && HasHotel;

        public string Title => $"{TitleFirst} {TitleLast}";

        public string[] Images => new string[] { Image1, Image2, Image3 };
    }
}
