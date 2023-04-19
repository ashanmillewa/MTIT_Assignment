namespace Guest.Services
{
    public interface IGuestService
    {
        List<Models.Guest> GetGuests();
        Models.Guest? GetGuest(int id);
        Models.Guest? AddGuest(Models.Guest Guest);
        Models.Guest? UpdateGuest(Models.Guest Guest);
        bool? DeleteGuest(int id);
    }
}
