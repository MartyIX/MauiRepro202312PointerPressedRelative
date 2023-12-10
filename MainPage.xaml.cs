namespace MauiPointerPressedRelative;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void PointerGestureRecognizer_PointerMoved(object sender, PointerEventArgs e)
    {
        Point? position = e.GetPosition(relativeTo: (View)sender);
        this.debugLabel.Text = $"Position {position}; Pointer MOVED.";
    }

    private void PointerGestureRecognizer_PointerPressed(object sender, PointerEventArgs e)
    {
        Point? position = e.GetPosition(relativeTo: (View)sender);
        this.debugLabel.Text = $"Position {position}; Pointer PRESSED.";
    }

    private void PointerGestureRecognizer_PointerReleased(object sender, PointerEventArgs e)
    {
        Point? position = e.GetPosition(relativeTo: (View)sender);
        this.debugLabel.Text = $"Position {position}; Pointer RELEASED.";
    }
}

