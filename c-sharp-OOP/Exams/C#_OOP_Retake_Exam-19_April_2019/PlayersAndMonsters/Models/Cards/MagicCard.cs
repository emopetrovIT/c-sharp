namespace PlayersAndMonsters.Models.Cards
{
    using PlayersAndMonsters.Models.Cards.Contracts;

    public class MagicCard : Card, ICard
    {
        private const int MAGICCARD_DAMADE_POINTS = 5;
        private const int MAGICCARD_HEALTH_POINTS = 80;

        public MagicCard(string name)
            : base(name, MAGICCARD_DAMADE_POINTS, MAGICCARD_HEALTH_POINTS)
        {

        }
    }
}
