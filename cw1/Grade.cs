namespace cw1;

public class Grade {
  public int grade { get; set; }
  public Subject subject { get; set; }
  public DateTime date { get; set; }

  public Grade(int grade, Subject subject, DateTime date) {
    if (grade >=1 && grade <= 6) {
      this.grade = grade;
    } else {
      throw new Exception("Grade is to big");
    }
    this.subject = subject;
    this.date = date;
  }
}
