using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyCode.DifferentialProgramming;

internal class Employee
{
    public void Pay()
    {
        // hoge
    }
}

internal class LoggingEmployee : Employee
{
    public new void Pay()
    {
        // hogehoge
        base.Pay();
    }
}