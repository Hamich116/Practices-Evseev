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
                BackgroundColor = Color.Red,
            };
            RelativeLayout rl = new RelativeLayout()
            {
                BackgroundColor = Color.Blue,
            };
            rl.Children.Add(menu, Constraint.Constant(30));

            BoxView circle1 = new BoxView
            {
                WidthRequest = 10,
                HeightRequest = 10,
                CornerRadius = 5,
                BackgroundColor = Color.Green,
            };
            BoxView circle2 = new BoxView
            {
                WidthRequest = 10,
                HeightRequest = 10,
                CornerRadius = 5,
                BackgroundColor = Color.Green,
            };
            BoxView circle3 = new BoxView
            {
                WidthRequest = 10,
                HeightRequest = 10,
                CornerRadius = 5,
                BackgroundColor = Color.Green,
            };
            menu.Children.Add(circle1, Constraint.RelativeToParent(r => r.Height));
            menu.Children.Add(circle2, Constraint.RelativeToView(circle1, (parent, sibling) =>
            {
                return Height * 0;
            }), Constraint.RelativeToView(circle1, (parent, sibling) =>
            {
                return circle1.Width;
            }),
            Constraint.RelativeToView(circle1, (parent, sibling) =>
            {
                return circle2.WidthRequest;
            }), 
            Constraint.RelativeToView(circle1, (parent, sibling) =>
            {
                return circle2.HeightRequest;
            }));
            menu.Children.Add(circle3, Constraint.RelativeToView(circle2, (parent, sibling) =>
            {
                return Height * 0;
            }), Constraint.RelativeToView(circle1, (parent, sibling) =>
            {
                return circle2.Height * 2;
            }),
            Constraint.RelativeToView(circle1, (parent, sibling) =>
            {
                return circle3.WidthRequest;
            }),
            Constraint.RelativeToView(circle1, (parent, sibling) =>
            {
                return circle3.HeightRequest;
            }));
            this.Content = rl;






        }
    }
}
