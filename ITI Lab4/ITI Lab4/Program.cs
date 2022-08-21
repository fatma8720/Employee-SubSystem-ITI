using System;

namespace ITI_Lab4
{

    class Program
    {
        //public static void Add_Employee(Employee e,int ID, decimal salary, Gender gender, SecurityLevel securityLevel, Date HireDate)
        //{
        //    e.SetID(ID);
        //    e.SetSalary(salary);
        //    e.SetGendery(gender);
        //    e.SetsecurityLevel(securityLevel);
        //    e.SetHireDate(HireDate);

        //    Console.WriteLine("Employee Add");
        //}
        static void Main(string[] args)
        {

            Employee[] employees = new Employee[3];
            for (int i = 0; i < 2; i++)
            {
                employees[i] = new Employee();
                #region ID
                int ID=0;

                while (true)
                {
                    Console.WriteLine($"\nEnter employee {i + 1} ID : ");

                    if (int.TryParse(Console.ReadLine(), out ID))
                    {
                        break;
                    }
                    Console.WriteLine($"\n\t\t\tInValid employee ID ");

                }

                // while (!int.TryParse(Console.ReadLine(), out ID));

                #endregion

                #region salary
                decimal salary;
                while (true)
                {
                    Console.WriteLine($"\nEmployee {i + 1} Salary : ");

                    if (decimal.TryParse(Console.ReadLine(), out salary))
                    {
                        break;
                    }
                    Console.WriteLine($"\n \t\t\tNot Valid employee Salary ");

                }

                #endregion

                #region gender

                string gen;
                Gender gender = new Gender();

                while (true){

                    Console.WriteLine($"\n\nEnter Employee {i + 1} Gender  :   Male\\Female or APPR F\\M");

                    gen = Console.ReadLine();
                    if (gen.ToUpper() == "F" || gen.ToUpper() == "FEMALE")
                    {
                        gender = Gender.Female;
                        break;
                    }
                    else if (gen.ToUpper() == "M" || gen.ToUpper() == "MALE")
                    {
                        gender = Gender.Male;
                        break;
                    }
                    else Console.WriteLine($"\n\t\t\tInValid Gender\n");

                    //gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine().ToUpper());
                    //if (Enum.TryParse( Console.ReadLine().ToUpper(),out gender))
                    //{
                    //    break;
                    //}
                    //Console.WriteLine($"\n\t\t\tInValid Gender\n");
                }


                #endregion

                string SL;
                SecurityLevel securityLevel = new SecurityLevel();

                #region securityLevel
                while (true)
                {

                    Console.WriteLine($"\nEmployee {i + 1} Security Level : \nGuest  : \t\t1 \nDeveloper  : \t\t2 \nsecretary  : \t\t3 \nDBA  : \t\t\t4 \n ");
                    SL = Console.ReadLine();

                    if (SL.ToUpper() == "GUEST" || SL.ToUpper() == "1")
                    {
                        securityLevel = SecurityLevel.guest;
                        break;
                    }
                    else if (SL.ToUpper() == "Developer" || SL.ToUpper() == "2")
                    { 
                        securityLevel = SecurityLevel.Developer;
                        break;
                    }
                    else if (SL.ToUpper() == "SECRETARY" || SL.ToUpper() == "3")
                    { 
                        securityLevel = SecurityLevel.secretary;
                        break;
                    }
                    else if (SL.ToUpper() == "DBA" || SL.ToUpper() == "4") 
                    { 
                        securityLevel = SecurityLevel.DBA;
                        break;
                    }
                    else Console.WriteLine($"\t\t\tInValid Security Level ");
                     
                }
                #endregion

                #region date
                int day, year, month;
                bool g;

                    Console.WriteLine($"\nemployee {i + 1} Hire Date :\tDay - Month - Year   - Each one in new line - ");
                    bool dc = false, mc=false, yc=false;
                    
                        while (true)
                        {
                            Console.WriteLine($"\nEmployee {i + 1} Hire Date :\tDay : ");

                            if (int.TryParse(Console.ReadLine(), out day) && (day >= 1 && day <= 31))
                            {
                                dc = true;
                                break;
                            }
                            Console.WriteLine($"\n\t\t\tInValid Day ");
                        }
                        while (true)
                        {
                            Console.WriteLine($"\nEmployee {i + 1} Hire Date :\tMonth : ");

                            if (int.TryParse(Console.ReadLine(), out month) && (month >= 1 && month <= 12))
                            {
                                break;
                                mc = true;
                            }
                            Console.WriteLine($"\n\t\t\tInValid Month ");
                        }
                        while (true)
                        {
                            Console.WriteLine($"\nEmployee {i + 1} Hire Date :\tYear : ");

                            if (int.TryParse(Console.ReadLine(), out year) && (year >= 2006 && year <= 2022))
                            {
                                mc = true;
                                break;
                            }
                            Console.WriteLine($"\n\t\t\tInValid Year ");
                        }


                Date HireDate = new Date(day,month,year);
                #endregion

                employees[i].SetID(ID);
                employees[i].SetSalary(salary);
                employees[i].SetGendery(gender);
                employees[i].SetsecurityLevel(securityLevel);
                employees[i].SetHireDate(HireDate);
                Console.WriteLine("\n\t\t --------------    Employee Add    -------------\t\t\n");
                //Add_Employee(employees[i],ID,salary,gender,securityLevel,HireDate);
            }

            for (int i = 0; i < 2; i++)
            {
                employees[i].DisplayData();
            }

            Console.ReadKey();
        }
    }
}
