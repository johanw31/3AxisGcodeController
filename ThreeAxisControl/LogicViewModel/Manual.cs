using Avalonia.Controls;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ThreeAxisControl.ViewModels;

namespace ThreeAxisControl.LogicViewModel
{
    public class Manual : ViewModelBase
    {
        public Manual() 
        { 
        
        }

        private int _xStepperId = 11;
        public int XStepperId
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
