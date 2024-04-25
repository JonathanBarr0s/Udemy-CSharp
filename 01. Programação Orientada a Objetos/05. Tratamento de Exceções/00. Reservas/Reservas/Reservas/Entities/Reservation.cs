using Reservas.Entities.Exceptions;
using System.Text;

namespace Reservas.Entities {
    internal class Reservation {

        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut) {

            if (checkIn >= checkOut) {
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration() {
            TimeSpan duration = CheckOut - CheckIn;
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut) {

            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now) {

                throw new DomainException("Reservation dates for update must be future dates");

            } else if (checkIn >= checkOut) {
                throw new DomainException("Check-out date must be after check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("Reservation: Room ");
            sb.Append(RoomNumber);
            sb.Append(", check-in: ");
            sb.Append(CheckIn.ToShortDateString());
            sb.Append(", check-out: ");
            sb.Append(CheckOut.ToShortDateString());
            sb.Append(", ");
            sb.Append(Duration());
            sb.Append(" nights.");

            return sb.ToString();
        }
    }
}
