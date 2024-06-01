using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeAxisControl.LogicViewModel;

namespace ThreeAxisControl.ViewModels
{
    public class SettingsViewModel : PageViewModelBase
    {
        private readonly CncData? _cncData;
        public SettingsViewModel()
        {
        }
        public SettingsViewModel(CncData CncData)
        {
            if (CncData is not null)
            {
                _cncData = CncData;
            }
            else
            {
                _cncData = new CncData();
                throw new Exception("CNC Data war null");
            }
        }

        public string XStepperId
        {
            get => _cncData.Settings.XStepperId;
            set 
            {   
                _cncData.Settings.XStepperId = value; 
                OnPropertyChanged(); 
            }
        }

        public string YStepperId
        {
            get => _cncData.Settings.XStepperId;
            set
            {
                _cncData.Settings.XStepperId = value;
                OnPropertyChanged();
            }
        }

        public string ZStepperId
        {
            get => _cncData.Settings.XStepperId;
            set
            {
                _cncData.Settings.XStepperId = value;
                OnPropertyChanged();
            }
        }

        public int MaxVelocity
        {
            get => _cncData.Settings.MaxVelocity;
            set
            {
                _cncData.Settings.MaxVelocity = value;
                OnPropertyChanged();
            }
        }

        public int Acceleration
        {
            get => _cncData.Settings.Acceleration;
            set
            {
                _cncData.Settings.Acceleration = value;
                OnPropertyChanged();
            }
        }

        public int Deacceleration
        {
            get => _cncData.Settings.Deacceleration;
            set
            {
                _cncData.Settings.Deacceleration = value;
                OnPropertyChanged();
            }
        }

        public int MotorCurrent
        {
            get => _cncData.Settings.MotorCurrent;
            set
            {
                _cncData.Settings.MotorCurrent = value;
                OnPropertyChanged();
            }
        }

        public byte StepResolution
        {
            get => _cncData.Settings.StepResolution;
            set
            {
                _cncData.Settings.StepResolution = value;
                OnPropertyChanged();
            }
        }









        /// <summary>
        /// Es darf auf Manual gewechselt werden
        /// </summary>
        public override bool CanNavigateManual
        {
            get => true;
            protected set => throw new NotSupportedException();
        }

        /// <summary>
        /// Es darf auf Automatic gewechselt werden
        /// </summary>
        public override bool CanNavigateAutomatic
        {
            get => true;
            protected set => throw new NotSupportedException();
        }

        /// <summary>
        /// Automatic Seite ist gerade aufgerufen
        /// </summary>
        public override bool CanNavigateSettings
        {
            get => false;
            protected set => throw new NotSupportedException();
        }
    }
}
