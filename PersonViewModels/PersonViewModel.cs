using System;
using System.ComponentModel;
using PersonRepository.Interface;

namespace PersonViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        protected IPersonRepository Repository;

        public event PropertyChangedEventHandler PropertyChanged;

        public PersonViewModel(IPersonRepository repository)
        {
            Repository = repository;
        }
    }
}
