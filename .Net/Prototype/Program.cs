var person = new Person()
{
    Birthday = new DateOnly(2000, 8, 16),
    JobInfo = new JobInfo() { Position = "Developer", Salary = 5000 },
    Name = "Norbert"
};

var copy = person.Clone();

var a = copy == person;

var b = copy.Equals(person);

var c = copy.JobInfo == person.JobInfo;

var d = copy.JobInfo.Equals(person.JobInfo);

System.Console.WriteLine("XD");