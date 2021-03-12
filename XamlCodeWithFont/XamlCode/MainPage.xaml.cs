using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamlCode
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var tickets = new List<Ticket>
            {
                new Ticket
                {
                    DepartureCity = "Saint - Petersburg - Pulkovo",
                    DepartureDate = "14.02 21:25",
                    ArrivalCity = "Moscow - Domodedovo",
                    ArrivalDate = "14.02 22:55"
                },
                new Ticket
                {
                    DepartureCity = "Kazan - KazanAirport",
                    DepartureDate = "15.02 21:25",
                    ArrivalCity = "Moscow - Domodedovo",
                    ArrivalDate = "15.02 22:55"
                },
                new Ticket
                {
                    DepartureCity = "Saint - Petersburg - Pulkovo",
                    DepartureDate = "17.02 21:15",
                    ArrivalCity = "Orenburg - OrenburgAirport",
                    ArrivalDate = "17.02 00:00"
                },
                new Ticket
                {
                    DepartureCity = "Saint - Petersburg - Pulkovo",
                    DepartureDate = "18.02 15:25",
                    ArrivalCity = "Ishevsk - IshevskAirport",
                    ArrivalDate = "18.02 17:25"
                },
                new Ticket
                {
                    DepartureCity = "Saint - Petersburg - Pulkovo",
                    DepartureDate = "18.02 21:25",
                    ArrivalCity = "Krasnodar - KrasnodarAirport",
                    ArrivalDate = "18.02 22:55"
                },
                new Ticket
                {
                    DepartureCity = "Saint - Petersburg - Pulkovo",
                    DepartureDate = "16.02 21:25",
                    ArrivalCity = "Kazan - KazanAirport",
                    ArrivalDate = "16.02 22:55"
                },
                new Ticket
                {
                    DepartureCity = "Saint - Petersburg - Pulkovo",
                    DepartureDate = "16.02 21:25",
                    ArrivalCity = "Kazan - KazanAirport",
                    ArrivalDate = "16.02 22:55"
                },
                new Ticket
                {
                    DepartureCity = "Saint - Petersburg - Pulkovo",
                    DepartureDate = "16.02 21:25",
                    ArrivalCity = "Kazan - KazanAirport",
                    ArrivalDate = "16.02 22:55"
                },
            };

            var Recognizer = new TapGestureRecognizer();
            Recognizer.Tapped += (s, e) =>
            {
                DisplayAlert("Информация", "Было нажато на кнопку", "ОК");
            };

            TapGestureRecognizer Settings = new TapGestureRecognizer();
            Settings.Tapped += Click_Settings;

            async void Click_Settings(object sender, EventArgs e)
            {
                await DisplayAlert("Настройки",
                " Яркость - 10 \n Гамма - 10 \n Прорисовка - 10", "OK");
            }

            TapGestureRecognizer PlaneLeft = new TapGestureRecognizer();
            PlaneLeft.Tapped += Click_leftPlane;

            async void Click_leftPlane(object sender, EventArgs e)
            {
                await DisplayAlert("Режимы полета", "Вы включили режим left", "ОК");
            }

            TapGestureRecognizer PlaneRight = new TapGestureRecognizer();
            PlaneRight.Tapped += Click_rightPlane;

            async void Click_rightPlane(object sender, EventArgs e)
            {
                await DisplayAlert("Режим полета", "Вы включили режим right", "OK");
            }

            TapGestureRecognizer PlayerInfo = new TapGestureRecognizer();
            PlayerInfo.Tapped += Click_playerInfo;

            async void Click_playerInfo(object sender, EventArgs e)
            {
                await DisplayAlert("Информация", "Имя - Эмиль \nВозраст - 19 \nИмя - Ильхам \nВозраст - 18", "ОК");
            }

            TapGestureRecognizer Ticket_Scroll = new TapGestureRecognizer();
            Ticket_Scroll.Tapped += Click_Ticket_Scroll;

            async void Click_Ticket_Scroll(object sender, EventArgs e)
            {
                await DisplayAlert("Билет", "Вы Нажали на билет 'KMP-MSC'", "ОК");
            }

            TapGestureRecognizer Ticket_Scroll1 = new TapGestureRecognizer();
            Ticket_Scroll1.Tapped += Click_Ticket_Scroll1;

            async void Click_Ticket_Scroll1(object sender, EventArgs e)
            {
                await DisplayAlert("Билет", "Вы нажали 'SPB-MSC'", "ОК");
            }

            TapGestureRecognizer ticketSecond1 = new TapGestureRecognizer();
            ticketSecond1.Tapped += SecondTicket1;

            async void SecondTicket1(object sender, EventArgs e)
            {
                await DisplayPromptAsync("Было летали", "Дата 22-12 \nОткуда - KZN \nКуда - MSC ","Сохранить", "Отмена", "Цена - ", 7);
            }

            TapGestureRecognizer ticketSecond2 = new TapGestureRecognizer();
            ticketSecond2.Tapped += SecondTicket2;
            async void SecondTicket2(object sender, EventArgs e)
            {
                await DisplayAlert("Было летали", "Описание", "ОК");
            }

            Carusel.ItemsSource = tickets;
            Gear.GestureRecognizers.Add(Settings);
            profile.GestureRecognizers.Add(PlayerInfo);
            threePoints.GestureRecognizers.Add(Recognizer);
            rightPlane.GestureRecognizers.Add(PlaneRight);
            KMPMSC.GestureRecognizers.Add(Ticket_Scroll);
            SPBMSC1.GestureRecognizers.Add(Ticket_Scroll1);
            SPBMSC2.GestureRecognizers.Add(Ticket_Scroll1);
            SPBMSC3.GestureRecognizers.Add(Ticket_Scroll1);
            SPBMSC4.GestureRecognizers.Add(Ticket_Scroll1);
            SPBMSC5.GestureRecognizers.Add(Ticket_Scroll1);
            SPBMSC6.GestureRecognizers.Add(Ticket_Scroll1);
            leftPlane.GestureRecognizers.Add(PlaneLeft);
            tick1.GestureRecognizers.Add(ticketSecond1);
            tick2.GestureRecognizers.Add(ticketSecond2);
            tick3.GestureRecognizers.Add(ticketSecond2);
            tick3.GestureRecognizers.Add(ticketSecond2);
            tick4.GestureRecognizers.Add(ticketSecond2);
            tick5.GestureRecognizers.Add(ticketSecond2);
            tick6.GestureRecognizers.Add(ticketSecond2);
            tick7.GestureRecognizers.Add(ticketSecond2);
            tick8.GestureRecognizers.Add(ticketSecond2);
            tick9.GestureRecognizers.Add(ticketSecond2);
            tick10.GestureRecognizers.Add(ticketSecond2);
            tick11.GestureRecognizers.Add(ticketSecond2);
            tick12.GestureRecognizers.Add(ticketSecond2);
            tick13.GestureRecognizers.Add(ticketSecond2);
            tick14.GestureRecognizers.Add(ticketSecond2);
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await DisplayAlert("Билет", "Важная информация", "ОК");
        }
    }
}
