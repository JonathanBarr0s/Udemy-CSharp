using Reservas.Entities;

namespace Reservas {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();
            Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

            Console.WriteLine(reservation);
            Console.WriteLine();

            Console.WriteLine("Enter data to update the reservation:");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();
            reservation = new Reservation(roomNumber, checkIn, checkOut);

            Console.WriteLine(reservation);
        }
    }
}