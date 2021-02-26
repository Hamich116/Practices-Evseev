using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms;
using Frame = Xamarin.Forms.Frame;
using Image = Xamarin.Forms.Image;

namespace MobileBilet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();
            RelativeLayout menu = new RelativeLayout()
            {
                BackgroundColor = Color.Black,
            };

            BoxView circle1 = new BoxView
            {
                BackgroundColor = Color.White,
            };

            BoxView circle2 = new BoxView
            {
                BackgroundColor = Color.White,
            };

            BoxView circle3 = new BoxView
            {
                BackgroundColor = Color.White,
            };

            Frame profile = new Frame()
            {
                Padding = new Thickness(0),
                BackgroundColor = Color.FromHex("#3C9DD4"),
                HasShadow = false,
                Content = new Label()
                {
                    FontSize = 10,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    Text = "Привет, Вилен",
                    TextColor = Color.FromHex("#FFFFFF"),
                }
            };

            Frame ImageGearWheel = new Frame
            {
                Content = new ImageButton { Source = "Vector.png" },
                BackgroundColor = Color.FromHex("#3C9DD4"),
                CornerRadius = 90,
                Padding = 10,
                HeightRequest = 3,
                WidthRequest = 3,
            };

            menu.Children.Add(circle1, Constraint.RelativeToParent(r => r.Width - circle1.Width - 15),
                Constraint.RelativeToParent(r => r.Height * 0 + 15),
                Constraint.RelativeToParent(r => r.Width * 0.01),
                Constraint.RelativeToParent(r =>
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
            Constraint.RelativeToParent(r => r.Height * 0 + circle1.Height + 15),
            Constraint.RelativeToParent(r => r.Width * 0.01), 
            Constraint.RelativeToParent(r =>
            {
                circle2.WidthRequest = r.Width * 0.05;
                circle2.HeightRequest = r.Height * 0.05;
                circle2.CornerRadius = r.Height * 0.05;
                return r.Height * 0.01;
            }));

            menu.Children.Add(circle3, Constraint.RelativeToParent(r =>
            {
                return r.Width - circle3.Width - 15;
            }),
            Constraint.RelativeToParent(r => r.Height * 0  + circle1.Height + circle2.Height + 15),
            Constraint.RelativeToParent(r => r.Width * 0.01), Constraint.RelativeToParent(r =>
            {
                circle3.WidthRequest = r.Width * 0.05;
                circle3.HeightRequest = r.Height * 0.05;
                circle3.CornerRadius = r.Height * 0.05;
                return r.Height * 0.01;
            }));

            menu.Children.Add(profile, Constraint.RelativeToParent(r => r.Width - profile.Width - 30),
                Constraint.RelativeToParent(r => r.Height * 0 + 10),
                Constraint.RelativeToParent(r => r.Width * 0.3),
                Constraint.RelativeToParent(r =>
                {
                    profile.WidthRequest = r.Width * 0.05;
                    profile.HeightRequest = r.Height * 0.05;
                    return r.Height * 0.05;
                }));

            menu.Children.Add(ImageGearWheel,
            Constraint.RelativeToParent(r =>
            {
                return r.Width * 0.01;
            }),
            Constraint.RelativeToParent(r =>
            {
                return r.Height * 0.01;
            }),
            Constraint.RelativeToParent(r => 
            {
                return r.Width * 0.06;
            }),
            Constraint.RelativeToParent(r => 
            {
                return r.Width * 0.06;
            }));

            Content = menu;

        }
    }
}
