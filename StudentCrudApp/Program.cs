using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentCrudApp
{
    internal class Program
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the student console app");
            List<Student>students = new List<Student>();
            int Studentid = 1;
            Console.WriteLine("\n STUDENT MANAGEMENT SYSTEM");
            Console.WriteLine("1 : Add Student");
            Console.WriteLine("2 :View existing Students");
            Console.WriteLine("3 :Update student");
            Console.WriteLine("4 :delete student");
            Console.WriteLine("5 :EXIT");
            Console.WriteLine("E N T E R  Y O U R  C H O I C E...");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                    Console.WriteLine("ENTER THE STUDENT NAME");
                    string studentName = Console.ReadLine();
                    Console.WriteLine("ENTER STUDENT AGE");
                    int studentage =Convert.ToInt32(Console.ReadLine());
                    students.Add(new Student { Id = Studentid++, Name = studentName, Age = studentage });

                    Console.WriteLine("Student "+studentName+"- added success");
                    

                    break;
                case 2:
                    Console.WriteLine("\n EXISTING STUDENTS:-");
                    foreach(var student in students)
                    {
                        Console.WriteLine($"student id :{student.Id}student name : {student.Name}student age :{student.Age}");
                    }

                    break;
                case 3:
                    {
                        Console.WriteLine("enter the student ID  you want to update");
                        int updated_id = Convert.ToInt32(Console.ReadLine());
                        var student_update = students.FirstOrDefault(s => s.Id == updated_id);
                        if (student_update != null)
                        {
                            Console.WriteLine("enter the new name");
                            student_update.Name = Console.ReadLine();
                            Console.WriteLine("wnter new age");
                            student_update.Age= Convert.ToInt32( Console.ReadLine());
                            Console.WriteLine("student updated");

                        }
                        else
                        {
                            Console.WriteLine("student not found");
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("enter the student id to delete");
                        int id_delete = Convert.ToInt32(Console.ReadLine());
                        var student_delete = students.FirstOrDefault(s => s.Id == id_delete);
                        if (student_delete != null)
                        {
                            students.Remove(student_delete);
                            Console.WriteLine("student deleted success");
                            
                        }
                        else
                        {
                            Console.WriteLine("student not found");
                        }
                            break;
                
                        
                    }
                case 5:
                    {
                        Console.WriteLine("existing the program.....");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("wrong input ");
                        break;
                    }
                    
            }

        }
    }
}
