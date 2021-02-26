using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileBilet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();
            RelativeLayout menu = new RelativeLayout()
            {
                BackgroundColor = Color.FromHex("#080D17"),
            };

            BoxView circle1 = new BoxView
            {
                BackgroundColor = Color.FromHex("#FFFFFF")
            };
            BoxView circle2 = new BoxView
            {
                BackgroundColor = Color.FromHex("#FFFFFF")
            };
            BoxView circle3 = new BoxView
            {
                BackgroundColor = Color.FromHex("#FFFFFF"),
            };
            Frame ticket = new Frame
            {
                BackgroundColor = Color.FromHex("#EFF9FF")
            };
            menu.Children.Add(circle1, Constraint.RelativeToParent(r => r.Width - circle1.Width - 15),
            Constraint.RelativeToParent(r => 15),
            Constraint.RelativeToParent(r => r.Width * 0.01), Constraint.RelativeToParent(r =>
            {
                circle1.WidthRequest = r.Width * 0.05;
                circle1.HeightRequest = r.Height * 0.05;
                circle1.CornerRadius = r.Height * 0.05;
                return r.Height * 0.01;
            }));

            menu.Children.Add(circle2, Constraint.RelativeToParent(r =>
            {
                return r.Width - circle2.Width - 15;
            }),
            Constraint.RelativeToParent(r => circle2.Height + 16),
            Constraint.RelativeToParent(r => r.Width * 0.01), Constraint.RelativeToParent(r =>
            {
                circle2.WidthRequest = r.Width * 0.05;
                circle2.HeightRequest = r.Height * 0.05;
                circle2.CornerRadius = r.Height * 0.025;
                return r.Height * 0.01;
            }));

            menu.Children.Add(circle3, Constraint.RelativeToParent(r =>
            {
                return r.Width - circle3.Width - 15;
            }),
            Constraint.RelativeToParent(r => circle3.Height + circle3.Height + 17),
            Constraint.RelativeToParent(r => r.Width * 0.01), Constraint.RelativeToParent(r =>
            {
                circle3.WidthRequest = r.Width * 0.05;
                circle3.HeightRequest = r.Height * 0.05;
                circle3.CornerRadius = r.Height * 0.025;
                return r.Height * 0.01;
            }));
            Frame profile = new Frame()
            {
                Padding = new Thickness(0),
                BackgroundColor = Color.FromHex("#3C9DD4"),
                HasShadow = false,
                Content = new Label()
                {
                    FontSize = 16,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    Text = "Привет, Ильхам и Эмиль",
                    TextColor = Color.FromHex("#FFFFFF"),
                }
            };

            Frame ImageGearWheel = new Frame
            {
                Content = new Image { Source = "Vector.png" },
                BackgroundColor = Color.FromHex("#3C9DD4"),
                CornerRadius = 30,
                Margin = -30,
                HeightRequest = 20,
                WidthRequest = 20
            };
            menu.Children.Add(ImageGearWheel,
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Width * 0.05;
            }),
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Height * 0.05;
            }),
            Constraint.Constant(2),
            Constraint.Constant(2));
            menu.Children.Add(profile,
            Constraint.RelativeToParent(r => r.Width - profile.Width - 45),
            Constraint.RelativeToParent(r => 10),
            Constraint.RelativeToParent(r => r.Width * 0.3),
            Constraint.RelativeToParent(r =>
            {
                profile.WidthRequest = r.Width * 0.05;
                profile.HeightRequest = r.Height * 0.05;
                return r.Height * 0.05;
            }));
            // relative ticket
            //menu.Children.Add(ticket, Constraint.RelativeToParent(r => r.Width * 0.15),
            //    Constraint.RelativeToParent(r => r.Height * 0.2),
            //    Constraint.RelativeToParent(r => r.Width * 0.75),
            //    Constraint.RelativeToParent(r =>
            //    {
            //        ticket.WidthRequest = r.Width * 0.8;
            //        ticket.HeightRequest = r.Height * 0.2;
            //        return r.Height * 0.2;
            //    }));
            AbsoluteLayout absolute = new AbsoluteLayout();
            absolute.Children.Add(new Label
            {
                Text = "14.02 21:25",
                FontSize = 10,
                HorizontalOptions = LayoutOptions.Start,
                TextColor = Color.Black
            }, new Rectangle(0.4, 0.2, 0.85, 0.186), AbsoluteLayoutFlags.All);

            absolute.Children.Add(new Label
            {
                Text = "14.02 22:55",
                FontSize = 10,
                HorizontalOptions = LayoutOptions.Start,
                TextColor = Color.Black
            }, new Rectangle(0.4, 0.7, 0.85, 0.186), AbsoluteLayoutFlags.All);

            absolute.Children.Add(new Label
            {
                Text = "Saint Peterburg - Pulkovo",
                FontSize = 17,
                HorizontalOptions = LayoutOptions.Start,
                TextColor = Color.Black
            }, new Rectangle(0.4, 0.35, 0.85, 0.186), AbsoluteLayoutFlags.All);

            absolute.Children.Add(new Label
            {
                Text = "Moscow - Domodedovo",
                FontSize = 17,
                HorizontalOptions = LayoutOptions.Start,
                TextColor = Color.Black
            }, new Rectangle(0.4, 0.85, 0.85, 0.186), AbsoluteLayoutFlags.All);

            absolute.Children.Add(new BoxView 
            { BackgroundColor = Color.FromHex("99CFEE") },
            new Rectangle(0.7, 0.2, 0.005, 0.98), AbsoluteLayoutFlags.All);

            absolute.Children.Add(new Label
            {
                Text = "KZN14MSC02D321",
                FontSize = 11,
                TextColor = Color.Black,
                Rotation = 270,
            }, new Rectangle(0.99, 0.4, 0.1, 0.25), AbsoluteLayoutFlags.All);

            //absolute ticket
            menu.Children.Add(new Frame
            {
                BackgroundColor = Color.FromHex("EFF9FF"),
                CornerRadius = 10,
                Padding = 0,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                Content = absolute,
            }, 
            Constraint.RelativeToParent(r => r.Width * 0.15),
            Constraint.RelativeToParent(r => r.Height * 0.2),
            Constraint.RelativeToParent(r => r.Width * 0.75),
            Constraint.RelativeToParent(r =>
            {
                    ticket.WidthRequest = r.Width * 0.8;
                    ticket.HeightRequest = r.Height * 0.2;
                    return r.Height * 0.2;
             }));

            //RelativeLayout rl = new RelativeLayout();
            //Label flights1 = new Label()
            //{
            //    Text = "Saint Petersburg - Pulkovo",
            //    TextColor = Color.FromHex("#000000"),
            //};
            //rl.Children.Add(flights1, Constraint.RelativeToParent(r => r.Width * 0.05),
            //    Constraint.RelativeToParent(r => r.Height * 0.2),
            //    Constraint.RelativeToParent(r => r.Width * 0.3),
            //    Constraint.RelativeToParent(r => r.Height * 0.2));
            //ticket.Content = rl;
            this.Content = menu;

        }
    }
}
