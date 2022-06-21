namespace CatsServer.Data
{
    using System.ComponentModel.DataAnnotations;

    public class Cat
    {
        private const int STRING_MAX_LENGTH = 50;
        private const int STRING_MIN_LENGTH = 1;
        public int Id { get; set; }

        [Required]
        [MinLength(STRING_MIN_LENGTH)]
        [MaxLength(STRING_MAX_LENGTH)]
        public string Name { get; set; }

        [Range(0, 30)]
        public int Age { get; set; }

        [Required]
        [MinLength(STRING_MIN_LENGTH)]
        [MaxLength(STRING_MAX_LENGTH)]
        public string Breed { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(2000)]
        public string ImageUrl { get; set; }
    }
}
