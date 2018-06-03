using System;
using SharedObjects;

namespace PersonRepository.Interface
{
    public interface IPersonRepository
    {
        IEquatable<Person> GetPeople();

        Person GetPerson(string lastName);

        void AddPerson(Person newPerson);

        void UpdatePerson(string lastName, Person updatedPerson);

        void DeletePerson(string lastName);

        void UpdatePeople(IEquatable<Person> updatedPeople);
    }
}
