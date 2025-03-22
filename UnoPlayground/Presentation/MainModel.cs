namespace UnoPlayground.Presentation;

public partial record MainModel
{
    private INavigator _navigator;

    public MainModel(
        IStringLocalizer localizer,
        IOptions<AppConfig> appInfo,
        INavigator navigator)
    {
        _navigator = navigator;
        Title = "Main";
        Title += $" - {localizer["ApplicationName"]}";
        Title += $" - {appInfo?.Value?.Environment}";
    }

    public Data Data { get; } = new Data();

    public string? Title { get; }

    //public IState<string> Name => State<string>.Value(this, () => string.Empty);

    public async Task GoToSecond()
    {
        //var name = await Name;
        await _navigator.NavigateViewModelAsync<SecondModel>(this, data: new Entity(""));
    }

}
