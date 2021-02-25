﻿using System;
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
            rl.Children.Add(menu, Constraint.RelativeToParent(r => r.Width - menu.Width - 10), Constraint.RelativeToParent(r => r.Height * 0 + 10));

            BoxView circle1 = new BoxView
            {
                CornerRadius = 5,
                BackgroundColor = Color.Green,
            };
            BoxView circle2 = new BoxView
            {
                CornerRadius = 5,
                BackgroundColor = Color.Green,
            };
            BoxView circle3 = new BoxView
            {
                CornerRadius = 5,
                BackgroundColor = Color.Green,
            };
            Frame profile = new Frame
            {
                WidthRequest = 100,
                HeightRequest = 50,
                BackgroundColor = Color.Green,
            };
            menu.Children.Add(circle1, Constraint.RelativeToParent(r => r.Width - circle1.Width - 15), Constraint.RelativeToParent(r => r.Height * 0 + 15),
            Constraint.RelativeToParent(r => r.Height * 0.05), Constraint.RelativeToParent(r =>
            {
                circle1.WidthRequest = r.Width * 0.05;
                circle1.HeightRequest = r.Height * 0.05;
                circle1.CornerRadius = r.Height * 0.05;
                return r.Height * 0.05;
            }));
            menu.Children.Add(circle2, Constraint.RelativeToParent(r =>
            {
                return r.Width - circle2.Width - 15;
            }), Constraint.RelativeToParent(r => r.Height * 0 + circle1.Height + 25),
            Constraint.RelativeToParent(r => r.Height * 0.05), Constraint.RelativeToParent(r =>
            {
                circle2.WidthRequest = r.Width * 0.05;
                circle2.HeightRequest = r.Height * 0.05;
                circle2.CornerRadius = r.Height * 0.025;
                return r.Height * 0.05;
            }));
            menu.Children.Add(circle3, Constraint.RelativeToParent(r =>
            {
                return r.Width - circle3.Width - 15;
            }), Constraint.RelativeToParent(r => r.Height * 0 + circle2.Height + circle1.Height + 35),
            Constraint.RelativeToParent(r => r.Height * 0.05), Constraint.RelativeToParent(r =>
            {
                circle3.WidthRequest = r.Width * 0.05;
                circle3.HeightRequest = r.Height * 0.05;
                circle3.CornerRadius = r.Height * 0.025;
                return r.Height * 0.05;
            }));
            this.Content = rl;

        }
    }
}
