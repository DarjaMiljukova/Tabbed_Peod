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
    public partial class elek : TabbedPage
    {
        public elek()
        {
            InitializeComponent();


            var mehhid = new ContentPage
            {
                Title = "kym",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text="kym",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions= LayoutOptions.Center,
                        },
                        new Image
                        {
                            Source = "ope.jpg",
                            WidthRequest = 400,
                            HeightRequest= 400,
                            HorizontalOptions= LayoutOptions.Center,
                            VerticalOptions= LayoutOptions.CenterAndExpand,
                        }
                    }
                }
            };
            Children.Add(mehhid);
        }
    }
}