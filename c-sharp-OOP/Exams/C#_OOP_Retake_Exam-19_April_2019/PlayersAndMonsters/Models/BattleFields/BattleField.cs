namespace PlayersAndMonsters.Models.BattleFields
{
    using System;
    using System.Linq;

    using PlayersAndMonsters.Models.BattleFields.Contracts;
    using PlayersAndMonsters.Models.Players;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories.Contracts;

    public class BattleField : IBattleField
    {
        private const int BEGINNER_HEALTH_INCREASEMENT = 40;
        private const int BEGINNER_CARD_DAMAGE_POINTS_INCREASEMENT = 30;

        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException(
                    "Player is dead!");
            }

            this.ModifyBeginnerPlayer(attackPlayer);
            this.ModifyBeginnerPlayer(enemyPlayer);

            this.BoostPlayer(attackPlayer);
            this.BoostPlayer(enemyPlayer);

            while (!attackPlayer.IsDead && !enemyPlayer.IsDead)
            {
                int attackPlayerAttackPoints = this.DetermineTotalDamagePointsOfPlayer(
                    attackPlayer.CardRepository);
                enemyPlayer.TakeDamage(attackPlayerAttackPoints);

                if (enemyPlayer.IsDead)
                {
                    break;
                }

                int enemyPlayerAttackPoints = this.DetermineTotalDamagePointsOfPlayer(
                    enemyPlayer.CardRepository);
                attackPlayer.TakeDamage(enemyPlayerAttackPoints);
            }
        }

        private int DetermineTotalDamagePointsOfPlayer(ICardRepository cardRepository)
        {
            int total = 0;

            foreach (var card in cardRepository.Cards)
            {
                total += card.DamagePoints;
            }

            return total;
        }

        private void BoostPlayer(IPlayer player)
        {
            player.Health += player.CardRepository
                .Cards
                .Select(c => c.HealthPoints)
                .Sum();
        }

        private void ModifyBeginnerPlayer(IPlayer player)
        {
            if (player is Beginner)
            {
                player.Health += BEGINNER_HEALTH_INCREASEMENT;

                foreach (var card in player.CardRepository.Cards)
                {
                    card.DamagePoints += BEGINNER_CARD_DAMAGE_POINTS_INCREASEMENT;
                }
            }
        }
    }
}
