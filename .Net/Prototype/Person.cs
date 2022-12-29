public class Person
{
    public string Name { get; set; }
    public DateOnly Birthday { get; set; }
    public JobInfo JobInfo { get; set; }

    public Person Clone()
    {
        var copy = (Person)this.MemberwiseClone();
        copy.JobInfo = this.JobInfo.Clone();
        return copy;
    }
}