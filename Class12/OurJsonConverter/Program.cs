using OurJsonConverter.Entities;
using OurJsonConverter.Utils;

Student student = new Student();
student.FirstName = "Zoka";
student.LastName = "Malinovic";
student.IsPartTime = true;

StudentJsonConverter converter = new StudentJsonConverter();

string json = converter.SerializeStudent(student);

Student noviStudent = converter.DeserializeStudent(json);