namespace cw1;

public class Project {
  public static void Main(String[] args) {
    Student s1 = new Student("Jan", "Kowalski", DateTime.Now);

    Subject math = new Subject("math", new Person("Mathe", "Matic", DateTime.Now));
    Subject english = new Subject("english", new Person("Johnny", "English", DateTime.Now));

    s1.AddGrade(new Grade(5, math, DateTime.Now));
    s1.AddGrade(new Grade(6, math, DateTime.Now));
    s1.AddGrade(new Grade(6, english, DateTime.Now));
    s1.AddGrade(new Grade(6, english, DateTime.Now));
    s1.AddGrade(new Grade(1, english, DateTime.Now));

    Console.WriteLine(s1.grades.Count);
    Console.WriteLine(s1.GetBestSubjectByAvgGrade().name);
    Console.WriteLine(s1.GetWorstSubjectByAvgGrade().name);
  }
}
