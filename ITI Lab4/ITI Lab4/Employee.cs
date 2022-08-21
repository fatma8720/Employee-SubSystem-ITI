using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Lab4
{
    struct Date
    {
      
        private int day;
        private int month;
        private int year;
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int GetDay()
        {
            return day;
        }
        public void SetDay(int d)
        {
            day = d;
        }

        public int GetMonth()
        {
            return month;
        }
        public void SetMonth(int m)
        {
            month = m;
        }
 
        public int Getyear()
        {
            return year;
        }
        public void SetYear(int y)
        {
            year = y;
        }

    }
     public enum Gender
    {
        Female,
        Male,
    };
     public enum SecurityLevel
    {
        guest,
        Developer,
        secretary,
        DBA
    };
     struct Employee
     {
        private int ID;
        public int GetID()
        {
            return ID;
        }
        public void SetID(int id)
        {
            ID = id;
        }

         
        private decimal Salary;
        public decimal GetSalary()
        {
            return Salary;
        }
        public void SetSalary(decimal s)
        {
            Salary = s;
        }


        private Date HireDate;
        public Date GetHireDate()
        {
            return  HireDate;
        }
        public void SetHireDate(Date d)
        {
            HireDate = d;
        }

        private Gender gender;
        public Gender GetGender()
        {
            return gender;
        }
        public void SetGendery(Gender gen)
        {
                gender = gen;
          
        }


        private SecurityLevel securityLevel;
        public SecurityLevel GetsecurityLevel()
        {
            return securityLevel;
        }
        public void SetsecurityLevel(SecurityLevel SL)
        {
            securityLevel = SL;
        }


        public void DisplayData()
        {
            Console.WriteLine($"ID: {ID}\t\tGender : {gender}\t\tSecurity Level :{securityLevel}\t\tSalary: {Salary} EGP\t\tHire Date : {HireDate.GetDay()} / {HireDate.GetMonth()} / {HireDate.Getyear()}");

        }
    }
}
