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
                Spacing = 15,
                Padding = 20,
                BackgroundColor = Color.FromHex("#080D17"),
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
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
                                WidthRequest = 160,
                                HeightRequest = 55,
                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                VerticalOptions = LayoutOptions.Center,
                                Content = new Label
                                {
                                    Text = "Привет, Ильхам",
                                    TextColor = Color.White,
                                    HorizontalOptions = LayoutOptions.Center,
                                    VerticalOptions = LayoutOptions.Center,
                                    FontSize = 16
                                },
                            },
                            new StackLayout
                            {
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
                                FontSize = 27
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
                    },
                    new Frame
                    {
                        Padding = 0,
                        WidthRequest = 300,
                        HeightRequest = 150,
                        CornerRadius = 15,
                        Content = new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new StackLayout
                                {
                                    MinimumWidthRequest = 240,
                                    VerticalOptions = LayoutOptions.FillAndExpand,
                                    HorizontalOptions = LayoutOptions.FillAndExpand,
                                    Spacing = 5,
                                    Padding = 20,
                                    Children =
                                    {
                                        new Label
                                        {
                                            Text = "14.02 21:25",
                                            TextColor = Color.FromHex("#99CFEE"),
                                            FontSize = 12,
                                        },
                                        new Label
                                        {
                                            Text = "Saint Petersburg - Pulkovo",
                                            TextColor = Color.Black,
                                            FontSize = 17,
                                        },
                                        new Label
                                        {
                                            Text = "14.02 22:55",
                                            TextColor = Color.FromHex("#99CFEE"),
                                            FontSize = 12,
                                        },
                                        new Label
                                        {
                                            Text = "Moscow - Domodevo",
                                            TextColor = Color.Black,
                                            FontSize = 17,
                                        },
                                    }
                                },
                                new StackLayout
                                {
                                    Orientation = StackOrientation.Horizontal,
                                    Children =
                                    {
                                        new BoxView
                                        {
                                            Margin = 10,
                                            WidthRequest = 2,
                                            HeightRequest = 130,
                                            BackgroundColor = Color.FromHex("#99CFEE"),
                                            HorizontalOptions = LayoutOptions.EndAndExpand,
                                        },
                                        new StackLayout
                                        {
                                            HorizontalOptions = LayoutOptions.End,
                                            VerticalOptions = LayoutOptions.Center,
                                            Children =
                                            {
                                                new BoxView
                                                {
                                                    WidthRequest = 30,
                                                    HeightRequest = 2,
                                                    BackgroundColor = Color.FromHex("#6EBDEA"),
                                                },
                                                new BoxView
                                                {
                                                    WidthRequest = 30,
                                                    HeightRequest = 2,
                                                    BackgroundColor = Color.FromHex("#6EBDEA"),
                                                },
                                                new BoxView
                                                {
                                                    WidthRequest = 30,
                                                    HeightRequest = 2,
                                                    BackgroundColor = Color.FromHex("#6EBDEA"),
                                                },
                                                new BoxView
                                                {
                                                    WidthRequest = 30,
                                                    HeightRequest = 2,
                                                    BackgroundColor = Color.FromHex("#6EBDEA"),
                                                },
                                                new BoxView
                                                {
                                                    WidthRequest = 30,
                                                    HeightRequest = 2,
                                                    BackgroundColor = Color.FromHex("#6EBDEA"),
                                                },
                                                new BoxView
                                                {
                                                    WidthRequest = 30,
                                                    HeightRequest = 2,
                                                    BackgroundColor = Color.FromHex("#6EBDEA"),
                                                },
                                                new BoxView
                                                {
                                                    WidthRequest = 30,
                                                    HeightRequest = 2,
                                                    BackgroundColor = Color.FromHex("#6EBDEA"),
                                                },
                                                new BoxView
                                                {
                                                    WidthRequest = 30,
                                                    HeightRequest = 2,
                                                    BackgroundColor = Color.FromHex("#6EBDEA"),
                                                },
                                                new BoxView
                                                {
                                                    WidthRequest = 30,
                                                    HeightRequest = 2,
                                                    BackgroundColor = Color.FromHex("#6EBDEA"),
                                                },
                                                new BoxView
                                                {
                                                    WidthRequest = 30,
                                                    HeightRequest = 2,
                                                    BackgroundColor = Color.FromHex("#6EBDEA"),
                                                },
                                                new BoxView
                                                {
                                                    WidthRequest = 30,
                                                    HeightRequest = 2,
                                                    BackgroundColor = Color.FromHex("#6EBDEA"),
                                                },
                                                new BoxView
                                                {
                                                    WidthRequest = 30,
                                                    HeightRequest = 2,
                                                    BackgroundColor = Color.FromHex("#6EBDEA"),
                                                },
                                                new BoxView
                                                {
                                                    WidthRequest = 30,
                                                    HeightRequest = 2,
                                                    BackgroundColor = Color.FromHex("#6EBDEA"),
                                                },
                                                new BoxView
                                                {
                                                    WidthRequest = 30,
                                                    HeightRequest = 2,
                                                    BackgroundColor = Color.FromHex("#6EBDEA"),
                                                },


                                            }
                                        },
                                        new Label
                                        {
                                            Text = "KZN14MSC02D321",
                                            TextColor = Color.FromHex("#6EBDEA"),
                                            Rotation = -90,
                                            HorizontalOptions = LayoutOptions.EndAndExpand,
                                            VerticalOptions = LayoutOptions.End,
                                            FontSize = 13,
                                            LineBreakMode = LineBreakMode.NoWrap,
                                            MinimumWidthRequest = 120,
                                            AnchorX = 0,
                                            AnchorY = 0
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        VerticalOptions = LayoutOptions.Center,
                        HorizontalOptions = LayoutOptions.Center,
                        Children =
                        {
                            new BoxView
                            {
                                HeightRequest = 5,
                                WidthRequest = 5,
                                BackgroundColor = Color.FromHex("#99CFEE"),
                                CornerRadius = 5,
                            },
                            new BoxView
                            {
                                HeightRequest = 5,
                                WidthRequest = 5,
                                BackgroundColor = Color.White,
                                CornerRadius = 5,
                            },
                            new BoxView
                            {
                                HeightRequest = 5,
                                WidthRequest = 5,
                                BackgroundColor = Color.White,
                                CornerRadius = 5,
                            },
                            new BoxView
                            {
                                HeightRequest = 5,
                                WidthRequest = 5,
                                BackgroundColor = Color.White,
                                CornerRadius = 5,
                            },
                            new BoxView
                            {
                                HeightRequest = 5,
                                WidthRequest = 5,
                                BackgroundColor = Color.White,
                                CornerRadius = 5,
                            },
                            new BoxView
                            {
                                HeightRequest = 5,
                                WidthRequest = 5,
                                BackgroundColor = Color.White,
                                CornerRadius = 5,
                            },
                            new BoxView
                            {
                                HeightRequest = 5,
                                WidthRequest = 5,
                                BackgroundColor = Color.White,
                                CornerRadius = 5,
                            },
                            new BoxView
                            {
                                HeightRequest = 5,
                                WidthRequest = 5,
                                BackgroundColor = Color.White,
                                CornerRadius = 5,
                            },
                            new BoxView
                            {
                                HeightRequest = 5,
                                WidthRequest = 5,
                                BackgroundColor = Color.White,
                                CornerRadius = 5,
                            },
                            new BoxView
                            {
                                HeightRequest = 5,
                                WidthRequest = 5,
                                BackgroundColor = Color.White,
                                CornerRadius = 5,
                            },
                            new BoxView
                            {
                                HeightRequest = 5,
                                WidthRequest = 5,
                                BackgroundColor = Color.White,
                                CornerRadius = 5,
                            },
                            new BoxView
                            {
                                HeightRequest = 5,
                                WidthRequest = 5,
                                BackgroundColor = Color.White,
                                CornerRadius = 5,
                            },
                            new BoxView
                            {
                                HeightRequest = 5,
                                WidthRequest = 5,
                                BackgroundColor = Color.White,
                                CornerRadius = 5,
                            },

                        }
                    }
                }
            };
            Content = main;
        }

    }
}
