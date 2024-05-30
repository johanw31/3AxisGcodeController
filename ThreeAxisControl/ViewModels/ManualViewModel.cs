using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeAxisControl.ViewModels
{
    public class ManualViewModel : PageViewModelBase
    {
        public ManualViewModel()
        {
            // Listen to changes of MailAddress and Password and update CanNavigateNext accordingly
            //this.WhenAnyValue(x => x.MailAddress, x => x.Password)
            //    .Subscribe(_ => UpdateCanNavigateNext());
        }


        private string? _MailAddress;

        /// <summary>
        /// The E-Mail of the user. This field is required
        /// </summary>
        [Required]
        [EmailAddress]
        public string? MailAddress
        {
            get { return _MailAddress; }
            set { _MailAddress= value; OnPropertyChanged(); }
        }


        private string? _Password;

        /// <summary>
        /// The password of the user. This field is required.
        /// </summary>
        [Required]
        public string? Password
        {
            get { return _Password; }
            set { _Password = value; OnPropertyChanged(); }
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
