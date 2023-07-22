using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace UasKomber.ViewModels;

public partial class LoginPageViewModel : BaseViewModel
{
	[ObservableProperty]
	private string _username;
	[ObservableProperty]
	private string _password;

	[ICommand]
	public async void Login()
	{

	}
}