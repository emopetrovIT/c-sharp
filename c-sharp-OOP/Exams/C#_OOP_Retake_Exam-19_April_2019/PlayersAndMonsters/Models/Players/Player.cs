﻿namespace PlayersAndMonsters.Models.Players
{
    using System;

    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories.Contracts;

    public abstract class Player : IPlayer
    {
        private string username;
        private int health;

        protected Player(ICardRepository cardRepository, string username, int health)
        {
            this.CardRepository = cardRepository;
            this.Username = username;
            this.Health = health;
        }

        public ICardRepository CardRepository { get; }

        public string Username 
        {
            get => this.username;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                        "Player's username cannot be null or an empty string.");
                }

                this.username = value;
            }
        }

        public int Health 
        {
            get => this.health;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "Player's health bonus cannot be less than zero.");
                }

                this.health = value;
            } 
        }

        public bool IsDead => this.health <= 0;

        public void TakeDamage(int damagePoints)
        {
            if (damagePoints < 0)
            {
                throw new ArgumentException("Damage points cannot be less than zero.");
            }

            this.Health = Math.Max(this.Health - damagePoints, 0);
        }
    }
}
