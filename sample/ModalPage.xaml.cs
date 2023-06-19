using The49.Maui.BottomSheet.Sample.DemoPages;

namespace The49.Maui.BottomSheet.Sample;

public partial class ModalPage : ContentPage
{
	public ModalPage()
	{
		InitializeComponent();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
		var s = new SimplePage();

		s.Detents = new List<Detent>
		{
			new FullscreenDetent(),
			new ContentDetent(),
		};

		await s.ShowAsync(Window);
    }

    async void ButtonBack_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }
}