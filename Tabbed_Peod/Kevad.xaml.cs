using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tabbed_Peod
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kevad : TabbedPage
    {
        public Kevad()
        {
            InitializeComponent();

            var marts = new ContentPage
            {
                Title = "AKT",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Autokeretehnik",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "akt.jpg",
                            WidthRequest = 400,
                            HeightRequest = 400,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            GestureRecognizers =
                            {
                                new TapGestureRecognizer
                                {
                                    Command = new Command(async () => await ShowWebsiteSelection("https://www.tthk.ee/tabel_vastuvott_2024/", "https://www.tthk.ee/opetatavad_erialad/autokeretehnik/")),
                                }
                            }
                        },
                    }
                }
            };

            var aprill = new ContentPage
            {
                Title = "AUM",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Automaaler",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "aum.jpg",
                            WidthRequest = 400,
                            HeightRequest = 400,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            GestureRecognizers =
                            {
                                new TapGestureRecognizer
                                {
                                    Command = new Command(async () => await ShowWebsiteSelection("https://www.tthk.ee/tabel_vastuvott_2024/", "https://www.tthk.ee/opetatavad_erialad/automaaler/")),
                                }
                            }
                        },
                    }
                }
            };

            var mai = new ContentPage
            {
                Title = "AUT",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Mootorsõidukitehnik",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "aut.jpg",
                            WidthRequest = 400,
                            HeightRequest = 400,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            GestureRecognizers =
                            {
                                new TapGestureRecognizer
                                {
                                    Command = new Command(async () => await ShowWebsiteSelection("https://www.tthk.ee/tabel_vastuvott_2024/", "https://www.tthk.ee/opetatavad_erialad/soiduautotehnik/")),
                                }
                            }
                        },
                    }
                }
            };

            Children.Add(marts);
            Children.Add(aprill);
            Children.Add(mai);
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