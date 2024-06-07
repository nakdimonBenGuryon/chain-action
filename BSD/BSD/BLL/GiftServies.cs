using BSD.DAL;
using BSD.Models;

namespace BSD.BLL
{
    public class GiftServies : IGiftServies
    {
        private readonly IGiftDal giftDal;
        public GiftServies(IGiftDal IGiftDal)
        {
            this.giftDal = IGiftDal;
        }

        public async Task<Gift> Add(Gift gift)
        {
            return await giftDal.Add(gift);
        }

        public async Task<Gift> Get(int id)
        {
           return await giftDal.Get(id);
        }

        public async Task<List<Gift>> GetAllGift()
        {
            return await giftDal.GetAllGift();
        }

        public async Task<Donation> GetDonationByGiftId(int giftId)
        {
            return await giftDal.GetDonationByGiftId(giftId);
        }

        public async Task<List<Gift>> GetGiftByDonationName(string DonationName)
        {
          return await  giftDal.GetGiftByDonationName(DonationName);
        }

        public async Task<Gift> Remove(int id)
        {
            return await giftDal.Remove(id);
        }

        public async Task<Gift> Update(Gift gift,int id)
        {
            gift.Id = id;
            return await giftDal.Update(gift);
        }
    }
}
