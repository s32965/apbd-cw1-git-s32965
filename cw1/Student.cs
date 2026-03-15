namespace cw1;

public class Student {
  public string name { get; set; }
  public string surname { get; set; }
  public int age { get; set; }
  public DateTime birthDate { get; set; }

  public Student(string name, string surname, int age, DateTime birthDate) {
    this.name = name;
    this.surname = surname;
    this.age = age;
    this.birthDate = birthDate;
  }

  public Student(string name, string surname, DateTime birthDate) {
    this.name = name;
    this.surname = surname;
    this.age = GetAgeFromBirthDate(birthDate);
    this.birthDate = birthDate;
  }

  public static int GetAgeFromBirthDate(DateTime birthDate) {
    int age = DateTime.Now.Year - birthDate.Year;

    if (DateTime.Now < birthDate.AddYears(age)) {
      age--;
    }

    return age;
  }
}
