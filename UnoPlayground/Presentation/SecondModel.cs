namespace UnoPlayground.Presentation;

public partial record SecondModel(Entity Entity)
{
    public Data Data { get; } = new Data(); // todo optymalizować jakies ropo i tu wstryknąć
}
