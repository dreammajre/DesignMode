using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//运算类
public class Operation
{
    private double numble_A,numble_B;

    public double NumbleA {
        get { return numble_A; }
        set { numble_A = value; }
    }
    public double NumbleB {
        get { return numble_B; }
        set { numble_B = value; }
    }

    public virtual double GetResult() {
        double result = 0;
        return result;
    }
}
//具体的运算类 求和运算
 class OperationAdd:Operation {
    public override double GetResult()
    {
        double result = 0;
        result = NumbleA + NumbleB;
        return result;
    }
}

//运算工程类
public class OperationFactory {
    public static Operation createOperation(string operation) {
        Operation ope = null;
        switch (operation)
        {
            case "+":
                ope = new OperationAdd();
                break;
            default:
                break;
        }
        return ope;
    }
}


