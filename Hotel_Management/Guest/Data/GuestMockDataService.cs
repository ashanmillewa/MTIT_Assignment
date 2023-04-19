using System.Reflection;

namespace Guest.Data
{
    public class GuestMockDataService
    {
        public static List<Models.Guest> Guests = new List<Models.Guest>()
        {
            new Models.Guest { Id = 001,NIC = "785045678932", Name = "Ashan", Address = "78 Kandy Rd, Peliyagoda", Mobile_Number = "0778955632" },
            new Models.Guest { Id = 002,NIC = "369049865215", Name = "Sanduni", Address = "99 Colombo Rd, Negambo", Mobile_Number = "0718955555" },
            new Models.Guest { Id = 003,NIC = "222089432132", Name = "Oshani", Address = "55 Galle Rd, Galkissa", Mobile_Number = "0758953212" },
            new Models.Guest { Id = 004,NIC = "980012457865", Name = "Lakindu", Address = "24 Kandy Rd, Kadawatha", Mobile_Number = "0788955456" },
            new Models.Guest { Id = 005,NIC = "278504512651", Name = "Salindu", Address = "22 Kandy Rd, Nittambuwa", Mobile_Number = "0708955258" },
        };
    }
}
