using BSD.Models;
using chinasA.Models;

namespace BSD.DAL
{
    public interface ICardDal
    {
        Card Add(Card card);

        Card Get(int id);

        void Remove(int id);
        Card Update(Card card);

       // List<Card> GetProductsByCustomerId(int cardId);
    }
}
