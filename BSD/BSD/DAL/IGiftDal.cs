using BSD.Models;

namespace BSD.DAL
{
    public interface IGiftDal
    {
        Task<Gift> Add(Gift gift);

        Task<Gift> Get(int id);

        Task<List<Gift>> GetAllGift();

        Task<Gift> Remove(int id);
        Task<Gift> Update(Gift gift);

        Task<Donation> GetDonationByGiftId(int giftId);

        Task<List<Gift>> GetGiftByDonationName(string DonationName);
        //Task<List<Gift>> NumGiftAndDonation();
        // void NumGiftAndDonation1();
    }
}
