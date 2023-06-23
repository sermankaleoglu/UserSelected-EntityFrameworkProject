using Azure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace KullanıcıGirişliEF
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please select an option");
                Console.WriteLine("1-Adding Data");
                Console.WriteLine("2-Deleting Data");
                Console.WriteLine("3-Updating Data");
                Console.WriteLine("4-List Data");
                Console.WriteLine("5-Filter Data by Name");
                Console.WriteLine("6-Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddData();
                        break;
                    case 2:
                        DeleteData();
                        break;
                    case 3:
                        UpdateData();
                        break;
                    case 4:
                        ListData();
                        break;
                    case 5:
                        FilterDataByName();
                        break;
                    case 6:
                        return;
                    default:
                        break;
                }
            }
        }
        static void AddData()
        {
            using (var db = new CourseContext())
            {
                Console.WriteLine("Select your table which is you want to add data..:");
                Console.WriteLine("1-Instructor");
                Console.WriteLine("2-Student");
                Console.WriteLine("3-Personel");
                Console.WriteLine("4-Course");
                Console.WriteLine("5-Class");
                Console.WriteLine("6-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    while (true)
                    {
                        Console.Write("Write Instructor Name: ");
                        string InstructorName = Console.ReadLine();

                        Console.Write("Write Instructor Surname: ");
                        string InstructorSurname = Console.ReadLine();

                        Console.Write("Write Instructor Age: ");
                        int InstructorAge = Convert.ToInt32(Console.ReadLine());

                        var instructor = new Instructor { InstructorName = InstructorName, InstructorSurname = InstructorSurname, InstructorAge = InstructorAge };

                        db.Instructor.Add(instructor);
                        db.SaveChanges();
                        Console.WriteLine("Data added successfully!");

                        Console.WriteLine("Do you want to add new data to this table?");
                        Console.WriteLine("1-Yes");
                        Console.WriteLine("2-No");
                        int choice2 = Convert.ToInt32(Console.ReadLine());
                        if (choice2 == 1)
                        {
                            Console.WriteLine("You can add new data");
                        }
                        else if (choice2 == 2)
                        {
                            break;
                        }
                    }
                }
                else if (choice == 2)
                {
                    while (true)
                    {
                        Console.Write("Write Student Name: ");
                        string StudentName = Console.ReadLine();

                        Console.Write("Write Student Surname: ");
                        string StudentSurname = Console.ReadLine();

                        Console.Write("Write Student Age: ");
                        int StudentAge = Convert.ToInt32(Console.ReadLine());

                        var student = new Student { StudentName = StudentName, StudentSurname = StudentSurname, StudentAge = StudentAge };

                        db.Student.Add(student);
                        db.SaveChanges();
                        Console.WriteLine("Data added successfully!");

                        Console.WriteLine("Do you want to add new data to this table?");
                        Console.WriteLine("1-Yes");
                        Console.WriteLine("2-No");
                        int choice2 = Convert.ToInt32(Console.ReadLine());
                        if (choice2 == 1)
                        {
                            Console.WriteLine("You can add new data");
                        }
                        else if (choice2 == 2)
                        {
                            break;
                        }
                    }
                }
                else if (choice == 3)
                {
                    while (true)
                    {
                        Console.Write("Write Personel Name: ");
                        string PersonelName = Console.ReadLine();

                        Console.Write("Write Personel Surname: ");
                        string PersonelSurname = Console.ReadLine();

                        Console.Write("Write Personel Age: ");
                        int PersonelAge = Convert.ToInt32(Console.ReadLine());

                        var personel = new Personel { PersonelName = PersonelName, PersonelSurname = PersonelSurname, PersonelAge = PersonelAge };

                        db.Personel.Add(personel);
                        db.SaveChanges();
                        Console.WriteLine("Data added successfully!");

                        Console.WriteLine("Do you want to add new data to this table?");
                        Console.WriteLine("1-Yes");
                        Console.WriteLine("2-No");
                        int choice2 = Convert.ToInt32(Console.ReadLine());
                        if (choice2 == 1)
                        {
                            Console.WriteLine("You can add new data");
                        }
                        else if (choice2 == 2)
                        {
                            break;
                        }
                    }
                }
                else if (choice == 4)
                {
                    while (true)
                    {
                        Console.Write("Write Course Name: ");
                        string CourseName = Console.ReadLine();

                        Console.Write("Write Course Start Date: ");
                        DateTime CourseStartDate = DateTime.Parse(Console.ReadLine());

                        Console.Write("Write Course Start Date: ");
                        DateTime CourseEndDate = DateTime.Parse(Console.ReadLine());

                        var course = new Course { CourseName = CourseName, CourseStartDate = CourseStartDate, CourseEndDate = CourseEndDate };

                        db.Course.Add(course);
                        db.SaveChanges();
                        Console.WriteLine("Data added successfully!");
                        Console.WriteLine("Do you want to add new data to this table?");
                        Console.WriteLine("1-Yes");
                        Console.WriteLine("2-No");
                        int choice2 = Convert.ToInt32(Console.ReadLine());
                        if (choice2 == 1)
                        {
                            Console.WriteLine("You can add new data");
                        }
                        else if (choice2 == 2)
                        {
                            break;
                        }
                    }
                }
                else if (choice == 5)
                {
                    while (true)
                    {
                        Console.Write("Is There projeksiyon in this class: ");
                        bool Projeksiyon = Convert.ToBoolean(Console.ReadLine());

                        Console.Write("Is There HDMI in this class: ");
                        bool Hdmı = Convert.ToBoolean(Console.ReadLine());

                        var CourseClass = new Class { Projeksiyon = Projeksiyon, HDMI = Hdmı };

                        db.Class.Add(CourseClass);
                        db.SaveChanges();
                        Console.WriteLine("Data added successfully!");
                        Console.WriteLine("Do you want to add new data to this table?");
                        Console.WriteLine("1-Yes");
                        Console.WriteLine("2-No");
                        int choice2 = Convert.ToInt32(Console.ReadLine());
                        if (choice2 == 1)
                        {
                            Console.WriteLine("You can add new data");
                        }
                        else if (choice2 == 2)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong enterance!!!");
                }
            }
        }
        static void DeleteData()
        {
            using (var db = new CourseContext())
            {
                Console.WriteLine("Select your table which is you want to delete data.");
                Console.WriteLine("1-Instructor");
                Console.WriteLine("2-Student");
                Console.WriteLine("3-Personel");
                Console.WriteLine("4-Course");
                Console.WriteLine("5-Class");
                Console.WriteLine("6-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Write your data id which is you want to delete..: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var instructor = db.Instructor.Where(instructor => instructor.InstructorID == id).FirstOrDefault();
                    if (instructor != null)
                    {
                        db.Remove(instructor);
                        db.SaveChanges();
                        Console.WriteLine("Record Deleted!!");
                    }

                }
                else if (choice == 2)
                {
                    Console.Write("Write your data id which is you want to delete..: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var student = db.Student.Where(student => student.StudentID == id).FirstOrDefault();
                    if (student != null)
                    {
                        db.Remove(student);
                        db.SaveChanges();
                        Console.WriteLine("Record Deleted!!");
                    }
                }
                else if (choice == 3)
                {
                    Console.Write("Write your data id which is you want to delete..: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var personel = db.Personel.Where(personel => personel.PersonelID == id).FirstOrDefault();
                    if (personel != null)
                    {
                        db.Remove(personel);
                        db.SaveChanges();
                        Console.WriteLine("Record Deleted!!");
                    }
                }
                else if (choice == 4)
                {
                    Console.Write("Write your data id which is you want to delete..: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var course = db.Course.Where(course => course.CourseID == id).FirstOrDefault();
                    if (course != null)
                    {
                        db.Remove(course);
                        db.SaveChanges();
                        Console.WriteLine("Record Deleted!!");
                    }
                }
                else if (choice == 5)
                {
                    Console.Write("Write your data id which is you want to delete..: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var CourseClass = db.Class.Where(CourseClass => CourseClass.ClassID == id).FirstOrDefault();
                    if (CourseClass != null)
                    {
                        db.Remove(CourseClass);
                        db.SaveChanges();
                        Console.WriteLine("Record Deleted!!");
                    }
                }
            }
        }
        static void UpdateData()
        {
            using (var db = new CourseContext())
            {
                Console.WriteLine("Select your table which is you want to update data.");
                Console.WriteLine("1-Instructor");
                Console.WriteLine("2-Student");
                Console.WriteLine("3-Personel");
                Console.WriteLine("4-Course");
                Console.WriteLine("5-Class");
                Console.WriteLine("6-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Write your data id which is you want to update..: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var instructor = db.Instructor.Where(instructor => instructor.InstructorID == id).FirstOrDefault();
                    if (instructor != null)
                    {
                        Console.WriteLine("1-Do you want to update all data?");
                        Console.WriteLine("2-Do you want to update ONLY one data?");
                        int choice1 = Convert.ToInt32(Console.ReadLine());
                        switch (choice1)
                        {
                            case 1:
                                Console.Write("Write  new Name..: ");
                                instructor.InstructorName = Console.ReadLine();
                                Console.Write("Write  new Surname..: ");
                                instructor.InstructorSurname = Console.ReadLine();
                                Console.Write("Write  new Age..: ");
                                instructor.InstructorAge = Convert.ToInt32(Console.ReadLine());
                                db.SaveChanges();
                                break;
                            case 2:
                                Console.WriteLine("Which data you want to update?");
                                Console.WriteLine("1-Name");
                                Console.WriteLine("2-Surname");
                                Console.WriteLine("3-Age");

                                int choice2 = Convert.ToInt32(Console.ReadLine());
                                if (choice2 == 1)
                                {
                                    Console.Write("Write  new Name..: ");
                                    instructor.InstructorName = Console.ReadLine();
                                    db.SaveChanges();
                                }
                                else if (choice2 == 2)
                                {
                                    Console.Write("Write  new Surname..: ");
                                    instructor.InstructorSurname = Console.ReadLine();
                                    db.SaveChanges();
                                }
                                else if (choice2 == 3)
                                {
                                    Console.Write("Write  new Age..: ");
                                    instructor.InstructorAge = Convert.ToInt32(Console.ReadLine());
                                    db.SaveChanges();
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
                if (choice == 2)
                {
                    Console.Write("Write your data id which is you want to update..: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var student = db.Student.Where(student => student.StudentID == id).FirstOrDefault();
                    if (student != null)
                    {
                        Console.WriteLine("1-Do you want to update all data?");
                        Console.WriteLine("2-Do you want to update ONLY one data?");
                        int choice1 = Convert.ToInt32(Console.ReadLine());
                        switch (choice1)
                        {
                            case 1:
                                Console.Write("Write  new Name..: ");
                                student.StudentName = Console.ReadLine();
                                Console.Write("Write  new Surname..: ");
                                student.StudentSurname = Console.ReadLine();
                                Console.Write("Write  new Age..: ");
                                student.StudentAge = Convert.ToInt32(Console.ReadLine());
                                db.SaveChanges();
                                break;
                            case 2:
                                Console.WriteLine("Which data you want to updata?");
                                Console.WriteLine("Name");
                                Console.WriteLine("Surname");
                                Console.WriteLine("Age");
                                int choice2 = Convert.ToInt32(Console.ReadLine());
                                if (choice2 == 1)
                                {
                                    Console.Write("Write  new Name..: ");
                                    student.StudentName = Console.ReadLine();
                                    db.SaveChanges();
                                }
                                else if (choice2 == 2)
                                {
                                    Console.Write("Write  new Surname..: ");
                                    student.StudentSurname = Console.ReadLine();
                                    db.SaveChanges();
                                }
                                else if (choice2 == 3)
                                {
                                    Console.Write("Write  new Age..: ");
                                    student.StudentAge = Convert.ToInt32(Console.ReadLine());
                                    db.SaveChanges();
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
                if (choice == 3)
                {
                    Console.Write("Write your data id which is you want to update..: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var personel = db.Personel.Where(personel => personel.PersonelID == id).FirstOrDefault();
                    if (personel != null)
                    {
                        Console.WriteLine("1-Do you want to update all data?");
                        Console.WriteLine("2-Do you want to update ONLY one data?");
                        int choice1 = Convert.ToInt32(Console.ReadLine());
                        switch (choice1)
                        {
                            case '1':
                                Console.Write("Write  new Name..: ");
                                personel.PersonelName = Console.ReadLine();
                                Console.Write("Write  new Surname..: ");
                                personel.PersonelSurname = Console.ReadLine();
                                Console.Write("Write  new Age..: ");
                                personel.PersonelAge = Convert.ToInt32(Console.ReadLine());
                                db.SaveChanges();
                                break;
                            case '2':
                                Console.WriteLine("Which data you want to updata?");
                                string choice2 = Console.ReadLine();
                                if (choice2 == "Name")
                                {
                                    Console.Write("Write  new Name..: ");
                                    personel.PersonelName = Console.ReadLine();
                                    db.SaveChanges();
                                }
                                else if (choice2 == "Surname")
                                {
                                    Console.Write("Write  new Surname..: ");
                                    personel.PersonelSurname = Console.ReadLine();
                                    db.SaveChanges();
                                }
                                else if (choice2 == "Age")
                                {
                                    Console.Write("Write  new Age..: ");
                                    personel.PersonelAge = Convert.ToInt32(Console.ReadLine());
                                    db.SaveChanges();
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
                if (choice == 4)
                {
                    Console.Write("Write your data id which is you want to update..: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var course = db.Course.Where(course => course.CourseID == id).FirstOrDefault();
                    if (course != null)
                    {
                        Console.WriteLine("1-Do you want to update all data?");
                        Console.WriteLine("2-Do you want to update ONLY one data?");
                        int choice1 = Convert.ToInt32(Console.ReadLine());
                        switch (choice1)
                        {
                            case '1':
                                Console.Write("Write  new Name..: ");
                                course.CourseName = Console.ReadLine();
                                Console.Write("Write  new StartDate..: ");
                                course.CourseStartDate = DateTime.Parse(Console.ReadLine());
                                Console.Write("Write  new EndDate..: ");
                                course.CourseEndDate = DateTime.Parse(Console.ReadLine());
                                db.SaveChanges();
                                break;
                            case '2':
                                Console.WriteLine("Which data you want to updata?");
                                string choice2 = Console.ReadLine();
                                if (choice2 == "Name")
                                {
                                    Console.Write("Write  new Name..: ");
                                    course.CourseName = Console.ReadLine();
                                    db.SaveChanges();
                                }
                                else if (choice2 == "StartDate")
                                {
                                    Console.Write("Write  new StartDate..: ");
                                    course.CourseStartDate = DateTime.Parse(Console.ReadLine());
                                    db.SaveChanges();
                                }
                                else if (choice2 == "EndDate")
                                {
                                    Console.Write("Write  new Age..: ");
                                    course.CourseEndDate = DateTime.Parse(Console.ReadLine());
                                    db.SaveChanges();
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
                /*if (choice == 5)
                {
                    Console.Write("Write your data id which is you want to update..: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var CourseClass = db.Class.Where(CourseClass => CourseClass.ClassID == id).FirstOrDefault();
                    if (CourseClass != null)
                    {
                        Console.WriteLine("1-Do you want to update all data?");
                        Console.WriteLine("2-Do you want to update ONLY one data?");
                        int choice1 = Convert.ToInt32(Console.ReadLine());
                        switch (choice1)
                        {
                            case '1':
                                Console.Write("Write  new Name..: ");
                                CourseClass.ClassName = Console.ReadLine();
                                Console.Write("Write  new Surname..: ");
                                CourseClass.InstructorSurname = Console.ReadLine();
                                Console.Write("Write  new Age..: ");
                                CourseClass.InstructorAge = Convert.ToInt32(Console.ReadLine());
                                db.SaveChanges();
                                break;
                            case '2':
                                Console.WriteLine("Which data you want to updata?");
                                string choice2 = Console.ReadLine();
                                if (choice2 == "Name")
                                {
                                    Console.Write("Write  new Name..: ");
                                    CourseClass.InstructorName = Console.ReadLine();
                                    db.SaveChanges();
                                }
                                else if (choice2 == "Surname")
                                {
                                    Console.Write("Write  new Surname..: ");
                                    CourseClass.InstructorSurname = Console.ReadLine();
                                    db.SaveChanges();
                                }
                                else if (choice2 == "Age")
                                {
                                    Console.Write("Write  new Age..: ");
                                    CourseClass.InstructorAge = Convert.ToInt32(Console.ReadLine());
                                    db.SaveChanges();
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }*/
            }
        }
        static void ListData()
        {
            using (var db = new CourseContext())
            {
                Console.WriteLine("Which table do you want to list?");
                Console.WriteLine("1-Instructor");
                Console.WriteLine("2-Student");
                Console.WriteLine("3-Personel");
                Console.WriteLine("4-Course");
                Console.WriteLine("5-Class");
                Console.WriteLine("6-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    var instructor = db.Instructor.ToList();
                    foreach (var data in instructor)
                    {
                        Console.WriteLine($"Name:{data.InstructorName}\t\t Surname:{data.InstructorSurname}");
                    }
                }
                else if (choice == 2)
                {
                    var student = db.Student.ToList();
                    foreach (var data in student)
                    {
                        Console.WriteLine($"Name:{data.StudentName}\t\t Surname:{data.StudentSurname}");
                    }
                }
                else if (choice == 3)
                {
                    var personel = db.Personel.ToList();
                    foreach (var data in personel)
                    {
                        Console.WriteLine($"Name:{data.PersonelName}\t\t Surname:{data.PersonelSurname}");
                    }
                }
                else if (choice == 4)
                {
                    var course = db.Course.ToList();
                    foreach (var data in course)
                    {
                        Console.WriteLine($"Name:{data.CourseName}\t\t StartDate:{data.CourseStartDate}\t\t EndDate:{data.CourseEndDate}");
                    }
                }
                /*else if (choice == 5)
                {
                    var CourseClass = db.Class.ToList();
                    foreach (var data in CourseClass)
                    {
                        Console.WriteLine($"Name:{data.InstructorName}\t\t Surname:{data.InstructorSurname}");
                    }
                }*/
                else
                {
                    Console.WriteLine("Wrong enterance!!!");
                }
            }
        }
        static void FilterDataByName()
        {
            using (var db = new CourseContext())
            {
                Console.WriteLine("Select table you want to filter by name..");
                Console.WriteLine("1-Instructor");
                Console.WriteLine("2-Student");
                Console.WriteLine("3-Personel");
                Console.WriteLine("4-Course");
                Console.WriteLine("5-Class");
                Console.WriteLine("6-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Write filter name..:");
                    string name = Console.ReadLine();
                    var instructor = db.Instructor.Where(instructor => instructor.InstructorName == name).FirstOrDefault();
                    Console.WriteLine($"Name:{instructor.InstructorName}\t\t Surname:{instructor.InstructorSurname}");
                }
                else if (choice == 2)
                {
                    Console.Write("Write filter name..:");
                    string name = Console.ReadLine();
                    var student = db.Student.Where(student => student.StudentName == name).FirstOrDefault();
                    Console.WriteLine($"Name:{student.StudentName}\t\t Surname:{student.StudentSurname}");
                }
                else if (choice == 3)
                {
                    Console.Write("Write filter name..:");
                    string name = Console.ReadLine();
                    var personel = db.Personel.Where(personel => personel.PersonelName == name).FirstOrDefault();
                    Console.WriteLine($"Name:{personel.PersonelName}\t\t Surname:{personel.PersonelSurname}");
                }
                else if (choice == 4)
                {
                    Console.Write("Write filter name..:");
                    string name = Console.ReadLine();
                    var course = db.Course.Where(course => course.CourseName == name).FirstOrDefault();
                    Console.WriteLine($"Name:{course.CourseName}\t\t StartDate:{course.CourseStartDate}\t\t EndDate:{course.CourseEndDate}");
                }
                /*if (choice == 5)
                {                    
                    Console.Write("Write filter name..:");
                    string name = Console.ReadLine();
                    var CourseClass = db.Instructor.Where(CourseClass => CourseClass.InstructorName == name).FirstOrDefault();
                    Console.WriteLine($"Name:{CourseClass.InstructorName}\t\t Surname:{instructor.InstructorSurname}");
                }*/
                else
                {
                    Console.WriteLine("Wrong enterance!!!");
                }
            }
        }
    }
}