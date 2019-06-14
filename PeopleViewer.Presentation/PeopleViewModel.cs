using PersonDataReader.Service;
using SharedObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PeopleViewer.Presentation
{
    public class PeopleViewModel
    {
        protected ServiceReader DataReader;

        public PeopleViewModel()
        {
            DataReader = new ServiceReader();
        }

        public IEnumerable<Person> GetPeople()
        {
            return DataReader.GetPeople();
        }

        public string DataReaderType => DataReader.GetType().ToString();
    }
}
