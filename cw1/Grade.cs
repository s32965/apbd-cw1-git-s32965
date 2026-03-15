namespace cw1;

public class Grade {
  public int grade { get; set; }
  public string subject { get; set; }
  public DateTime date { get; set; }

  public Grade(int grade, string subject, DateTime date) {
    this.grade = grade;
    this.subject = subject;
    this.date = date;
  }
}
