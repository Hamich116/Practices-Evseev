using System;
using static AirDataSource.AirDataSource;
using AirModel;
using AirDataSource;
using System.Linq;

namespace GroupedAirLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.1"); // ГОТОВ 

            var groupCitizenship = from client in Clients
                                   orderby client.Citizenship,client.LastName,client.FirstName
                                   group client by client.Citizenship;
            foreach (var citizen in groupCitizenship)
            {
                Console.WriteLine(citizen.Key);
                foreach (var client in citizen)
                {
                    Console.WriteLine($" {client.LastName} {client.FirstName}");
                }
            }

            Console.WriteLine("1.2"); // ГОТОВ 

            var groupCitezenship1 = (Clients.OrderBy(c => c.Citizenship)).ThenBy(c => c.LastName).ThenBy(c => c.FirstName).GroupBy(a => a.Citizenship);
            foreach (var citizen in groupCitezenship1)
            {
                Console.WriteLine(citizen.Key);
                foreach (var client in citizen)
                {
                    Console.WriteLine($" {client.LastName} {client.FirstName}");
                }
            }

            Console.WriteLine("2.1");
            var groupTicketViaRow = from ticket in Tickets
                                     orderby ticket.Cost
                                     group ticket by ticket.Row;
            var groupTicketViaPlace = from ticket in groupTicketViaRow
                                    select new
                                    {
                                        ticket.Key,
                                        groupTicket = from ticketPlace in ticket
                                                      group ticketPlace by ticketPlace.Place
                                    };
            foreach (var row in groupTicketViaPlace)
            {
                Console.WriteLine("Ряд: " + row.Key);
                foreach (var place in row.groupTicket)
                {
                    Console.WriteLine("Место: " + place.Key);
                    foreach (var ticket in place)
                    {
                        Console.WriteLine($"Id: {ticket.Id}, Cost: {ticket.Cost}, IdFlight: {ticket.FlightId}");
                    }
                }
            }
            Console.WriteLine("2.2");
            var groupTicketViaPlace1 = Tickets.OrderBy(ticket => ticket.Cost).GroupBy(ticket => ticket.Row).Select(ticket => new
            {
                ticket.Key,
                groupPlace = ticket.GroupBy(t => t.Place)
            });

            foreach (var row in groupTicketViaPlace1)
            {
                Console.WriteLine("Ряд: " + row.Key);
                foreach (var place in row.groupPlace)
                {
                    Console.WriteLine("Место: " + place.Key);
                    foreach (var ticket in place)
                    {
                        Console.WriteLine($"Id: {ticket.Id}, Cost: {ticket.Cost}, IdFlight: {ticket.FlightId}");
                    }
                }
            }
        }
    }
}
