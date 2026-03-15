namespace cw1;

public class Grade {
  public int grade { get; set; }
  public Subject subject { get; set; }
  public DateTime date { get; set; }

  public Grade(int grade, Subject subject, DateTime date) {
    this.grade = grade;
    this.subject = subject;
    this.date = date;
  }
}
