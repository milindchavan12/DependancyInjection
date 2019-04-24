using System.Collections.Generic;
using SharedObjects;

namespace People.Service.Models
{
    public interface IPeopleProvider
    {
        List<Person> GetPeople();
    }
}