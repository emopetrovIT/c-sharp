namespace CarDealer.Web.Infrastructure.Extensions
{
    using System;

    public static class StringExtensions
    {
        public static string ToPrice(this decimal priceText)
        {
            return $"${priceText:f2}";
        }

        public static string ToPercentage(this double number)
        {
            var numberToPercents = number * 100;
            return $"{Math.Round(numberToPercents)}%";
        }
    }
}
