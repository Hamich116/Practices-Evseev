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
            int averageCost = Convert.ToInt32(average); // для красивого вывода
            Console.WriteLine($"Среднее стоимость билета: {averageCost}");

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
            Console.WriteLine($"Количество самолетов с вместимостью {n} человек: {countPlanes}");

            //3
            Console.WriteLine("Пункт третий: ");
            var informationFlight = from flight in Flights
                                    join flightCrew in FlightCrews on flight.Id equals flightCrew.FlightId
                                    join airportArrival in Airports on flight.AirportArrivalId equals airportArrival.Id
                                    join airportDeparture in Airports on flight.AirportDepartureId equals airportDeparture.Id
                                    join plane in Planes on flight.PlaneId equals plane.Id
                                    join employee in Employees on flightCrew.EmployeeId equals employee.Id
                                    select new
                                    {
                                        flight.Id,
                                        plane.ModelName,
                                        airportArrival = airportArrival.Name,
                                        cityArrival = airportArrival.City,
                                        countryArrival = airportArrival.Country,
                                        airportDeparture = airportDeparture.Name,
                                        cityDeparture = airportDeparture.City,
                                        countryDeparture = airportDeparture.Country,
                                        flight.ArrivalDate,
                                        flight.DepartureDate,
                                        IdCrew = flightCrew.Id,
                                        employees = Employees
                              };
            foreach (var fullFlight in informationFlight)
            {
                Console.WriteLine($"Id рейса: {fullFlight.Id}, модель самолета: {fullFlight.ModelName}");
                Console.WriteLine($"Дата прибытия: {fullFlight.ArrivalDate}, Аэропорт прибытия: {fullFlight.airportArrival}" +
                    $", Город прибытия {fullFlight.cityArrival}, Страна прибытия {fullFlight.countryArrival}");
                Console.WriteLine($"Дата отбытия: {fullFlight.DepartureDate}, Аэропорт отбытия: {fullFlight.airportDeparture}" +
                    $", Город отбытия {fullFlight.cityDeparture}, Страна отбытия {fullFlight.countryDeparture}");
                Console.WriteLine($"Id экипажа: {fullFlight.IdCrew}, Сотрудники: ");
                for (int i = 0; i < fullFlight.employees.Count; i++)
                {
                    Console.WriteLine($"{i+1}: {fullFlight.employees[i].LastName}");
                }
            }
        }
    }
}
