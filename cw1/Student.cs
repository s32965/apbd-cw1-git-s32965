using System.ComponentModel.Design;

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

  public double CalculateGradeAvg(int year) {
    double avg = 0;
    double sum = 0;
    
    foreach (var g in this.grades) {
      if (g.date.Year == year) {  
        sum += g.grade;
      }
    }

    avg = sum/this.grades.Count;
    return avg;
  }

  public Subject GetBestSubjectByAvgGrade() {
    Dictionary<Subject, double> sums = new Dictionary<Subject, double>();
    Dictionary<Subject, int> numOfSub = new Dictionary<Subject, int>();

    foreach (var g in grades) {
      if (sums.ContainsKey(g.subject)) {
        sums[g.subject] += g.grade;
      } else {
        sums.Add(g.subject, g.grade);
      }

      if (numOfSub.ContainsKey(g.subject)) {
        numOfSub[g.subject] += 1;
      } else {
        numOfSub.Add(g.subject, 1);
      }
    }
    Console.WriteLine(sums.Count);
    Console.WriteLine(numOfSub.Count);
  
    double maxAvg = 0;
    Subject? maxAvgSub = null;
    foreach (var key in sums) {
      double avg = sums[key.Key]/numOfSub[key.Key];
      if (avg > maxAvg) {
        maxAvg = avg;
        maxAvgSub = key.Key;
      }
    }

    return maxAvgSub;
  }

  public Subject GetWorstSubjectByAvgGrade() {
    Dictionary<Subject, double> sums = new Dictionary<Subject, double>();
    Dictionary<Subject, int> numOfSub = new Dictionary<Subject, int>();

    foreach (var g in grades) {
      if (sums.ContainsKey(g.subject)) {
        sums[g.subject] += g.grade;
      } else {
        sums.Add(g.subject, g.grade);
      }

      if (numOfSub.ContainsKey(g.subject)) {
        numOfSub[g.subject] += 1;
      } else {
        numOfSub.Add(g.subject, 1);
      }
    }
    Console.WriteLine(sums.Count);
    Console.WriteLine(numOfSub.Count);
  
    double MinAvg = sums[sums.First().Key]/numOfSub[sums.First().Key];
    Subject? MinAvgSub = null;
    foreach (var key in sums) {
      double avg = sums[key.Key]/numOfSub[key.Key];
      if (avg < MinAvg) {
        MinAvg = avg;
        MinAvgSub = key.Key;
      }
    }

    return MinAvgSub;
  }
}
