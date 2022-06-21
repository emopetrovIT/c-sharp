namespace PlayersAndMonsters.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using PlayersAndMonsters.Common;
    using PlayersAndMonsters.Models.Players;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories.Contracts;

    public class PlayerRepository : IPlayerRepository
    {
        private readonly Dictionary<string, IPlayer> playersByUsername;

        public PlayerRepository()
        {
            this.playersByUsername = new Dictionary<string, IPlayer>();
        }

        public int Count => this.playersByUsername.Count;
        
        public IReadOnlyCollection<IPlayer> Players =>
            this.playersByUsername.Values.ToList().AsReadOnly();

        public void Add(IPlayer player)
        {
            Validator.ThrowExceptionIfObjectIsNull(
                player,
                "Player cannot be null");

            if (this.playersByUsername.ContainsKey(player.Username))
            {
                throw new ArgumentException(
                    $"Player {player.Username} already exists!");
            }

            this.playersByUsername.Add(player.Username, player);
        }

        public IPlayer Find(string username)
        {
            IPlayer player = null;

            if (this.playersByUsername.ContainsKey(username))
            {
               player = this.playersByUsername[username];
            }

            return player;
        }
        
        public bool Remove(IPlayer player)
        {
            Validator.ThrowExceptionIfObjectIsNull(
                player,
                "Player cannot be null");

            return this.playersByUsername.Remove(player.Username);
        } 
    }
}
