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
            Console.WriteLine("1.1");

            var groupCitizenship = from client in Clients
                                   orderby client.LastName, client.FirstName
                                   group client by client.Citizenship;
            foreach (var citizen in groupCitizenship)
            {
                Console.WriteLine(citizen.Key);
                foreach (var client in citizen)
                {
                    Console.WriteLine($" {client.LastName} {client.FirstName}");
                }
            }
            Console.WriteLine("///////////////////////////////////////////////");
            Console.WriteLine("1.2");

            var groupCitezenship1 = Clients.OrderBy(c => c.LastName).ThenBy(c => c.FirstName).GroupBy(a => a.Citizenship);
            foreach (var citizen in groupCitezenship1)
            {
                Console.WriteLine(citizen.Key);
                foreach (var client in citizen)
                {
                    Console.WriteLine($" {client.LastName} {client.FirstName}");
                }
            }
            Console.WriteLine("///////////////////////////////////////////////");
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
            Console.WriteLine("///////////////////////////////////////////////");
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
            Console.WriteLine("///////////////////////////////////////////////");
            Console.WriteLine("3.1");

            int n = 1000;
            var groupReadyFlyPlane = from countPlaneHours in Planes
                                     where countPlaneHours.FlightHours < n
                                     select countPlaneHours;
            var groupReadyIsFly = from groupReady in groupReadyFlyPlane
                                  group groupReady by groupReady.IsFlyReady;
                                  

            foreach (var ready in groupReadyIsFly)
            {
                Console.WriteLine(ready.Key);   
                foreach (var plane in ready)
                {
                        Console.WriteLine($"Name plane - {plane.ModelName}");
                }
            }
            Console.WriteLine("///////////////////////////////////////////////");
            Console.WriteLine("3.2");

            var groupReadyIsFly1 = Planes.Where(p => p.FlightHours < n).GroupBy(f => f.IsFlyReady);
            foreach (var ready in groupReadyIsFly1)
            {
                Console.WriteLine(ready.Key);
                foreach (var plane in ready)
                {
                    Console.WriteLine($"Name plane - {plane.ModelName}");
                }
            }
            //Не сделано.
            //Console.WriteLine("4.1");

            //var allInfo = (from flightcrew in FlightCrews
            //               group flightcrew by flightcrew.FlightId into f
            //               {
            //                   f.Key,
            //                   GroupedEmp = from flightcrew in f
            //                                group flightcrew.FlightId by f
            //               }).ToList();
            //foreach (var item in allInfo)
            //{
            //    Console.WriteLine("Рейс: " + item.Key);
            //    foreach (var item1 in item.GroupedEmp)
            //    {
            //        Console.WriteLine(item1.Key);
            //        foreach (var item2 in item1)
            //        {
            //            Console.WriteLine(item2);
            //        }
            //    }
            //}
            //Console.WriteLine("4.2");
            Console.WriteLine("///////////////////////////////////////////////");
            Console.WriteLine("5.1");

            var countPalneCity = from planeCountry in Airports
                                 group planeCountry by planeCountry.Country into country
                                 select new
                                 {
                                     Id = country.Key,
                                     Count = country.Count()
                                 };
            foreach (var item in countPalneCity)
            {
                Console.WriteLine($"Country - {item.Id} Count plane {item.Count}");
            }
            Console.WriteLine("///////////////////////////////////////////////");
            Console.WriteLine("5.2");

            var countPalneCity1 = Airports.GroupBy(airport => airport.Country).Select(country => new
            {
                Id = country.Key,
                Count = country.Count()
            });
            foreach (var item in countPalneCity1)
            {
                Console.WriteLine($"Country - {item.Id}, Count plane {item.Count}");
            }
            Console.WriteLine();
            Console.WriteLine("///////////////////////////////////////////////");
            Console.WriteLine("6.1");

            var numberTicketsIsClients = from client in Clients
                                         join ticket in Tickets on client.Id equals ticket.ClientId
                                         group ticket by client into t
                                         select new
                                         {
                                             FullName = t.Key.FirstName + " " + t.Key.LastName,
                                             Count = t.Count(),
                                             Tickets = from c in t
                                                       select c
                                         };

            foreach (var item in numberTicketsIsClients)
            {
                Console.WriteLine($"{item.FullName} count {item.Count}");

                foreach (var item1 in item.Tickets)
                {
                    Console.WriteLine(item1.Id);
                }
            }
            Console.WriteLine("///////////////////////////////////////////////");
            Console.WriteLine("6.2");

            var numberTicketsIsClients1 = Clients.Join(Tickets, c => c.Id, t => t.ClientId, (c, t) => new
            {
                Tickets = t,
                Clients = c
            }).GroupBy(ticket => ticket.Clients).Select(t => new
            {
                FullName = t.Key.FirstName + " " + t.Key.LastName,
                Count = t.Count(),
                Tickets = t.Select(c => c.Tickets)
            });
            foreach (var item in numberTicketsIsClients1)
            {
                Console.WriteLine($"{item.FullName} count {item.Count}");

                foreach (var item1 in item.Tickets)
                {
                    Console.WriteLine(item1.Id);
                }
            }
        }
    }
}
