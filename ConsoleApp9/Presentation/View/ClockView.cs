using ConsoleApp9.Presentation.ViewModel;

namespace ConsoleApp9.Presentation.View;

public class ClockView
{
    private readonly ClockViewModel _viewModel;

    public ClockView(ClockViewModel clockViewModel) => 
        _viewModel = clockViewModel;

    public void Enable()
    {
        _viewModel.TimeChanged += OnTimeChanged;
        _viewModel.Enable();
    }

    private void OnTimeChanged(string time)
    {
        Console.SetCursorPosition(Console.WindowWidth/2 - time.Length / 2, Console.WindowHeight / 2);
        Console.WriteLine(time);
    }

    public void Disable() => 
        _viewModel.TimeChanged -= OnTimeChanged;
}