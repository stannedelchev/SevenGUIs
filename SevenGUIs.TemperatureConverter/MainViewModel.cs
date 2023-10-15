using ReactiveUI;

namespace SevenGUIs.TemperatureConverter;

public class MainViewModel : ReactiveObject
{
    private decimal? _celsius;
    private decimal? _fahrenheit;

    public decimal? Celsius
    {
        get => _celsius;
        set
        {
            this.RaiseAndSetIfChanged(ref _celsius, value);

            _fahrenheit = value * 9m / 5m + 32;
            this.RaisePropertyChanged(nameof(Fahrenheit));
        }
    }

    public decimal? Fahrenheit
    {
        get => _fahrenheit;
        set
        {
            this.RaiseAndSetIfChanged(ref _fahrenheit, value);

            _celsius = (value - 32) * (5m / 9m);
            this.RaisePropertyChanged(nameof(Celsius));
        }
    }
}