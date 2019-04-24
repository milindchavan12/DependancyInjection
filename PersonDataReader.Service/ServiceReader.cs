using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using SharedObjects;

namespace PersonDataReader.Service
{
    public class ServiceReader : IPersonReader
    {
        WebClient webClient = new WebClient();
        string baseUrl = "localhost:2345";

        public IEnumerable<Person> GetPeople()
        {
            var result = webClient.DownloadString(baseUrl);
            var people = JsonConvert.DeserializeObject<List<Person>>(result);
            return people;
        }

        public Person GetPerson(int id)
        {
            var result = webClient.DownloadString($"{baseUrl}/{id}");
            var person = JsonConvert.DeserializeObject<Person>(result);
            return person;
        }
    }
}
