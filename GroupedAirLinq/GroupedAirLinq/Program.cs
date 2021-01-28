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
            Console.WriteLine("3.1");

            int n = 1000;
            var groupReadyFlyPlane = from CountPlaneHours in Planes
                                     where CountPlaneHours.FlightHours < n
                                     select CountPlaneHours;
            var groupReadyIsFly = from groupReady in groupReadyFlyPlane
                                  group groupReady by groupReady.IsFlyReady;

            foreach (var ready in groupReadyIsFly)
            {
                if (ready.Key)
                {
                    Console.WriteLine("Готовы к полету");
                }
                else
                {
                    Console.WriteLine("Не готовы к полету");
                }
                
                foreach (var plane in ready)
                {
                    
                    if (plane.IsFlyReady)
                    {
                        Console.WriteLine($"Name plane - {plane.ModelName}");
                    }
                    else
                    {
                        Console.WriteLine($"Name plane - {plane.ModelName}");
                    }
                }
            }
            
            Console.WriteLine("3.2");

            var groupReadyIsFly1 = Planes.Where(p => p.FlightHours < n).GroupBy(f => f.IsFlyReady);
            foreach (var ready in groupReadyIsFly1)
            {
                if (ready.Key)
                {
                    Console.WriteLine("Готовы к полету");
                }
                else
                {
                    Console.WriteLine("Не готовы к полету");
                }

                foreach (var plane in ready)
                {

                    if (plane.IsFlyReady)
                    {
                        Console.WriteLine($"Name plane - {plane.ModelName}");
                    }
                    else
                    {
                        Console.WriteLine($"Name plane - {plane.ModelName}");
                    }
                }
            }
            //Console.WriteLine("4.1");
            //var allInfo = from flightcrew in FlightCrews
            //              group flightcrew by flightcrew.FlightId;
            //foreach (var item in allInfo)
            //{
            //    Console.WriteLine("Рейс: " + item.Key);
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1.EmployeeId);
            //    }
            //}

            //Console.WriteLine();

            //Console.WriteLine("4.2");
            Console.WriteLine("5.1"); // ГОТОВО 
            var countPalneCity = from planeCountry in Airports
                                 group planeCountry by planeCountry.Country into c
                                 select new
                                 {
                                     Id = c.Key,
                                     Count = c.Count()
                                 };
            foreach (var item in countPalneCity)
            {
                Console.WriteLine($"Country - {item.Id} Count plane {item.Count}");
            }

            Console.WriteLine("5.2"); // ГОТОВО 

            var countPalneCity1 = Airports.GroupBy(c => c.Country).Select(g => new
            {
                Id = g.Key,
                Count = g.Count()
            });
            foreach (var item in countPalneCity1)
            {
                Console.WriteLine($"Country - {item.Id}, Count plane {item.Count}");
            }
            Console.WriteLine();

            Console.WriteLine("6.1");

            var numberTicketsIsClients = from client in Clients
                                         group client by client.Tickets.Count;
            foreach (var item in numberTicketsIsClients)
            {
                foreach (var item1 in item)
                {
                    Console.WriteLine($"Full name {item1.LastName} {item1.FirstName}, count {item.Key}, билеты:");
                    foreach (var item2 in item1.Tickets)
                    {
                        Console.WriteLine(item2.Id);
                    }
                }
            }
            Console.WriteLine("6.2");
            var numberTicketsIsClients1 = Clients.GroupBy(client => client.Tickets.Count);
            foreach (var item in numberTicketsIsClients)
            {
                foreach (var item1 in item)
                {
                    Console.WriteLine($"Full name {item1.LastName} {item1.FirstName}, count {item.Key}, билеты:");
                    foreach (var item2 in item1.Tickets)
                    {
                        Console.WriteLine(item2.Id);
                    }
                }
            }
        }
    }
}
