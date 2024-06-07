using chinasA.Models;

namespace BSD.BLL
{
    public interface ICardServies
    {
        Card Add(Card card);

        Card Get(int id);

        void Remove(int id);
        Card Update(Card card);
    }
}
