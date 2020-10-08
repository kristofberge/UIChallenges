using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace UiChallenges.ViewModels
{
    public class CruiseMobileViewModel : BaseViewModel
    {
        public ObservableCollection<Cruise> _cruisesList;

        public Header Header { get; set; }

        public ObservableCollection<Cruise> CruisesList
        {
            get => _cruisesList;
            set
            {
                _cruisesList = value;
                NotifyPropertyChanged();
            }
        }

        public int NumberOfLiked => CruisesList.Count(c => c.Liked);

        public ICommand LikeClickedCommand { get; set; }

        public CruiseMobileViewModel()
        {
            Header = new Header
            {
                FirstName = "Philip",
                LastName = "the Good",
                Avatar = "https://upload.wikimedia.org/wikipedia/commons/a/a4/Philip_the_good.jpg"
            };

            CruisesList = new ObservableCollection<Cruise>
            {
                new Cruise
                {
                    TitleFirst = "Asia",
                    TitleLast = "& Austalia",
                    Image1 = "https://visit.gent.be/sites/default/files/styles/paragraph_image/public/img/image_paragraph/VisitReeks61-DT008604.jpg",
                    Image2 = "https://i1.wp.com/www.annieanywhere.com/wp-content/uploads/2015/06/P6080604-e1435520939528.jpg",
                    Image3 = "https://www.thedreampacker.com/wp-content/uploads/2017/02/13226843_1159446820742376_4796586553201082358_n.jpg",
                    Description = "The Gravensteen is a medieval castle at Ghent, East Flanders in Belgium.",
                    Rating = 4.5,
                    Liked = false,
                    Price = 319d
                },
                new Cruise
                {
                    TitleFirst = "Scandinavian",
                    TitleLast = "& northern",
                    Image1 = "https://i.pinimg.com/originals/65/1e/36/651e36887a158e83bee5c5514d1d2709.jpg",
                    Image2 = "https://img.travelawaits.com/filter:centercrop/quill/5/b/3/2/f/9/5b32f9a3c49d2ae139560022725c0b6129b493bc.jpg?w=800&h=800",
                    Image3 = "https://image.arrivalguides.com/1230x800/13/a3bab461c7b7c9f9137fff02426b8e0a.jpg",
                    Description = "Marvel at the unmatched beauty of Greece, Italy, Spain and southern France.",
                    Rating = 4.5,
                    Liked = true,
                    Price = 521d
                },
                new Cruise
                {
                    TitleFirst = "Sky Princess",
                    TitleLast = "debuts in fall",
                    Image1 = "https://media-cdn.tripadvisor.com/media/photo-m/1280/1b/af/eb/d2/la-citadelle-de-dinant.jpg",
                    Image2 = "https://i1.wp.com/queroviajarmais.com/wp-content/uploads/2019/12/Citadel-de-Namur.jpg",
                    Image3 = "https://www.tracesofwar.com/upload/4804171129101812.JPG",
                    Description = "The Citadel of Dinant is a fortress located in the Walloon city of Dinant in the province of Namur, Belgium. The current fort was built in 1815 on a site which was originally fortified in 1051 when the region was ruled by the Prince-Bishopric of Liège.",
                    Rating = 4.6,
                    Liked = false,
                    Price = 743d
                },
                new Cruise
                {
                    TitleFirst = "Experience",
                    TitleLast = "amazing Barcelona",
                    Image1 = "https://miepvonsydow.files.wordpress.com/2016/04/c__data_users_defapps_appdata_internetexplorer_temp_saved-images_bag4vf9.jpg",
                    Image2 = "https://mymodernmet.com/wp/wp-content/uploads/2018/07/World-War-I-color-photography-cvl00200_p.jpg",
                    Image3 = "https://www.history.com/.image/t_share/MTYxMjA2MDkyMTEyNjAyNjEz/wwi_color_feature.jpg",
                    Description = "Experience cororful Barcelona and sample the world's finest wines in the vineyards of",
                    Rating = 4.6,
                    Liked = false,
                    Price = 743d
                }
            };

            LikeClickedCommand = new Command<Cruise>(OnLikeClicked);
        }

        private void OnLikeClicked(Cruise cruise)
        {
            cruise.Liked = !cruise.Liked;
            NotifyPropertyChanged(nameof(NumberOfLiked));
        }
    }

    public class Cruise : BaseViewModel
    {
        private string _titleFirst;
        private string _titleLast;
        private string _image1;
        private string _image2;
        private string _image3;
        private string _description;
        private bool _liked;
        private double _rating;
        private double _price;

        public string TitleFirst
        {
            get => _titleFirst;
            set
            {
                _titleFirst = value;
                NotifyPropertyChanged(nameof(TitleFirst));
            }
        }

        public string TitleLast
        {
            get => _titleLast;
            set
            {
                _titleLast = value;
                NotifyPropertyChanged(nameof(TitleLast));
            }
        }

        public string Image1
        {
            get => _image1;
            set
            {
                _image1 = value;
                NotifyPropertyChanged(nameof(Image1));
            }
        }

        public string Image2
        {
            get => _image2;
            set
            {
                _image2 = value;
                NotifyPropertyChanged(nameof(Image2));
            }
        }

        public string Image3
        {
            get => _image3;
            set
            {
                _image3 = value;
                NotifyPropertyChanged(nameof(Image3));
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                NotifyPropertyChanged(nameof(Description));
            }
        }

        public double Rating
        {
            get => _rating;
            set
            {
                _rating = value;
                NotifyPropertyChanged(nameof(Rating));
            }
        }

        public bool Liked
        {
            get => _liked;
            set
            {
                _liked = value;
                NotifyPropertyChanged(nameof(Liked));
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                _price = value;
                NotifyPropertyChanged(nameof(Price));
            }
        }
    }

    public class Header
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
    }
}
