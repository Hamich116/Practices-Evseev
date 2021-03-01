using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AirTicket
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();
            StackLayout main = new StackLayout
            {
                BackgroundColor = Color.FromHex("#080D17"),
                Children =
                {
                    new StackLayout
                    {
                        Spacing = 5,
                        HorizontalOptions = LayoutOptions.End,
                        Children =
                        {
                            new BoxView
                            {
                                HeightRequest = 30,
                                WidthRequest = 30,
                                Color = Color.White,
                                CornerRadius = 50,
                                HorizontalOptions = LayoutOptions.Fill,
                                VerticalOptions = LayoutOptions.Fill,
                            },
                            new BoxView
                            {
                                HeightRequest = 30,
                                WidthRequest = 30,
                                Color = Color.White,
                                CornerRadius = 50,
                                HorizontalOptions = LayoutOptions.Fill,
                                VerticalOptions = LayoutOptions.Fill,
                            },
                            new BoxView
                            {
                                HeightRequest = 30,
                                WidthRequest = 30,
                                Color = Color.White,
                                CornerRadius = 50,
                                HorizontalOptions = LayoutOptions.Fill,
                                VerticalOptions = LayoutOptions.Fill,
                            },
                        }
                    }
                }
            };

            Content = main;
        }
    }
}
