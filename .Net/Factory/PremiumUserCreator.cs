public class PremiumUserCreator : Creator
{
    public override IAnnouncement FactoryMethod()
    {
        return new PremiumUserAnnouncement();
    }
}