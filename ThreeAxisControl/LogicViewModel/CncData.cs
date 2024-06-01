using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeAxisControl.ViewModels;

namespace ThreeAxisControl.LogicViewModel
{
    public class CncData : ViewModelBase
    {
        private Manual _manual;
        private Settings _settings;
        private Automatic _automatic;
        public CncData()
        {
            _manual = new Manual();
            _settings = new Settings();
        }

        public Manual Manual
        {
            get => _manual; 
            set
            {
                _manual = value;
                OnPropertyChanged();
            }
        }

        public Settings Settings
        {
            get => _settings;
            set
            {
                _settings = value;
                OnPropertyChanged();
            }
        }

        public Automatic Automatic 
        {   get => _automatic;
            set
            {
                _automatic = value;
                OnPropertyChanged();
            }
        }
    }
}
