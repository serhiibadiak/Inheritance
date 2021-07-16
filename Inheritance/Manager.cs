using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    class Manager : Employee
    {
        private int quantity;
        public Manager(string name, decimal salary, int clientAmount)
        : base(name, salary)
        {
            this.quantity = clientAmount;
        }
        public override void SetBonus(decimal bonus)
        {
            if (this.quantity > 100 && this.quantity < 150)
            {
                base.SetBonus(bonus + 500);
            }
            else if (this.quantity > 150)
            {
                base.SetBonus(bonus + 1000);
            }
            else
            {
                base.SetBonus(bonus);
            }
        }
    }
    //TODO: Create public class 'Manager' here, which inherits from 'Employee' class

    //TODO: Define private integer field: 'quantity'

    //TODO: Define constructor with three parameters: 'name'(string), 'salary'(decimal) and 'clientAmount'(int). Assign two first parameters to base class.

    //TODO: Override public virtual method 'SetBonus', which increases bonus depending on clients amount
}

