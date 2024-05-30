using DynamicData;
using ReactiveUI;
using System.Windows.Input;

namespace ThreeAxisControl.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            // Erste Seite als Startseite setzen
            _CurrentPage = Pages[0];

            // Observables um den Button zu deaktivieren wenn die Seite die aktuelle ist
            var canNavAutomatic = this.WhenAnyValue(x => x.CurrentPage.CanNavigateAutomatic);
            var canNavManual = this.WhenAnyValue(x => x.CurrentPage.CanNavigateManual);
            var canNavSettings = this.WhenAnyValue(x => x.CurrentPage.CanNavigateSettings);

            NavigateAutomaticViewCommand = ReactiveCommand.Create(NavigateAutomatic, canNavAutomatic);
            NavigateManualViewCommand = ReactiveCommand.Create(NavigateManual, canNavManual);
            NavigateSettingsViewCommand = ReactiveCommand.Create(NavigateSettings, canNavSettings);
        }

        // Array mit den vorhandenen Seiten
        private readonly PageViewModelBase[] Pages =
        {
            new AutomaticViewModel(),
            new ManualViewModel(),
            new SettingsViewModel()
        };

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
            CurrentPage = Pages[0];
        }

        /// <summary>
        /// Command für Seite Manual
        /// </summary>
        public ICommand NavigateManualViewCommand { get; }

        private void NavigateManual()
        {
            CurrentPage = Pages[1];
        }

        /// <summary>
        /// Command für Seite Settings
        /// </summary>
        public ICommand NavigateSettingsViewCommand { get; }

        private void NavigateSettings()
        {
            CurrentPage = Pages[2];
        }


    }
}
