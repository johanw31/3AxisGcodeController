using DynamicData;
using ReactiveUI;
using System.Windows.Input;
using ThreeAxisControl.LogicViewModel;

namespace ThreeAxisControl.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public CncData CncData;
        private AutomaticViewModel automaticViewModel;
        private ManualViewModel manualViewModel;
        private SettingsViewModel settingsViewModel;
        public MainWindowViewModel()
        {
            // Globale CNC Daten
            CncData = new CncData();

            automaticViewModel = new AutomaticViewModel(CncData);
            manualViewModel = new ManualViewModel(CncData);
            settingsViewModel = new SettingsViewModel(CncData);
            // Erste Seite als Startseite setzen
            _CurrentPage = automaticViewModel;

            

            // Observables um den Button zu deaktivieren wenn die Seite die aktuelle ist
            var canNavAutomatic = this.WhenAnyValue(x => x.CurrentPage.CanNavigateAutomatic);
            var canNavManual = this.WhenAnyValue(x => x.CurrentPage.CanNavigateManual);
            var canNavSettings = this.WhenAnyValue(x => x.CurrentPage.CanNavigateSettings);

            NavigateAutomaticViewCommand = ReactiveCommand.Create(NavigateAutomatic, canNavAutomatic);
            NavigateManualViewCommand = ReactiveCommand.Create(NavigateManual, canNavManual);
            NavigateSettingsViewCommand = ReactiveCommand.Create(NavigateSettings, canNavSettings);
        }
        
        // Array mit den vorhandenen Seiten
        /*private readonly PageViewModelBase[] Pages =
        {
            new AutomaticViewModel(),
            new ManualViewModel(),
            new SettingsViewModel()
        };*/

        // The default is the first page
        private PageViewModelBase _CurrentPage;

        /// <summary>
        /// Gets the current page. The property is read-only
        /// </summary>
        public PageViewModelBase CurrentPage
        {
            get { return _CurrentPage; }
            private set { _CurrentPage = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Command für Seite Automatic
        /// </summary>
        public ICommand NavigateAutomaticViewCommand { get; }

        private void NavigateAutomatic()
        {
            CurrentPage = automaticViewModel;
        }

        /// <summary>
        /// Command für Seite Manual
        /// </summary>
        public ICommand NavigateManualViewCommand { get; }

        private void NavigateManual()
        {
            CurrentPage = manualViewModel;
        }

        /// <summary>
        /// Command für Seite Settings
        /// </summary>
        public ICommand NavigateSettingsViewCommand { get; }

        private void NavigateSettings()
        {
            CurrentPage = settingsViewModel;
        }


    }
}
