using Examen_Mvvm.ViewModels;

namespace Examen_Mvvm.Views;

public partial class Des : ContentPage
{
	DesViewModels ViewModels;
	public Des()
	{
		InitializeComponent();
		ViewModels = new DesViewModels();
		BindingContext = ViewModels;
	}
}