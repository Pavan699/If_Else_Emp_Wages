using System;

namespace EmployeWage
{
    class Remark
    {
        //Adding hours() method for the calculate Use-Case-6 
        public void hours(int work_Hours,int days)
        {
            Console.WriteLine("******************************************************************");
            if (work_Hours > 100 || days >= 20)
            {
                Console.WriteLine("Employee Performance is Excellent!");
                Console.WriteLine("And its Working hours are {0} And Work Days are {1}",work_Hours,days);
            }
            else
            {
                Console.WriteLine("Empolyee Performance is Good. But need to Improve.....");
                Console.WriteLine("BCoz, Working Hours Are less than 100 ");
            }
        }
    }
    class Check
    {
        public void status(string name,int status,int days)
        {
            //Creating Object for the class Remark.... 
            Remark r = new Remark();
            //Variables for calculating full-time & part-time wages  
            int oneDay_Sal = 0, total_Sal = 0, full_Time = 8, part_Time = 4, perHour_Pay = 20, total_WorkHour=0;
            //If condition for the Full-time employee.....(Use-Case-2)
            if (status == 1 )
            {
                Console.WriteLine("Enployee Name is : {0}",name);
                Console.WriteLine("It's Work-Type is : Full-Time");
                oneDay_Sal = full_Time * perHour_Pay;
                Console.WriteLine("One Day Salary is : {0}", oneDay_Sal);
                total_Sal = oneDay_Sal * days;
                Console.WriteLine("Total Work-Days Salary is : {0}", total_Sal);
                total_WorkHour = full_Time * days;
                //calling the hours() method with class object 'r' from Remark class
                r.hours(total_WorkHour,days);
            }
            //If condition for the Part-time employee.....(Use-Case-3)
            if (status == 2)
            {
                Console.WriteLine("Enployee Name is : {0}", name);
                Console.WriteLine("It's Work-Type is : Part-Time");
                oneDay_Sal = part_Time * perHour_Pay;
                Console.WriteLine("One Day Salary is : {0}", oneDay_Sal);
                total_Sal = oneDay_Sal * days;
                Console.WriteLine("Total Work-Days Salary is : {0}", total_Sal);
                total_WorkHour = part_Time * days;
                r.hours(total_WorkHour, days);
            }
            //Default Condition......
            if (status<1 || status>2)
            {
                Console.WriteLine(" Wrong Input :)");
            }
            Console.WriteLine("******************************************************************");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Input Variables
            Console.WriteLine("******************************************************************");
            Console.WriteLine("---------------Welcome To Employee Wage Computation---------------");
            string emp_Name;
            int emp_Status,work_Days;

            //Input from user:
            Console.WriteLine("******************************************************************");
            Console.Write("Enter the Employee Name : ");
            emp_Name = Console.ReadLine();
            Console.Write("Enter the Employee Status 1=FullTime|2=PartTime : ");
            emp_Status = Convert.ToInt32(Console.ReadLine());
            //Input for Use-Case-5
            Console.Write("Enter the Total Work_Days of Employee : ");
            work_Days = Convert.ToInt32(Console.ReadLine());

            //Creating object for Check class and calling the status function
            Console.WriteLine("******************************************************************");
            Check c = new Check();
            c.status(emp_Name, emp_Status, work_Days);
        }
    }
}
