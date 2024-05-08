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
    public partial class Sugis : TabbedPage
    {
        public Sugis()
        {
            InitializeComponent();

            var september = new ContentPage
            {
                Title = "EKS",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "E - kaubanduse spetsialist",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "eks.jpg",
                            WidthRequest = 400,
                            HeightRequest = 400,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            GestureRecognizers =
                            {
                                new TapGestureRecognizer
                                {
                                    Command = new Command(async () => await ShowWebsiteSelection("https://www.tthk.ee/tabel_vastuvott_2024/", "https://www.tthk.ee/opetatavad_erialad/e-kaubanduse-spetsialist/")),
                                }
                            }
                        },
                    }
                }
            };

            var oktoober = new ContentPage
            {
                Title = "MÜE",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Müügiesindaja",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "mue.jpg",
                            WidthRequest = 400,
                            HeightRequest = 400,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            GestureRecognizers =
                            {
                                new TapGestureRecognizer
                                {
                                    Command = new Command(async () => await ShowWebsiteSelection("https://www.tthk.ee/tabel_vastuvott_2024/", "https://www.tthk.ee/opetatavad_erialad/muugiesindaja/")),
                                }
                            }
                        },
                    }
                }
            };

            var november = new ContentPage
            {
                Title = "MÜK",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Müügikorraldaja",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "muk.jpg",
                            WidthRequest = 400,
                            HeightRequest = 400,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            GestureRecognizers =
                            {
                                new TapGestureRecognizer
                                {
                                    Command = new Command(async () => await ShowWebsiteSelection("https://www.tthk.ee/tabel_vastuvott_2024/", "https://www.tthk.ee/opetatavad_erialad/muugikorraldaja/")),
                                }
                            }
                        },
                    }
                }
            };

            Children.Add(september);
            Children.Add(oktoober);
            Children.Add(november);
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