using System;
using System.Collections.Generic;
using System.Text;


namespace InheritanceTask
{
    class Company
    {
        private Employee[] employees;
        public Company(Employee[] array)
        {
            this.employees = array;
        }
        public void GiveEverybodyBonus(decimal companyBonus)
        {
            if (this.employees.Length > 0)
            {
                for (int i = 0; i < this.employees.Length; i++)
                {
                    if (this.employees[i] != null)
                    {
                        this.employees[i].SetBonus(companyBonus);
                    }
                }
            }
        }
        public decimal TotalToPay()
        {
            decimal sum = 0;
            if (this.employees.Length > 0)
            {
                for (int i = 0; i < this.employees.Length; i++)
                {
                    if (this.employees[i] != null)
                    {
                        sum += this.employees[i].ToPay();
                    }
                }
            }
            return sum;
        }
        public string NameMaxSalary()
        {
            decimal max = 0;
            string result = "";
            if (this.employees.Length > 0)
            {
                for (int i = 0; i < this.employees.Length; i++)
                {
                    if (this.employees[i] != null && this.employees[i].ToPay() > max)
                    {
                        max= this.employees[i].ToPay();
                        result = this.employees[i].Name;
                    }
                }
            }
            return result;
        }
    }
    //TODO: Create public class 'Company' here

    //TODO: Define private field that is array of employees: 'employees'

    //TODO: Define constructor that gets array of employees, and assign them to its field

    //TODO: Define public method 'GiveEverbodyBonus' with parameter 'companyBonus', that set basic bonus to every employee in the company
    //TODO: Define public method 'TotalToPay', that returns the total salary + bonus of all employees of the company 
    //TODO: Define public method 'NameMaxSalary', that returns emloyee’s name who has maximum salary + bonus in the company 
}
