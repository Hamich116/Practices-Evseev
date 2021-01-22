using System;
using AirModel;
using AirDataSource;
using static AirDataSource.AirDataSource;
using System.Linq;
using System.Collections.Generic;

namespace LinqRequests
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            // проверка
            //var costs = Tickets.Select(c => c);
            //foreach (var item in costs)
            //{
            //    Console.Write(item.Cost + " ");
            //}
            Console.WriteLine("Пункт первый: ");
            var average = Tickets.Average(ticket => ticket.Cost);
            int averageCost = Convert.ToInt32(average);
            Console.WriteLine($"Среднее стоимость билета: {averageCost} рублей");
            Console.WriteLine("1.1");
            var average1 = from ticket in Tickets
                           select Tickets.Average(t => t.Cost);
            int averageCost1 = Convert.ToInt32(average);
            Console.WriteLine($"Среднее стоимость билета: {averageCost1} рублей");

            //2

            //проверка
            //var planes = Planes.Select(p => p);
            //foreach (var item in planes)
            //{
            //    Console.Write(item.Capacity + " ");
            //}
            Console.WriteLine("Пункт второй: ");
            int n = 150;
            var countPlanes = Planes.Where(plane => plane.Capacity > n).Count();
            var countPlanes1 = from plane in Planes
                               where plane.Capacity > n
                               select plane;
                               
            Console.WriteLine($"Количество самолетов с вместимостью больше {n} человек: {countPlanes}");
            Console.WriteLine("2.1");
            Console.WriteLine($"Количество самолетов с вместимостью больше {n} человек: {countPlanes1.Count()}");

            //3
            Console.WriteLine("Пункт третий: ");

            var informationFlight = from flight in Flights
                                    join flightCrew in FlightCrews on flight.Id equals flightCrew.FlightId
                                    join employee in Employees on flightCrew.EmployeeId equals employee.Id
                                    select new
                                    {
                                        flight.Id,
                                        flight.PlaneId,
                                        flight.AirportArrivalId,
                                        flight.AirportDepartureId,
                                        flight.ArrivalDate,
                                        flight.DepartureDate,
                                        IdCrew = flightCrew.Id,
                                        employeeName = employee.LastName
                                        
                                    };
            foreach (var fullFlight in informationFlight)
            {
                Console.WriteLine($"Id рейса: {fullFlight.Id}, модель самолета: {fullFlight.PlaneId}");
                Console.WriteLine($"Дата прибытия: {fullFlight.ArrivalDate}, Аэропорт прибытия: {fullFlight.AirportArrivalId}");
                Console.WriteLine($"Дата отбытия: {fullFlight.DepartureDate}, Аэропорт отбытия: {fullFlight.AirportArrivalId}");
                Console.WriteLine($"Id экипажа: {fullFlight.IdCrew}, Сотрудник: {fullFlight.employeeName}");
            }

            Console.WriteLine("3.1");
            var informationFlight1 = Flights.Join(FlightCrews, f => f.Id, c => c.FlightId, (f, c) => new
            {
                f.Id,
                f.PlaneId,
                f.AirportArrivalId,
                f.AirportDepartureId,
                f.ArrivalDate,
                f.DepartureDate,
                IdCrew = c.Id
            }).Join(Employees, f => f.IdCrew, e => e.Id, (f, e) => new
            {
                f.Id,
                f.PlaneId,
                f.AirportArrivalId,
                f.AirportDepartureId,
                f.ArrivalDate,
                f.DepartureDate,
                f.IdCrew,
                e.LastName
            });
            foreach (var fullFlight in informationFlight1)
            {
                Console.WriteLine($"Id рейса: {fullFlight.Id}, модель самолета: {fullFlight.PlaneId}");
                Console.WriteLine($"Дата прибытия: {fullFlight.ArrivalDate}, Аэропорт прибытия: {fullFlight.AirportArrivalId}");
                Console.WriteLine($"Дата отбытия: {fullFlight.DepartureDate}, Аэропорт отбытия: {fullFlight.AirportArrivalId}");
                Console.WriteLine($"Id экипажа: {fullFlight.IdCrew}, Сотрудник: {fullFlight.LastName}");
            }
            //4
            Console.WriteLine("Пункт четвертый:");
            var fullEmployee = from employee in Employees
                               join position in Positions on employee.PositionId equals position.Id
                               select new
                               {
                                   employee.Id,
                                   employee.FirstName,
                                   employee.LastName,
                                   employee.WorkExperience,
                                   positionName = position.Name
                               };
            foreach (var employee in fullEmployee)
            {
                Console.WriteLine($"Id сотрудника: {employee.Id}, Полное имя сотрудника: {employee.FirstName}" +
                    $"{employee.LastName}, Стаж работы: {employee.WorkExperience} лет, Занимаемая должность: {employee.positionName}");
            }
            Console.WriteLine("4.1");
            var fullEmployee1 = Employees.Join(Positions, e => e.PositionId, f => f.Id, (e, f) => new
            {
                e.Id,
                e.FirstName,
                e.LastName,
                e.WorkExperience,
                f.Name
            });
            foreach (var employee in fullEmployee1)
            {
                Console.WriteLine($"Id сотрудника: {employee.Id}, Полное имя сотрудника: {employee.FirstName}" +
                    $"{employee.LastName}, Стаж работы: {employee.WorkExperience} лет, Занимаемая должность: {employee.Name}");
            }
            //5
            Console.WriteLine("Пункт пятый:");
            DateTime actulTime = new DateTime(2020, 06, 30);
            var sortedClients = from client in Clients
                                join ticket in Tickets on client.Id equals ticket.ClientId
                                join flight in Flights on ticket.FlightId equals flight.Id
                                orderby client.LastName,client.FirstName
                                select new
                                {
                                    client.Id,
                                    client.FirstName,
                                    client.LastName,
                                    ticketId = ticket.Id,
                                    flight.DepartureDate
                                };

            var clientWithTickets = from client in sortedClients
                                    where client.DepartureDate > actulTime
                                    select client;
            foreach (var client in clientWithTickets)
            {
                Console.WriteLine($"Id пассажира: {client.Id}, Полное имя: {client.FirstName} {client.LastName}" +
                    $", Дата отбытия: {client.DepartureDate}");
            }
            Console.WriteLine("5.1");
            var clientWithTickets1 = Clients.Join(Tickets, s => s.Id, t => t.ClientId, (s, t) => new
            {
                s.Id,
                s.FirstName,
                s.LastName,
                ticketId = t.Id,
                t.FlightId
            }).Join(Flights, s => s.FlightId, f => f.Id, (s, f) => new
            {
                s.Id,
                s.FirstName,
                s.LastName,
                ticketId = s.Id,
                f.DepartureDate
            }).OrderBy(s => s.LastName).ThenBy(s => s.FirstName).Where(s => s.DepartureDate > actulTime);
            foreach (var client in clientWithTickets1)
            {
                Console.WriteLine($"Id пассажира: {client.Id}, Полное имя: {client.FirstName} {client.LastName}" +
                    $", Дата отбытия: {client.DepartureDate}");
            }

            //6
            Console.WriteLine("Пункт шестой: ");
            var sortedPlanes = from plane in Planes
                               orderby plane.FlightHours, plane.IssueYear, plane.Capacity
                               select plane;
            foreach (var plane in sortedPlanes)
            {
                Console.WriteLine($"Id самолета: {plane.Id}, Количество часов в полете: {plane.FlightHours}" +
                    $", Год выпуска: {plane.IssueYear}, Вместимость самолета: {plane.Capacity}");
            }
            Console.WriteLine("6.1");
            var sortedPlanes1 = Planes.OrderBy(p => p.FlightHours).ThenBy(p => p.IssueYear).ThenBy(p => p.Capacity);
            foreach (var plane in sortedPlanes1)
            {
                Console.WriteLine($"Id самолета: {plane.Id}, Количество часов в полете: {plane.FlightHours}" +
                    $", Год выпуска: {plane.IssueYear}, Вместимость самолета: {plane.Capacity}");
            }
            //7
            Console.WriteLine("Пункт седьмой:");
            var planeArrival = from flight in Flights
                               group flight by flight.DepartureDate;
            foreach (var plane in planeArrival)
            {
                int counter = 0;
                Console.WriteLine("Дата прибытия " + plane.Key);
                foreach (var item in plane)
                {
                    counter += 1;
                    Console.WriteLine("Id прибывшего самолета " + item.PlaneId);
                }
                if (counter > 1)
                {
                    Console.WriteLine($"Прилетевших самолетов: {counter}");
                }
                else
                {
                    Console.WriteLine("Нет еще самолетов прилетевших сюда");
                }
            }
            Console.WriteLine("7.1");
            var planeArrival1 = Flights.GroupBy(f => f.DepartureDate);
            foreach (var plane in planeArrival1)
            {
                int counter = 0;
                Console.WriteLine("Дата прибытия " + plane.Key);
                foreach (var item in plane)
                {
                    counter += 1;
                    Console.WriteLine("Id прибывшего самолета " + item.PlaneId);
                }
                if (counter > 1)
                {
                    Console.WriteLine($"Прилетевших самолетов: {counter}");
                }
                else
                {
                    Console.WriteLine("Нет еще самолетов прилетевших сюда");
                }
            }


        }
    }
}
