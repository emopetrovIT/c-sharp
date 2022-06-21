namespace PlayersAndMonsters.Models.Players
{
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories.Contracts;

    public class Advanced : Player,IPlayer
    {
        private const int ADVANCED_PLAYER_INITIAL_HEALTH = 250;

        public Advanced(ICardRepository cardRepository, string username)
            : base(cardRepository, username, ADVANCED_PLAYER_INITIAL_HEALTH)
        {

        }
    }
}
