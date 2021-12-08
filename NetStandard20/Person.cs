using System;
using System.Text.Json.Serialization;

namespace NetStandard20
{
    public class Person
    {
        public Person() {}

        [JsonConstructor]
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string? FirstName { get; init; }

        public string? LastName { get; init; }
    }
}
