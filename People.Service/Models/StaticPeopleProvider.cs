using System;
using System.Collections.Generic;
using SharedObjects;

namespace People.Service.Models
{
    public class StaticPeopleProvider : IPeopleProvider
    {
        public List<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person { Id = 1, FamilyName ="Chavan", GivenName="Milind"},
                new Person { Id = 2, FamilyName ="Sto", GivenName="Jack"},
                new Person { Id = 3, FamilyName ="Twaan", GivenName="Ma"},
            };
        }
    }
}
