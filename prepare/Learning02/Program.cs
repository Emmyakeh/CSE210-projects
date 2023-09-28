using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._jobTitle = "Web Developer";
       job1._companyName = "Google";
       job1._salary = 200000;
       job1._startYear = 2023;
    


       Job job2 = new Job();
       job2._jobTitle = "Software Engineer";
       job2._companyName = "Oracle";
       job2._salary = 1500000;
       job2._startYear = 2023;
      

       Resume yourResume = new Resume();
       yourResume._name = "Emmanuel Akeh";
       
       yourResume._jobs.Add(job1);
       yourResume._jobs.Add(job2);

       yourResume.Display();
    
    }
}