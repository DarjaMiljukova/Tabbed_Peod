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
    public partial class Suvi : TabbedPage
    {
        public Suvi()
        {
            InitializeComponent();

            var juuni = new ContentPage
            {
                Title = "MEH",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Mehhatroonik",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "meh.jpg",
                            WidthRequest = 400,
                            HeightRequest = 400,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            GestureRecognizers =
                            {
                                new TapGestureRecognizer
                                {
                                    Command = new Command(async () => await ShowWebsiteSelection("https://www.tthk.ee/tabel_vastuvott_2024/", "https://www.tthk.ee/opetatavad_erialad/mehhatroonik/")),
                                }
                            }
                        },
                    }
                }
            };

            var juuli = new ContentPage
            {
                Title = "KYM",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Külmamehaanik",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "kymymm.png",
                            WidthRequest = 400,
                            HeightRequest = 400,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            GestureRecognizers =
                            {
                                new TapGestureRecognizer
                                {
                                    Command = new Command(async () => await ShowWebsiteSelection("https://www.tthk.ee/tabel_vastuvott_2024/", "https://www.tthk.ee/opetatavad_erialad/kulmamehaanik/")),
                                }
                            }
                        },
                    }
                }
            };

            var august = new ContentPage
            {
                Title = "ROO",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Roboti operaator",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "robi.jpg",
                            WidthRequest = 400,
                            HeightRequest = 400,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            GestureRecognizers =
                            {
                                new TapGestureRecognizer
                                {
                                    Command = new Command(async () => await ShowWebsiteSelection("https://www.tthk.ee/tabel_vastuvott_2024/", "https://www.tthk.ee/opetatavad_erialad/roboti-operaator/")),
                                }
                            }
                        },
                    }
                }
            };

            Children.Add(juuni);
            Children.Add(juuli);
            Children.Add(august);
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