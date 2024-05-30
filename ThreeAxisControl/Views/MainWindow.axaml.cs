using Avalonia.Controls;
using Avalonia.Interactivity;
using ThreeAxisControl.LogicViewModel;

namespace ThreeAxisControl.Views;

public partial class MainWindow : Window
{
    CncData _mainController;
    public MainWindow()
    {
        InitializeComponent();
    }
}
