namespace cw1;

public class Student {
  public Person person { get; set; }
  public List<Grade> grades { get; set; }

  public Student(string name, string surname, int age, DateTime birthDate) {
    this.person = new Person(name, surname, age, birthDate);
    this.grades = new List<Grade>{};
  }

  public Student(string name, string surname, DateTime birthDate) {
    this.person = new Person(name, surname, birthDate);
    this.grades = new List<Grade>{};
  }

  public void AddGrade(Grade grade) {
    this.grades.Add(grade);
  }

  public double CalculateGradeAvg() {
    double avg = 0;
    double sum = 0;
    
    foreach (var g in this.grades) {
        sum += g.grade;
    }

    avg = sum/this.grades.Count;
    return avg;
  }
}
