public class JobInfo
{
    public string Position { get; set; }
    public int Salary { get; set; }

    public JobInfo Clone()
    {
        return (JobInfo)this.MemberwiseClone();
    }
};
