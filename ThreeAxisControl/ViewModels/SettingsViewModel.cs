﻿using System;
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
            _cncData = CncData;
        }
        public string Title => "Welcome to our Wizard-Sample.";

        public string XStepperId
        {
            get { return _cncData.Settings.XStepperId; }
            set { _cncData.Settings.XStepperId = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// The content of this page
        /// </summary>
        public string Message => "Press \"Next\" to register yourself.";

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
