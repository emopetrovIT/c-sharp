namespace Homework
{
    public static class UserFactory
    {
        public static RegistrationUser CreateValidUser()
        {
            return new RegistrationUser
            {
                FirstName = "firstname",
                LastName = "lastname",
                Year = "1980",
                Month = "5",
                Date = "10",
                RealFirstName = "name",
                RealLastName = "lastname",
                Password = "password",
                Gender = "male",
                PostCode = "85001",
                Address="address",
                City="Minneapolis",
                State="Minnesota",
                Phone="5555555555",
                Alias="Test"
            };
        }
    }
}
