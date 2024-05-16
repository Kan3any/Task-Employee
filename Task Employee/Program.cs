
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using Task_Employee.Mudels;


#region Logo
string Logostart =
@"---------------------------------------------------------------------------------
                      __    __     _                          
                    / / /\ \ \___| | ___ ___  _ __ ___   ___ 
                    \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \
                     \  /\  /  __/ | (_| (_) | | | | | |  __/
                      \/  \/ \___|_|\___\___/|_| |_| |_|\___|
---------------------------------------------------------------------------------
";
string LogoAdmin =
@"
            ___          _                   _       _           _       
           / __\___   __| | ___ _ __ ____   /_\   __| |_ __ ___ (_)_ __  
          / /  / _ \ / _` |/ _ \ '__|_  /  //_\\ / _` | '_ ` _ \| | '_ \ 
         / /__| (_) | (_| |  __/ |   / /  /  _  \ (_| | | | | | | | | | |
         \____/\___/ \__,_|\___|_|  /___| \_/ \_/\__,_|_| |_| |_|_|_| |_|
";
string Logouser =
@"
                ___          _                                      
               / __\___   __| | ___ _ __ ____  /\ /\  ___  ___ _ __ 
              / /  / _ \ / _` |/ _ \ '__|_  / / / \ \/ __|/ _ \ '__|
             / /__| (_) | (_| |  __/ |   / /  \ \_/ /\__ \  __/ |   
             \____/\___/ \__,_|\___|_|  /___|  \___/ |___/\___|_|   
";
#endregion 
#region All List
List<Employee> employees = new List<Employee>
{
    new Employee
    {
        Id =1,
        Name = "Farah",
        Department = "AC" ,
        Salary = 1500 ,
        HData =DateTime.Today ,
        IsActive  =true
    },
    new Employee
    {
        Id =2,
        Name = "Rawan",
        Department = "HR" ,
        Salary =1700 ,
        HData = DateTime.Now ,
        IsActive  =true
    }
};
List<Course> cours = new List<Course>
{
    new Course
    {
       Id = 1,
        CourseName = "php",
        Period = "two mounth",
        Cost = 876,
        isActiv = true,
    },
    new Course
    {
        Id =2,
        CourseName = "ASP",
        Period = "two mounth",
        Cost  =999 ,
        isActiv = true,
    }
};
List<Login> logins = new List<Login>
{
    new Login
    {
        user = "Ahmad"
        ,
        pass = "12345"
    },
    new Login
    {
        user = "Ali"
        ,
        pass = "12345"
    },
    new Login
    {
        user = "Kan3an"
        ,
        pass = "12345"
    },

};
List<Admin> adminstrator = new List<Admin>
{
    new Admin
    {
        user = "AhmadDamra"
        ,
        pass = "11223344"
    }
};
#endregion

Console.WriteLine(Logostart);
Console.Write("are you admin (yes/no): ");
string? isadmin = Console.ReadLine();
Console.Write("Enter Your User Name : ");
string? username = Console.ReadLine();
Console.Write("Enter Your Password : ");
string? password = Console.ReadLine();


if (isadmin == "yes")
{
    foreach (var admin in adminstrator)
    {
        if (username == admin.user && password == admin.pass)
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(LogoAdmin);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Number  |   Name  |  Salary    |      HData    |      Department   |  Status  ");
            Console.WriteLine("---------------------------------------------------------------------------------");

            foreach (var emp in employees)
            {
                string Stetus = "not Avtive";

                if (emp.IsActive == true)
                {
                    Stetus = "Actiive";
                }
                Console.WriteLine("  "
                    + emp.Id + "        " + emp.Name + "       "
                    + emp.Salary + "        "
                    + emp.HData.ToShortDateString()
                    + "           " + emp.Department
                    + "             "
                    + Stetus);
            }
            break;

        }
    }

    Console.ForegroundColor = ConsoleColor.Black;
}
foreach (var logi in logins)
{
    if (username == logi.user && password == logi.pass)
    {

        Console.WriteLine("---------------------------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(Logouser);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("---------------------------------------------------------------------------------");
        Console.WriteLine("Number  | Course Name |  Period    |      Cost    |  Status  ");
        Console.WriteLine("---------------------------------------------------------------------------------");
        foreach (var courss in cours)
        {
            string Stetus = "not Avtive";

            if (courss.isActiv == true)
            {
                Stetus = "Actiive";
            }

            Console.WriteLine("  "
                + courss.Id + "          "
                + courss.CourseName + "         "
                + courss.Period + "        "
                + courss.Cost + "        "
                + Stetus + " ");

        }

        break;

    }

    
    break;

}



Console.ForegroundColor = ConsoleColor.Black;







