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
        public CncData() 
        { 
            _manual = new Manual();
            _settings = new Settings();
        }

        public Manual Manual
        {
            get { return _manual; }
            set 
            {
                _manual = value;
                OnPropertyChanged();
            }
        }

        public Settings Settings
        {
            get { return _settings; }
            set
            {
                _settings = value;
                OnPropertyChanged();
            }
        }
    }
}
