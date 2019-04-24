using System;
using System.Collections.Generic;

namespace SharedObjects
{
    public interface IPersonReader
    {
        IEnumerable<Person> GetPeople();
        Person GetPerson(int id);
    }
}
