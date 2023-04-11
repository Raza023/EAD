using System;

namespace hello_world
{
	public class Student
	{
        private string name;        //propfull
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Rollno { get; set; }  //prop

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if(value<0)
                {
                    value = 0;
                }
				age = value;
                // if(age<0)
                // {
                //     age=0;
                // }
            }
        }
	}
	
    class Program
    {
		
        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.Name = "Hassan";
            std1.Rollno = "23";
            std1.Age = 21;

            Console.WriteLine(std1.Name);
            Console.WriteLine(std1.Rollno);
            Console.WriteLine(std1.Age);

        }
    }
}
