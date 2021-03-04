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
                Padding = 20,
                BackgroundColor = Color.FromHex("#080D17"),
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        BackgroundColor = Color.Red,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.Start,
                        Children =
                        {
                            new Frame
                            {
                                HorizontalOptions = LayoutOptions.Start,
                                VerticalOptions = LayoutOptions.Center,
                                BackgroundColor = Color.FromHex("#3C9DD4"),
                                CornerRadius = 90,
                                Padding = 0,
                                HeightRequest = 50,
                                WidthRequest = 50,
                            },
                            new Frame
                            {

                                Padding = 0,
                                BackgroundColor = Color.FromHex("#3C9DD4"),
                                CornerRadius = 30,
                                WidthRequest = 180,
                                HeightRequest = 55,
                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                VerticalOptions = LayoutOptions.Center,
                                Content = new Label
                                {
                                    Text = "Привет,Ильхам",
                                    TextColor = Color.White,
                                    HorizontalOptions = LayoutOptions.Center,
                                    VerticalOptions = LayoutOptions.Center,
                                },
                            },
                            new StackLayout
                            {
                                BackgroundColor = Color.Blue,
                                Padding = 10,
                                Spacing = 5,
                                HorizontalOptions = LayoutOptions.End,
                                VerticalOptions = LayoutOptions.Center,
                                Children =
                                {
                                    new BoxView
                                    {
                                        HeightRequest = 5,
                                        WidthRequest = 5,
                                        Color = Color.White,
                                        CornerRadius = 50,
                                        HorizontalOptions = LayoutOptions.Center,
                                        VerticalOptions = LayoutOptions.Center,
                                    },
                                    new BoxView
                                    {
                                        HeightRequest = 5,
                                        WidthRequest = 5,
                                        Color = Color.White,
                                        CornerRadius = 50,
                                        HorizontalOptions = LayoutOptions.Center,
                                        VerticalOptions = LayoutOptions.Center,
                                    },
                                    new BoxView
                                    {
                                        HeightRequest = 5,
                                        WidthRequest = 5,
                                        Color = Color.White,
                                        CornerRadius = 50,
                                        HorizontalOptions = LayoutOptions.Center,
                                        VerticalOptions = LayoutOptions.Center,
                                    },

                                }
                            },


                        }


                    },
                    new StackLayout
                    {
                        BackgroundColor = Color.Green,
                        Orientation = StackOrientation.Horizontal,
                        Padding = new Thickness(20,10,20,10),
                        Spacing = 10,
                        Children =
                        {
                            new Label
                            {

                                TextColor = Color.White,
                                Text = "Скоро полетим",
                                HorizontalOptions = LayoutOptions.Start,
                                VerticalOptions = LayoutOptions.Center,
                            },
                            new Frame
                            {
                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                VerticalOptions = LayoutOptions.Center,
                                BackgroundColor = Color.FromHex("#3C9DD4"),
                                CornerRadius = 90,
                                Padding = 0,
                                HeightRequest = 50,
                                WidthRequest = 50,
                            }
                        }
                    },
                    new ScrollView
                    {
                        Orientation = ScrollOrientation.Horizontal,
                        Content = new StackLayout
                        {
                            BackgroundColor = Color.DeepPink,
                            Orientation = StackOrientation.Horizontal,
                            Spacing = 10,
                            Children =
                            {
                                new Frame
                                {
                                    BackgroundColor = Color.White,
                                    Padding = 0,
                                    WidthRequest = 100,
                                    HeightRequest = 30,
                                    CornerRadius = 40,
                                    Content = new Label
                                    {
                                        Text = "KMP-MSC",
                                        TextColor = Color.FromHex("#3C9DD4"),
                                        HorizontalOptions = LayoutOptions.Center,
                                        VerticalOptions = LayoutOptions.Center,
                                    }
                                },
                                new Frame
                                {
                                    BackgroundColor = Color.FromHex("#3C9DD4"),
                                    Padding = 0,
                                    WidthRequest = 100,
                                    HeightRequest = 30,
                                    CornerRadius = 40,
                                    Content = new Label
                                    {
                                        Text = "SPB-MSC",
                                        TextColor = Color.White,
                                        HorizontalOptions = LayoutOptions.Center,
                                        VerticalOptions = LayoutOptions.Center,
                                    }
                                },
                                new Frame
                                {
                                    BackgroundColor = Color.White,
                                    Padding = 0,
                                    WidthRequest = 100,
                                    HeightRequest = 30,
                                    CornerRadius = 40,
                                    Content = new Label
                                    {
                                        Text = "SPB-MSC",
                                        TextColor = Color.FromHex("#3C9DD4"),
                                        HorizontalOptions = LayoutOptions.Center,
                                        VerticalOptions = LayoutOptions.Center,
                                    }
                                },
                                new Frame
                                {
                                    BackgroundColor = Color.White,
                                    Padding = 0,
                                    WidthRequest = 100,
                                    HeightRequest = 30,
                                    CornerRadius = 40,
                                    Content = new Label
                                    {
                                        Text = "SPB-MSC",
                                        TextColor = Color.FromHex("#3C9DD4"),
                                        HorizontalOptions = LayoutOptions.Center,
                                        VerticalOptions = LayoutOptions.Center,
                                    }
                                },
                                new Frame
                                {
                                    BackgroundColor = Color.White,
                                    Padding = 0,
                                    WidthRequest = 100,
                                    HeightRequest = 30,
                                    CornerRadius = 40,
                                    Content = new Label
                                    {
                                        Text = "SPB-MSC",
                                        TextColor = Color.FromHex("#3C9DD4"),
                                        HorizontalOptions = LayoutOptions.Center,
                                        VerticalOptions = LayoutOptions.Center,
                                    }
                                },
                                new Frame
                                {
                                    BackgroundColor = Color.White,
                                    Padding = 0,
                                    WidthRequest = 100,
                                    HeightRequest = 30,
                                    CornerRadius = 40,
                                    Content = new Label
                                    {
                                        Text = "SPB-MSC",
                                        TextColor = Color.FromHex("#3C9DD4"),
                                        HorizontalOptions = LayoutOptions.Center,
                                        VerticalOptions = LayoutOptions.Center,
                                    }
                                },
                            }
                        }
                    }
                }
            };
            Content = main;
        }

    }
}
