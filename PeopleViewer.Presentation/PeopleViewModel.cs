using PersonDataReader.Service;
using SharedObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PeopleViewer.Presentation
{
    public class PeopleViewModel
    {
        protected IPersonReader DataReader;

        public PeopleViewModel(IPersonReader dataReader)
        {
            DataReader = dataReader;
        }

        public IEnumerable<Person> GetPeople()
        {
            return DataReader.GetPeople();
        }

        public string DataReaderType => DataReader.GetType().ToString();
    }
}
