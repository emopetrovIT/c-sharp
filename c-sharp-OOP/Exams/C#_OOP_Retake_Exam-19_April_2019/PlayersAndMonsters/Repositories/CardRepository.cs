namespace PlayersAndMonsters.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using PlayersAndMonsters.Common;
    using PlayersAndMonsters.Models.Cards.Contracts;
    using PlayersAndMonsters.Repositories.Contracts;

    public class CardRepository : ICardRepository
    {
        private readonly Dictionary<string, ICard> cardsByName;

        public CardRepository()
        {
            this.cardsByName = new Dictionary<string, ICard>();
        }

        public int Count => this.cardsByName.Count;

        public IReadOnlyCollection<ICard> Cards =>
            this.cardsByName.Values.ToList().AsReadOnly();

        public void Add(ICard card)
        {
            Validator.ThrowExceptionIfObjectIsNull(
                card,
                "Card cannot be null");

            if (this.cardsByName.ContainsKey(card.Name))
            {
                throw new ArgumentException($"Card {card.Name} already exists!");
            }

            this.cardsByName.Add(card.Name, card);
        }

        public bool Remove(ICard card)
        {
            Validator.ThrowExceptionIfObjectIsNull(
                card,
                "Card cannot be null!");

            return this.cardsByName.Remove(card.Name);
        }

        public ICard Find(string name)
        {
            ICard card = null;

            if (this.cardsByName.ContainsKey(name))
            {
                card = this.cardsByName[name];
            }

            return card;
        }
    }
}
