namespace cw1;

public class Project {
  public static void Main(String[] args) {
    Student s = new Student("Jan", "Kowalski", 26, new DateTime(2000, 1, 1));
    Student s2 = new Student("Test", "Test", new DateTime(2000, 1, 1));
    Student s3 = new Student("Test2", "Test2", new DateTime(2000, 5, 5));

    Console.WriteLine(s2.age);
    Console.WriteLine(s3.age);
  }
}
