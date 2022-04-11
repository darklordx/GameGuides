using GameGuides.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace GameGuides.ViewViewModels.Main
{
    class MainPageViewModel
    {
        //public ObservableCollection<Person> PeopleNames;
        private ObservableCollection<GuideModel> MaskedGameGuides;
        public ObservableCollection<GuideModel> RealGameGuides
        {
            get
            {
                return MaskedGameGuides;
            }
            set
            {
                MaskedGameGuides = value;
                RaisePropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        //get
        //    {
        //        return _person;
        //    }
        //set
        //    {
        //        _person = value;

        //    }
        //}


        private List<GuideModel> _person;
        public MainPageViewModel()
        {
            RealGameGuides = new ObservableCollection<GuideModel>();
            _person = GuideModel.getGuides();
            this.LoadPersons();
        }

        private void LoadPersons()
        {
            try
            {
                RealGameGuides.Clear();
                foreach (var p in _person)
                {
                    RealGameGuides.Add(p);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
