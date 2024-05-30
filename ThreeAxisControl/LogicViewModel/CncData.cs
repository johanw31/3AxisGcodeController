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
        public CncData() 
        { 
            _manual = new Manual();
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
    }
}
