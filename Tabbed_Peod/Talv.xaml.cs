using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using System.Threading.Tasks;

namespace Tabbed_Peod
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Talv : TabbedPage
    {
        public Talv()
        {
            InitializeComponent();

            var detsember = new ContentPage
            {
                Title = "TAR",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Noorem tarkvara arendaja",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "tar.jpg",
                            WidthRequest = 400,
                            HeightRequest = 400,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            GestureRecognizers =
                            {
                                new TapGestureRecognizer
                                {
                                    Command = new Command(async () => await ShowWebsiteSelection("https://www.tthk.ee/tabel_vastuvott_2024/", "https://www.tthk.ee/opetatavad_erialad/noorem-tarkvaraarendaja/")),
                                }
                            }
                        },
                    }
                }
            };
            var jaanuar = new ContentPage
            {
                Title = "LOGIT",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Logistika IT süsteemide nooremspetsialist",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "logit.jpg",
                            WidthRequest = 400,
                            HeightRequest = 400,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            GestureRecognizers =
                            {
                                new TapGestureRecognizer
                                {
                                    Command = new Command(async () => await ShowWebsiteSelection("https://www.tthk.ee/tabel_vastuvott_2024/", "https://www.tthk.ee/opetatavad_erialad/logistika-it-susteemide-nooremspetsialist/")),
                                }
                            }
                        },
                    }
                }
            };
            var veebruar = new ContentPage
            {
                Title = "TIT",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Tööstusinformaatika",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "tit.jpg",
                            WidthRequest = 400,
                            HeightRequest = 400,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            GestureRecognizers =
                            {
                                new TapGestureRecognizer
                                {
                                    Command = new Command(async () => await ShowWebsiteSelection("https://www.tthk.ee/tabel_vastuvott_2024/", "https://www.tthk.ee/opetatavad_erialad/toostusinformaatik/")),
                                }
                            }
                        },
                    }
                }
            };

            Children.Add(detsember);
            Children.Add(jaanuar);
            Children.Add(veebruar);
        }

        private async Task ShowWebsiteSelection(string url1, string url2)
        {
            var choice = await DisplayAlert("Valik veebileht", "Valige veebileht avamiseks", "Vastuvõtt", "Kutseala kohta");

            if (choice)
            {
                Device.OpenUri(new Uri(url1));
            }
            else
            {
                Device.OpenUri(new Uri(url2));
            }
        }
    }
}
