using Exercise3.Models;
using System;
using System.Net.Http;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60464/api/students");
                //HTTP GET
                var responseTask = client.GetAsync("GetStudent?name=Mushtaq&age=25");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<Student[]>();
                    readTask.Wait();

                    var students = readTask.Result;

                    foreach (var student in students)
                    {
                        Console.WriteLine(student.name);
                    }
                }
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60464/api/students");
                var student = new Student() { name = "Mushtaq", age = 25 };
                //HTTP POST
                var responseTask = client.PostAsJsonAsync("GetStudentId", student);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<Student[]>();
                    readTask.Wait();

                    var students = readTask.Result;

                    foreach (var student1 in students)
                    {
                        Console.WriteLine(student1.name);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
