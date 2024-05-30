using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeAxisControl.LogicViewModel;

namespace ThreeAxisControl.ViewModels
{
    public abstract class PageViewModelBase : ViewModelBase
    {
        private CncData _cncData;

        public CncData CncData
        {
            get { return _cncData; }
            set
            {
                _cncData = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// Prüfen ob zu Manual gewechselt werden kann
        /// </summary>
        public abstract bool CanNavigateManual { get; protected set; }

        /// <summary>
        /// Prüfen ob zu Automatic gewechselt werden kann
        /// </summary>
        public abstract bool CanNavigateAutomatic { get; protected set; }

        /// <summary>
        /// Prüfen ob zu Settings gewechselt werden kann
        /// </summary>
        public abstract bool CanNavigateSettings { get; protected set; }
    }
}
