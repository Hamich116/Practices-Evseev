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

            var groupCitezenship1 = Clients.OrderBy(client => client.LastName).ThenBy(client => client.FirstName).GroupBy(client => client.Citizenship);
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
                                    group ticket by ticket.Row into ticket
                                    select new
                                    {
                                        ticket.Key,
                                        averageSum = ticket.Average(ticket => ticket.Cost),
                                        groupTicketviaPlace = from ticketPlace in ticket
                                                              group ticketPlace by ticketPlace.Place
                                    };
            var groupTicketViaRowSorted = from ticket in groupTicketViaRow
                                          orderby ticket.averageSum
                                          select ticket;

            foreach (var row in groupTicketViaRowSorted)
            {
                Console.WriteLine("Ряд: " + row.Key);
                foreach (var place in row.groupTicketviaPlace)
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

            var groupTicketViaPlace1 = Tickets.GroupBy(ticket => ticket.Row).Select(ticket => new
            {
                ticket.Key,
                averageSum = ticket.Average(ticket => ticket.Cost),
                groupPlace = ticket.GroupBy(ticket => ticket.Place)
            }).OrderBy(ticket => ticket.averageSum);

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
                                  group groupReady by groupReady.IsFlyReady into ready
                                  select new
                                  {
                                      Key = ready.Key ? "К полету готовы:" : "К полету не готовы:",
                                      Planes = from plane in ready
                                               select plane
                                  };
                                  


            foreach (var ready in groupReadyIsFly)
            {
                Console.WriteLine(ready.Key);
                foreach (var plane in ready.Planes)
                {
                    Console.WriteLine($"Name plane - {plane.ModelName}");
                }
            }
            Console.WriteLine("///////////////////////////////////////////////");
            Console.WriteLine("3.2");

            var groupReadyIsFly1 = Planes.Where(plane => plane.FlightHours < n).GroupBy(fly => fly.IsFlyReady).Select(ready => new
            {
                Key = ready.Key ? "К полету готовы:" : "К полету не готовы:",
                Planes = ready.Select(plane => plane)
            });
            foreach (var ready in groupReadyIsFly1)
            {
                Console.WriteLine(ready.Key);
                foreach (var plane in ready.Planes)
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
                                         group ticket by client into client
                                         select new
                                         {
                                             FullName = client.Key.FirstName + " " + client.Key.LastName,
                                             Count = client.Count(),
                                             Tickets = from c in client
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

            var numberTicketsIsClients1 = Clients.Join(Tickets, client => client.Id, ticket => ticket.ClientId, (client, ticket) => new
            {
                Tickets = ticket,
                Clients = client
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
