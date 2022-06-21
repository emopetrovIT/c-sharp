namespace PlayersAndMonsters.Models.Cards
{
    using PlayersAndMonsters.Models.Cards.Contracts;

    public class TrapCard : Card, ICard
    {
        private const int TRAPCARD_DAMAGE_POINTS = 120;
        private const int TRAPCARD_HEALTH_POINTS = 5;

        public TrapCard(string name) 
            : base(name, TRAPCARD_DAMAGE_POINTS, TRAPCARD_HEALTH_POINTS)
        {

        }
    }
}
