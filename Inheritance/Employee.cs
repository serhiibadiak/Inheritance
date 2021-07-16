using System;

namespace InheritanceTask
{
    class Employee
    {
        private string name;
        private decimal bonus;
        private decimal salary;
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public decimal Bonus
        {
            set
            {
                bonus = value;
            }
            get
            {
                return bonus;
            }
        }
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.Salary = salary;
        }
        virtual public void SetBonus(decimal bonus)
        {
            Bonus = bonus;
        }
        public decimal ToPay()
        {
            return this.salary + this.bonus;
        }
    }
    //TODO: Create public class 'Employee' here

    //TODO: Define three private fields: 'name'(string), 'salary'(decimal), 'bonus'(decimal)
    //TODO: Define public property 'Name' for getting 'name'
    //TODO: Define public property 'Salary' for getting and setting 'salary'

    //TODO: Define constructor with two parameters: 'name'(string), 'salary'(decimal). Assign parameters to its fields

    //TODO: Define public virtual method 'SetBonus', that set value in 'bonus'
    //TODO: Define public method 'ToPay', that returns sum of salary and bonus 
}

