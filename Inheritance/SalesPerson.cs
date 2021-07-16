using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    class SalesPerson : Employee
    {
        protected int percent;
        public SalesPerson(string name, decimal salary, int percent)
        : base(name, salary)
        {
            this.percent = percent;
        }
        public override void SetBonus(decimal bonus)
        {
            if (this.percent > 100 && this.percent < 200)
            {
                base.SetBonus(2 * bonus);
            }
            else if (this.percent > 200)
            {
                base.SetBonus(3 * bonus);
            }
            else
            {
                base.SetBonus(bonus);
            }
        }

    }
    //TODO: Create public class 'SalesPerson' here, which inherits from 'Employee' class

    //TODO: Define private integer field: 'percent'

    //TODO: Define constructor with three parameters: 'name'(string), 'salary'(decimal) and 'percent'(int). Assign two first parameters to base class.

    //TODO: Override public virtual method 'SetBonus', which increases bonus depending on percent
}
