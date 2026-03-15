namespace cw1;

public class Subject {
  public string name { get; set; }
  public Person teacher { get; set; }
  
  public Subject(string name, Person teacher) {
    this.name = name;
    this.teacher = teacher;
  }
}
