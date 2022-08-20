enum GenderType
{
	Male,
	Female,
	Transgender
}
enum EducationCourseType
{
	CSE,
	EEE,
	ECE,
	ISE,
	EIE
}

class Student
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public GenderType Gender { get; set; }
	public EducationCourseType Course { get; set; }
}
class Program
{
	static void Main()
	{
		Student logesh = new Student();
		logesh.FirstName = "Logesh";
		logesh.LastName = "Rajan";
		logesh.Gender = GenderType.Male;
		logesh.Course = EducationCourseType.EEE;

		Student stutee = new Student();
		stutee.FirstName = "Stutee";
		stutee.LastName = "Rath";
		stutee.Gender = GenderType.Female;
		stutee.Course = EducationCourseType.CSE;

		Console.WriteLine($"Logesh Name={logesh.FirstName} {logesh.LastName}, Gender={logesh.Gender}, Course={(int)logesh.Course}");
		Console.WriteLine($"Stutee Name={stutee.FirstName} {stutee.LastName}, Gender={(int)stutee.Gender}, Course={stutee.Course}");
		//Console.WriteLine($"{(GenderType)2}");
		Console.Read();
	}
}