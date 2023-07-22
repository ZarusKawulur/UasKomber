using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace UasKomber.ViewModels;



    public partial class BaseViewModel : ObservableObject
{
    public bool _isbusy;

    [ObservableProperty]
    public bool _isBusy;
    [ObservableProperty]
    public string _title;

}




