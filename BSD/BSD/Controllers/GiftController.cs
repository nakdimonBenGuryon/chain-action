using AutoMapper;
using BSD.BLL;
using BSD.DAL;
using BSD.Models;
using BSD.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BSD.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class GiftController : ControllerBase
    {
        private readonly IGiftServies GiftServies;
        private readonly IMapper mapper;
        public GiftController(IGiftServies GiftServies, IMapper mapper)
        {
            this.GiftServies = GiftServies;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<Gift> Add(GiftDto giftDto)
        {
            var gift = mapper.Map<Gift>(giftDto);
            return await GiftServies.Add(gift);
        }
        [HttpGet("get/{id}")]
        public async Task<Gift> Get(int id)
        {
            return await GiftServies.Get(id);
        }
        [HttpGet]
        public async Task<List<Gift>> GetAllGift()
        {
            return await GiftServies.GetAllGift();
        }
        [HttpDelete("{id}")]
        public async Task<Gift> Remove(int id)
        {
            return await GiftServies.Remove(id);
        }
        [HttpPut]
        public async  Task<ActionResult<Gift>> Update(GiftDto giftDto,int id)
        {
            try
            {
                Gift gift = mapper.Map<Gift>(giftDto);
                return Ok(await GiftServies.Update(gift,id ));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("getDonation/{giftId}")]
        public async Task<Donation> GetDonationByGiftId(int giftId)
        {
            return await GiftServies.GetDonationByGiftId(giftId);
        }
        [HttpGet("getGiftsbyDonationName")]
        public async Task<List<Gift>> GetGiftByDonationName(string DonationName)
        {
            return await GiftServies.GetGiftByDonationName(DonationName);
        }
    }
}
        
