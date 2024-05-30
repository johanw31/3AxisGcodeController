using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeAxisControl.LogicViewModel;

namespace ThreeAxisControl.ViewModels
{
    public class ManualViewModel : PageViewModelBase
    {
        private readonly CncData? _cncData;
        public ManualViewModel()
        {
        }
        public ManualViewModel(CncData CncData)
        {
            _cncData = CncData;
        }

        // Dependency Injektion Test
        public string XStepperId
        {
            get { return _cncData.Settings.XStepperId; }
            set
            {
                _cncData.Settings.XStepperId = value;
                OnPropertyChanged();
            }
        }

        private bool _CanNavigateNext;

        /// <summary>
        /// Manual Seite ist gerade aufgerufen
        /// </summary>
        public override bool CanNavigateManual
        {
            get => false;
            protected set => throw new NotSupportedException();
        }


        /// <summary>
        /// Es darf auf Automatic gewechselt werdem
        /// </summary>
        public override bool CanNavigateAutomatic
        {
            get => true;
            protected set => throw new NotSupportedException();
        }
        /// <summary>
        /// Es darf auf Settings gewechselt werdem
        /// </summary>
        public override bool CanNavigateSettings
        {
            get => true;
            protected set => throw new NotSupportedException();
        }
    }
}
