using System.Reactive;
using System.Reactive.Linq;
using System.Windows.Input;
using ReactiveUI;

namespace SevenGUIs.Counter;

public class MainViewModel : ReactiveObject
{
    private int _count = 0;

    public MainViewModel()
    {
        IncreaseCountCommand = ReactiveCommand.Create(IncreaseCount);
    }

    public ReactiveCommand<Unit, Unit> IncreaseCountCommand { get; }

    public int Count
    {
        get => _count;
        set => this.RaiseAndSetIfChanged(ref _count, value);
    }

    public void IncreaseCount()
    {
        Count += 1;
    }
}