using System;


namespace Homework.Utilities
{
    public static class RandomGenerator
    {
        public static string GenerateMail()
        {
           return $"asdf+{Guid.NewGuid()}@gmail.com";
        }
    }
}
