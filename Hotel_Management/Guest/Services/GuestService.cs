using Guest.Data;
using System.Reflection;

namespace Guest.Services
{
    public class GuestService : IGuestService
    {
        public List<Models.Guest> GetGuests()
        {
            return GuestMockDataService.Guests;
        }

        public Models.Guest? GetGuest(int id)
        {
            return GuestMockDataService.Guests.FirstOrDefault(x => x.Id == id);
        }

        public Models.Guest? AddGuest(Models.Guest guest)
        {
            GuestMockDataService.Guests.Add(guest);
            return guest;
        }

        public Models.Guest? UpdateGuest(Models.Guest guest)
        {
            Models.Guest selectedGuest = GuestMockDataService.Guests.FirstOrDefault(x => x.Id == guest.Id);
            if (selectedGuest != null)
            {
                selectedGuest.Name = guest.Name;
                selectedGuest.NIC = guest.NIC;
                selectedGuest.Address = guest.Address;
                selectedGuest.Mobile_Number = guest.Mobile_Number;
                return selectedGuest;
            }

            return selectedGuest;
        }

        public bool? DeleteGuest(int id)
        {
            Models.Guest selectedGuest = GuestMockDataService.Guests.FirstOrDefault(x => x.Id == id);
            if (selectedGuest != null)
            {
                GuestMockDataService.Guests.Remove(selectedGuest);
                return true;
            }
            return false;
        }
    }
}
