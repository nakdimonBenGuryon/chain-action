using BSD.Models;

namespace BSD.BLL
{
    public interface IGiftServies
    {
        Task<Gift> Add(Gift gift);

        Task<Gift> Get(int id);

        Task<List<Gift>> GetAllGift();

        Task<Gift> Remove(int id);
        Task<Gift> Update(Gift gift,int id);

        Task<Donation> GetDonationByGiftId(int giftId);
        Task<List<Gift>> GetGiftByDonationName(string DonationName);
        //public void NumGiftAndDonation();
    }
}
