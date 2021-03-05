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
            Label Super = new Label
            {
                Text = "KZN14MSC02D321",
                TextColor = Color.FromHex("#6EBDEA"),
                HorizontalOptions = LayoutOptions.EndAndExpand,
                VerticalOptions = LayoutOptions.End,
                FontSize = 13,
                MinimumWidthRequest = 120,
                LineBreakMode = LineBreakMode.NoWrap,

                AnchorX = 0,
                AnchorY = 0,
            };
            Super.RotateTo(-90, 0);
            ScrollView fake = new ScrollView
            {
                Orientation = ScrollOrientation.Neither,
                HorizontalScrollBarVisibility = ScrollBarVisibility.Never,
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
                                        Super,
                                    }
                                }
                    }
                }
            };
            
            StackLayout main = new StackLayout
            {
                Spacing = 0,
                
                BackgroundColor = Color.FromHex("#080D17"),
                Children =
                {
                    new StackLayout
                    {
                        Padding = 20,
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
                                HasShadow = false,
                                Content = new Image
                                {
                                    Scale = 1,
                                    Source = "Vector.png",
                                    HorizontalOptions = LayoutOptions.Center,
                                    VerticalOptions = LayoutOptions.Center,
                                }
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
                        Padding = new Thickness(20,10,20,20),
                        Spacing = 30,
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
                                BackgroundColor = Color.FromHex("#F6FEFF"),
                                CornerRadius = 90,
                                Padding = 0,
                                HeightRequest = 50,
                                WidthRequest = 50,
                                Content = new Image
                                {
                                    Scale = 1,
                                    Source = "plane.png",
                                    HorizontalOptions = LayoutOptions.Center,
                                    VerticalOptions = LayoutOptions.Center,
                                }
                            }
                        }
                    },
                    new ScrollView
                    {
                        Orientation = ScrollOrientation.Horizontal,
                        HorizontalScrollBarVisibility = ScrollBarVisibility.Never,

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
                                    HeightRequest = 40,
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
                                    HeightRequest = 40,
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
                                    HeightRequest = 40,
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
                                    HeightRequest = 40,
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
                                    HeightRequest = 40,
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
                                    HeightRequest = 40,
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

                        Margin = 15,
                        Padding = 20,
                        HeightRequest = 140,
                        CornerRadius = 15,
                        Content = fake,
                    },
                    new StackLayout
                    {
                        Padding = 15,
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
                    },
                    new StackLayout
                    {

                        Orientation = StackOrientation.Horizontal,
                        Padding = new Thickness(40,10,40,10),
                        Spacing = 10,
                        Children =
                        {
                            new Label
                            {

                                TextColor = Color.White,
                                Text = "Было - летали",
                                HorizontalOptions = LayoutOptions.Start,
                                VerticalOptions = LayoutOptions.Center,
                                FontSize = 27
                            },
                            new Frame
                            {
                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                VerticalOptions = LayoutOptions.Center,
                                BackgroundColor = Color.FromHex("#F6FEFF"),
                                CornerRadius = 90,
                                Padding = 0,
                                HeightRequest = 50,
                                WidthRequest = 50,
                                Content = new Image
                                {
                                    Scale = 1,
                                    Source = "planereverse.png",
                                    HorizontalOptions = LayoutOptions.Center,
                                    VerticalOptions = LayoutOptions.Center,
                                }
                            }
                        }
                    },
                    new StackLayout
                        {
                            Padding = 20,
                            Spacing = 25,
                            Children =
                            {
                                new Frame
                                {
                                    Padding = 10,
                                    WidthRequest = 300,
                                    HeightRequest = 30,
                                    CornerRadius = 30,
                                    BackgroundColor = Color.FromHex("#3C9DD4"),
                                    Content = new StackLayout
                                    {
                                        Padding = 5,
                                        Spacing = 15,
                                        Orientation = StackOrientation.Horizontal,
                                        Children =
                                        {
                                            new Label
                                            {
                                                Text = "22.12",
                                                HorizontalOptions = LayoutOptions.Start,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new BoxView
                                            {
                                                HeightRequest = 5,
                                                WidthRequest = 5,
                                                CornerRadius = 5,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                BackgroundColor = Color.White,
                                            },
                                            new Label
                                            {
                                                Text = "KZN",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Image
                                            {
                                                Source = "strelka.png",
                                                Scale = 1,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,

                                            },
                                            new Label
                                            {
                                                Text = "MSC",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Label
                                            {
                                                Text = "9999 руб.",
                                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            }
                                        }
                                    }

                                },
                                new Frame
                                {
                                    Padding = 10,
                                    WidthRequest = 300,
                                    HeightRequest = 30,
                                    CornerRadius = 30,
                                    BackgroundColor = Color.FromHex("#3C9DD4"),
                                    Content = new StackLayout
                                    {
                                        Padding = 5,
                                        Spacing = 15,
                                        Orientation = StackOrientation.Horizontal,
                                        Children =
                                        {
                                            new Label
                                            {
                                                Text = "04.12",
                                                HorizontalOptions = LayoutOptions.Start,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new BoxView
                                            {
                                                HeightRequest = 5,
                                                WidthRequest = 5,
                                                CornerRadius = 5,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                BackgroundColor = Color.White,
                                            },
                                            new Label
                                            {
                                                Text = "IZH",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Image
                                            {
                                                Source = "strelkareverse.png",
                                                Scale = 1,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,

                                            },
                                            new Label
                                            {
                                                Text = "SPB",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Label
                                            {
                                                Text = "7122 руб.",
                                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            }
                                        }
                                    }

                                },
                                new Frame
                                {
                                    Padding = 10,
                                    WidthRequest = 300,
                                    HeightRequest = 30,
                                    CornerRadius = 30,
                                    BackgroundColor = Color.FromHex("#3C9DD4"),
                                    Content = new StackLayout
                                    {
                                        Padding = 5,
                                        Spacing = 15,
                                        Orientation = StackOrientation.Horizontal,
                                        Children =
                                        {
                                            new Label
                                            {
                                                Text = "03.12",
                                                HorizontalOptions = LayoutOptions.Start,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new BoxView
                                            {
                                                HeightRequest = 5,
                                                WidthRequest = 5,
                                                CornerRadius = 5,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                BackgroundColor = Color.White,
                                            },
                                            new Label
                                            {
                                                Text = "IZH",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Image
                                            {
                                                Source = "strelka.png",
                                                Scale = 1,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,

                                            },
                                            new Label
                                            {
                                                Text = "SPB",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Label
                                            {
                                                Text = "7126 руб.",
                                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            }
                                        }
                                    }

                                },
                                new Frame
                                {
                                    Padding = 10,
                                    WidthRequest = 300,
                                    HeightRequest = 30,
                                    CornerRadius = 30,
                                    BackgroundColor = Color.FromHex("#3C9DD4"),
                                    Content = new StackLayout
                                    {
                                        Padding = 5,
                                        Spacing = 15,
                                        Orientation = StackOrientation.Horizontal,
                                        Children =
                                        {
                                            new Label
                                            {
                                                Text = "10.11",
                                                HorizontalOptions = LayoutOptions.Start,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new BoxView
                                            {
                                                HeightRequest = 5,
                                                WidthRequest = 5,
                                                CornerRadius = 5,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                BackgroundColor = Color.White,
                                            },
                                            new Label
                                            {
                                                Text = "MSC",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Image
                                            {
                                                Source = "strelka.png",
                                                Scale = 1,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,

                                            },
                                            new Label
                                            {
                                                Text = "LON",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Label
                                            {
                                                Text = "2122 руб.",
                                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            }
                                        }
                                    }

                                },
                                new Frame
                                {
                                    Padding = 10,
                                    WidthRequest = 300,
                                    HeightRequest = 30,
                                    CornerRadius = 30,
                                    BackgroundColor = Color.FromHex("#3C9DD4"),
                                    Content = new StackLayout
                                    {
                                        Padding = 5,
                                        Spacing = 15,
                                        Orientation = StackOrientation.Horizontal,
                                        Children =
                                        {
                                            new Label
                                            {
                                                Text = "07.10",
                                                HorizontalOptions = LayoutOptions.Start,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new BoxView
                                            {
                                                HeightRequest = 5,
                                                WidthRequest = 5,
                                                CornerRadius = 5,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                BackgroundColor = Color.White,
                                            },
                                            new Label
                                            {
                                                Text = "MSC",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Image
                                            {
                                                Source = "strelka.png",
                                                Scale = 1,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,

                                            },
                                            new Label
                                            {
                                                Text = "ANT",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Label
                                            {
                                                Text = "12050 руб.",
                                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            }
                                        }
                                    }

                                },
                                new Frame
                                {
                                    Padding = 10,
                                    WidthRequest = 300,
                                    HeightRequest = 30,
                                    CornerRadius = 30,
                                    BackgroundColor = Color.FromHex("#3C9DD4"),
                                    Content = new StackLayout
                                    {
                                        Padding = 5,
                                        Spacing = 15,
                                        Orientation = StackOrientation.Horizontal,
                                        Children =
                                        {
                                            new Label
                                            {
                                                Text = "14.09",
                                                HorizontalOptions = LayoutOptions.Start,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new BoxView
                                            {
                                                HeightRequest = 5,
                                                WidthRequest = 5,
                                                CornerRadius = 5,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                BackgroundColor = Color.White,
                                            },
                                            new Label
                                            {
                                                Text = "ANT",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Image
                                            {
                                                Source = "strelka.png",
                                                Scale = 1,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,

                                            },
                                            new Label
                                            {
                                                Text = "MSC",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Label
                                            {
                                                Text = "8182 руб.",
                                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            }
                                        }
                                    }

                                },
                                new Frame
                                {
                                    Padding = 10,
                                    WidthRequest = 300,
                                    HeightRequest = 30,
                                    CornerRadius = 30,
                                    BackgroundColor = Color.FromHex("#3C9DD4"),
                                    Content = new StackLayout
                                    {
                                        Padding = 5,
                                        Spacing = 15,
                                        Orientation = StackOrientation.Horizontal,
                                        Children =
                                        {
                                            new Label
                                            {
                                                Text = "04.12",
                                                HorizontalOptions = LayoutOptions.Start,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new BoxView
                                            {
                                                HeightRequest = 5,
                                                WidthRequest = 5,
                                                CornerRadius = 5,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                BackgroundColor = Color.White,
                                            },
                                            new Label
                                            {
                                                Text = "IZH",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Image
                                            {
                                                Source = "strelkareverse.png",
                                                Scale = 1,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,

                                            },
                                            new Label
                                            {
                                                Text = "SPB",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Label
                                            {
                                                Text = "7122 руб.",
                                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            }
                                        }
                                    }

                                },
                                new Frame
                                {
                                    Padding = 10,
                                    WidthRequest = 300,
                                    HeightRequest = 30,
                                    CornerRadius = 30,
                                    BackgroundColor = Color.FromHex("#3C9DD4"),
                                    Content = new StackLayout
                                    {
                                        Padding = 5,
                                        Spacing = 15,
                                        Orientation = StackOrientation.Horizontal,
                                        Children =
                                        {
                                            new Label
                                            {
                                                Text = "04.12",
                                                HorizontalOptions = LayoutOptions.Start,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new BoxView
                                            {
                                                HeightRequest = 5,
                                                WidthRequest = 5,
                                                CornerRadius = 5,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                BackgroundColor = Color.White,
                                            },
                                            new Label
                                            {
                                                Text = "IZH",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Image
                                            {
                                                Source = "strelkareverse.png",
                                                Scale = 1,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,

                                            },
                                            new Label
                                            {
                                                Text = "SPB",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Label
                                            {
                                                Text = "7122 руб.",
                                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            }
                                        }
                                    }

                                },
                                new Frame
                                {
                                    Padding = 10,
                                    WidthRequest = 300,
                                    HeightRequest = 30,
                                    CornerRadius = 30,
                                    BackgroundColor = Color.FromHex("#3C9DD4"),
                                    Content = new StackLayout
                                    {
                                        Padding = 5,
                                        Spacing = 15,
                                        Orientation = StackOrientation.Horizontal,
                                        Children =
                                        {
                                            new Label
                                            {
                                                Text = "04.12",
                                                HorizontalOptions = LayoutOptions.Start,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new BoxView
                                            {
                                                HeightRequest = 5,
                                                WidthRequest = 5,
                                                CornerRadius = 5,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                BackgroundColor = Color.White,
                                            },
                                            new Label
                                            {
                                                Text = "IZH",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Image
                                            {
                                                Source = "strelkareverse.png",
                                                Scale = 1,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,

                                            },
                                            new Label
                                            {
                                                Text = "SPB",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Label
                                            {
                                                Text = "7122 руб.",
                                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            }
                                        }
                                    }

                                },
                                new Frame
                                {
                                    Padding = 10,
                                    WidthRequest = 300,
                                    HeightRequest = 30,
                                    CornerRadius = 30,
                                    BackgroundColor = Color.FromHex("#3C9DD4"),
                                    Content = new StackLayout
                                    {
                                        Padding = 5,
                                        Spacing = 15,
                                        Orientation = StackOrientation.Horizontal,
                                        Children =
                                        {
                                            new Label
                                            {
                                                Text = "04.12",
                                                HorizontalOptions = LayoutOptions.Start,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new BoxView
                                            {
                                                HeightRequest = 5,
                                                WidthRequest = 5,
                                                CornerRadius = 5,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                BackgroundColor = Color.White,
                                            },
                                            new Label
                                            {
                                                Text = "IZH",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Image
                                            {
                                                Source = "strelkareverse.png",
                                                Scale = 1,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,

                                            },
                                            new Label
                                            {
                                                Text = "SPB",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Label
                                            {
                                                Text = "7122 руб.",
                                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            }
                                        }
                                    }

                                },
                                new Frame
                                {
                                    Padding = 10,
                                    WidthRequest = 300,
                                    HeightRequest = 30,
                                    CornerRadius = 30,
                                    BackgroundColor = Color.FromHex("#3C9DD4"),
                                    Content = new StackLayout
                                    {
                                        Padding = 5,
                                        Spacing = 15,
                                        Orientation = StackOrientation.Horizontal,
                                        Children =
                                        {
                                            new Label
                                            {
                                                Text = "04.12",
                                                HorizontalOptions = LayoutOptions.Start,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new BoxView
                                            {
                                                HeightRequest = 5,
                                                WidthRequest = 5,
                                                CornerRadius = 5,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                BackgroundColor = Color.White,
                                            },
                                            new Label
                                            {
                                                Text = "IZH",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Image
                                            {
                                                Source = "strelkareverse.png",
                                                Scale = 1,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,

                                            },
                                            new Label
                                            {
                                                Text = "SPB",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Label
                                            {
                                                Text = "7122 руб.",
                                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            }
                                        }
                                    }

                                },
                                new Frame
                                {
                                    Padding = 10,
                                    WidthRequest = 300,
                                    HeightRequest = 30,
                                    CornerRadius = 30,
                                    BackgroundColor = Color.FromHex("#3C9DD4"),
                                    Content = new StackLayout
                                    {
                                        Padding = 5,
                                        Spacing = 15,
                                        Orientation = StackOrientation.Horizontal,
                                        Children =
                                        {
                                            new Label
                                            {
                                                Text = "04.12",
                                                HorizontalOptions = LayoutOptions.Start,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new BoxView
                                            {
                                                HeightRequest = 5,
                                                WidthRequest = 5,
                                                CornerRadius = 5,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                BackgroundColor = Color.White,
                                            },
                                            new Label
                                            {
                                                Text = "IZH",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Image
                                            {
                                                Source = "strelkareverse.png",
                                                Scale = 1,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,

                                            },
                                            new Label
                                            {
                                                Text = "SPB",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Label
                                            {
                                                Text = "7122 руб.",
                                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            }
                                        }
                                    }

                                },
                                new Frame
                                {
                                    Padding = 10,
                                    WidthRequest = 300,
                                    HeightRequest = 30,
                                    CornerRadius = 30,
                                    BackgroundColor = Color.FromHex("#3C9DD4"),
                                    Content = new StackLayout
                                    {
                                        Padding = 5,
                                        Spacing = 15,
                                        Orientation = StackOrientation.Horizontal,
                                        Children =
                                        {
                                            new Label
                                            {
                                                Text = "04.12",
                                                HorizontalOptions = LayoutOptions.Start,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new BoxView
                                            {
                                                HeightRequest = 5,
                                                WidthRequest = 5,
                                                CornerRadius = 5,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                BackgroundColor = Color.White,
                                            },
                                            new Label
                                            {
                                                Text = "IZH",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Image
                                            {
                                                Source = "strelkareverse.png",
                                                Scale = 1,
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,

                                            },
                                            new Label
                                            {
                                                Text = "SPB",
                                                HorizontalOptions = LayoutOptions.Center,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            },
                                            new Label
                                            {
                                                Text = "7122 руб.",
                                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                                VerticalOptions = LayoutOptions.Center,
                                                TextColor = Color.White,
                                                FontSize = 16,
                                            }
                                        }
                                    }

                                },


                            }
                        }
                    }
            };
            ScrollView scroll = new ScrollView
            {
                Content = main
            };
            
            Content = scroll;
        }
         

    }
}
