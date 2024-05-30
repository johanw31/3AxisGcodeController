using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeAxisControl.ViewModels;

namespace ThreeAxisControl.LogicViewModel
{
    public class Settings : ViewModelBase
    {
        private string _xStepperId = "123";
        public string XStepperId
        {
            get => _xStepperId;
            set
            {
                _xStepperId = value;
                OnPropertyChanged(nameof(XStepperId));
            }
        }

        private string _yStepperId = "";
        public string YStepperId
        {
            get => _yStepperId;
            set
            {
                _yStepperId = value;
                OnPropertyChanged(nameof(YStepperId));
            }
        }

        private string _zStepperId = "";
        public string ZStepperId
        {
            get => _zStepperId;
            set
            {
                _zStepperId = value;
                OnPropertyChanged(nameof(ZStepperId));
            }
        }
    }
    
}
