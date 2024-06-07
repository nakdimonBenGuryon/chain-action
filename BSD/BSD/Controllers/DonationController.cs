using AutoMapper;
using BSD.BLL;
using BSD.Models;
using BSD.Models.DTO;
using chinasA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace BSD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DonationController : ControllerBase
    {
        private readonly IDontionServies dontionServies;
        private readonly IMapper mapper;
        public DonationController(IDontionServies dontionServies, IMapper mapper)
        {
            this.dontionServies = dontionServies;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<Donation> Add(DonationDto donationDto)
        {
            var cardComplete = mapper.Map<Donation>(donationDto);
            return await dontionServies.Add(cardComplete);

        }
        [HttpGet("get/{id}")]
        public async Task<Donation> GetById(int id)
        {
            return await dontionServies.Get(id);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dontionServies.Remove(id);
        }

        [HttpPut]
        public async Task<Donation> Update(Donation donation)
        {
            return await dontionServies.Update(donation);
        }
        [HttpGet("Donationid/{id}")]
        public async  Task<List<Gift>>GetProductByDonationId(int Donationid)
        {
            return await dontionServies.GetProductsByDonationId(Donationid);
        }
        [HttpGet()]
       public async Task<List<Donation>> GetAllDonor()
        {
            return await dontionServies.GetAllDonor();
        }


    }
}
