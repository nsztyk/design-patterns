public abstract class Creator
{
    public abstract IAnnouncement FactoryMethod();

    public string SomeOperation()
    {
        var product = FactoryMethod();
        return product.GetWelcomeMessage();
    }
}