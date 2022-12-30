public class RegularUserCreator : Creator
{
    public override IAnnouncement FactoryMethod()
    {
        return new RegularUserAnnouncement();
    }
}