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
            menu.Children.Add(circle1, Constraint.RelativeToParent(r => r.Width - circle1.Width - 15), Constraint.RelativeToParent(r => r.Height * 0 + 15),
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
            Constraint.RelativeToParent(r => r.Height * 0 + circle2.Height + 16),
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
            Constraint.RelativeToParent(r => r.Height * 0 + circle3.Height + circle3.Height + 18),
            Constraint.RelativeToParent(r => r.Width * 0.01), Constraint.RelativeToParent(r =>
            {
                circle3.WidthRequest = r.Width * 0.05;
                circle3.HeightRequest = r.Height * 0.05;
                circle3.CornerRadius = r.Height * 0.025;
                return r.Height * 0.01;
            }));
            menu.Children.Add(ticket, Constraint.RelativeToParent(r => r.Width * 0.15),
                Constraint.RelativeToParent(r => r.Height * 0.2),
                Constraint.RelativeToParent(r => r.Width * 0.75),
                Constraint.RelativeToParent(r =>
                {
                    ticket.WidthRequest = r.Width * 0.8;
                    ticket.HeightRequest = r.Height * 0.2;
                    return r.Height * 0.2;
                }));
            RelativeLayout rl = new RelativeLayout();
            Label flights1 = new Label()
            {
                Text = "Saint Petersburg - Pulkovo",
                TextColor = Color.FromHex("#000000"),
            };
            rl.Children.Add(flights1, Constraint.RelativeToParent(r => r.Width * 0.05),
                Constraint.RelativeToParent(r => r.Height * 0.2),
                Constraint.RelativeToParent(r => r.Width * 0.3),
                Constraint.RelativeToParent(r => r.Height * 0.2));
            ticket.Content = rl;
            this.Content = menu;

        }
    }
}
