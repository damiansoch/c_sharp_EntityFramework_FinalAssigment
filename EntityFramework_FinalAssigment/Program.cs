using System;
using System.Data.Entity;
using System.Linq;

namespace EntityFramework_FinalAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            //We will now add a student using context class
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };
                ctx.Students.Add(stud);
                ctx.SaveChanges();

                
                
                
                //printing all

                var query = from b in ctx.Students
                          orderby b.StudentName
                            select b;

                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }
            }
        }
    }
}
