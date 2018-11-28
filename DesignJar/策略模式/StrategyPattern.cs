using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 抽象算法类
/// </summary>
abstract class StrategyPattern
{
    //算法方法
    public abstract void AlgorithmInterface();
}

//封装了具体的算法或者行为
class ConcretsStaregyA : StrategyPattern {
    public override void AlgorithmInterface()
    {
        Console.WriteLine("算法A的实现");
    }
}

class Context {
    StrategyPattern strategy;
    public Context(StrategyPattern strategy) {//初始化的时候传入具体的策略
        this.strategy = strategy;
    }

    public Context(string type) {
        switch (type)
        {
            case "+":
                strategy = new ConcretsStaregyA();
                strategy.AlgorithmInterface();
                break;
            default:
                break;
        }
    }//策略模式和简单工厂的结合

    public void ContextInterface() {//根据具体的策略调用具体的方法
        strategy.AlgorithmInterface();
    }
}

