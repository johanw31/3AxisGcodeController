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
        public string? XStepperId { get; set; }
        public string? YStepperId{ get; set; }
        public string? ZStepperId { get; set; }
        public int MaxVelocity{ get; set; }
        public int Acceleration{ get; set; }
        public int Deacceleration{ get; set; }
        public int MotorCurrent{ get; set; }
        public byte StepResolution{ get; set; }
    }
    
}
