using AutoMapper;
using BSD.BLL;
using BSD.Models.DTO;
using BSD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors.Infrastructure;
using chinasA.Models;

namespace BSD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {
        private readonly ICardServies CardServies;
        private readonly IMapper mapper;
        public CardController(ICardServies CardServies, IMapper mapper)
        {
            this.CardServies = CardServies;
            this.mapper = mapper;
        }
        [HttpPost]
        public ActionResult<Card> Add(Card card)
        {
            var cardComplete = mapper.Map<Card>(card);
            return CardServies.Add(cardComplete);

        }
        [HttpGet("{id}")]
        public ActionResult<Card> Get(int id)
        {
           
            return CardServies.Get(id);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            CardServies.Remove(id);
        }

        [HttpPut]
        public Card Update(CardDto cDto)
        {
            var card = mapper.Map<Card>(cDto);
            return CardServies.Update(card);
        }

     
    }
}
