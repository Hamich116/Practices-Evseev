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
                                    group ticket by ticket.Row into groupTicket
                                    select new
                                    {
                                        groupTicket.Key,
                                        AverageSum = groupTicket.Average(t => t.Cost),
                                        GroupTicketviaPlace = from ticketPlace in groupTicket
                                                              group ticketPlace by ticketPlace.Place
                                    };
            var groupTicketViaRowSorted = from ticket in groupTicketViaRow
                                          orderby ticket.AverageSum
                                          select ticket;

            foreach (var row in groupTicketViaRowSorted)
            {
                Console.WriteLine("Ряд: " + row.Key);
                foreach (var place in row.GroupTicketviaPlace)
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

            var groupTicketViaPlace1 = Tickets.GroupBy(ticket => ticket.Row).Select(groupTicket => new
            {
                groupTicket.Key,
                averageSum = groupTicket.Average(ticket => ticket.Cost),
                groupPlace = groupTicket.GroupBy(ticket => ticket.Place)
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
                                  group groupReady by groupReady.IsFlyReady into readyGroup
                                  select new
                                  {
                                      Key = readyGroup.Key ? "К полету готовы:" : "К полету не готовы:",
                                      CountPlane = readyGroup.Count()
                                  };
                                  


            foreach (var ready in groupReadyIsFly)
            {
                Console.WriteLine(ready.Key + ready.CountPlane);
            }
            Console.WriteLine("///////////////////////////////////////////////");
            Console.WriteLine("3.2");

            var groupReadyIsFly1 = Planes.Where(plane => plane.FlightHours < n).GroupBy(fly => fly.IsFlyReady).Select(readyGroup => new
            {
                Key = readyGroup.Key ? "К полету готовы:" : "К полету не готовы:",
                CountPlane = readyGroup.Count()
            });
            foreach (var ready in groupReadyIsFly)
            {
                Console.WriteLine(ready.Key + ready.CountPlane);
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

            var countPlaneCity = from planeCountry in Airports
                                 group planeCountry by planeCountry.Country into countryGroup
                                 select new
                                 {
                                     Id = countryGroup.Key,
                                     Count = countryGroup.Count()
                                 };
            foreach (var item in countPlaneCity)
            {
                Console.WriteLine($"Country - {item.Id} Count plane {item.Count}");
            }
            Console.WriteLine("///////////////////////////////////////////////");
            Console.WriteLine("5.2");

            var countPlaneCity1 = Airports.GroupBy(airport => airport.Country).Select(countryGroup => new
            {
                Id = countryGroup.Key,
                Count = countryGroup.Count()
            });
            foreach (var item in countPlaneCity1)
            {
                Console.WriteLine($"Country - {item.Id}, Count plane {item.Count}");
            }
            Console.WriteLine();
            Console.WriteLine("///////////////////////////////////////////////");
            Console.WriteLine("6.1");

            var numberTicketsIsClients = from client in Clients
                                         join ticket in Tickets on client.Id equals ticket.ClientId
                                         group ticket by client into clientWithTickets
                                         select new
                                         {
                                             FullName = clientWithTickets.Key.FirstName + " " + clientWithTickets.Key.LastName,
                                             Count = clientWithTickets.Count(),
                                             Tickets = clientWithTickets
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
            }).GroupBy(ticket => ticket.Clients).Select(clientWithTickets => new
            {
                FullName = clientWithTickets.Key.FirstName + " " + clientWithTickets.Key.LastName,
                Count = clientWithTickets.Count(),
                Tickets = clientWithTickets
            });
            foreach (var item in numberTicketsIsClients1)
            {
                Console.WriteLine($"{item.FullName} count {item.Count}");

                foreach (var item1 in item.Tickets)
                {
                    Console.WriteLine(item1.Tickets.Id);
                }
            }
        }
    }
}
