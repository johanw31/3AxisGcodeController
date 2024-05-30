using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeAxisControl.LogicViewModel;

namespace ThreeAxisControl.ViewModels
{
    public class AutomaticViewModel : PageViewModelBase
    {
        private readonly CncData? _cncData;
        public AutomaticViewModel() 
        {
        }
        public AutomaticViewModel(CncData CncData)
        {
            _cncData = CncData;
        }
        public string Title => "3 Axis Controller";


        /// <summary>
        /// Es darf auf Manual gewechselt werdem
        /// </summary>
        public override bool CanNavigateManual
        {
            get => true;
            protected set => throw new NotSupportedException();
        }

        /// <summary>
        /// Automatic Seite ist gerade aufgerufen
        /// </summary>
        public override bool CanNavigateAutomatic
        {
            get => false;
            protected set => throw new NotSupportedException();
        }

        /// <summary>
        /// Es darf auf Settings Seite gewechselt werden
        /// </summary>
        public override bool CanNavigateSettings
        {
            get => true;
            protected set => throw new NotSupportedException();
        }
    }
}
