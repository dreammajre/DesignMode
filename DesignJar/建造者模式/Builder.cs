using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Builder
{
    /*
     * 建造者模式 将一个复杂对象的构建和它的表示分离的时候，使得同样的构建过程可以创建不同的表示的时候，使用建造者模式。
     * 
     * */

    public void Client() {
        Director dir = new Director();//实例一个指挥类
        Builders b1 = new ConcereteBuilder();//实例一个具体的建造类
        dir.Construct(b1);//指挥构建出具体的产品
        Product p1 = b1.GetResult();//得到产品
        p1.show();//展示产品

        Console.ReadLine();
    }

  
    

}
class Product {//产品类
    IList<string> parts = new List<string>();
    public void Add(string part) {
        parts.Add(part);
    }

    public void show() {
        Console.WriteLine("产品构建");
        foreach (string item in parts)
        {
            Console.WriteLine(item);
        }
    }
}

abstract class Builders {//构建抽象类
    public abstract void BuilderA();//A 部件
    public abstract void BuilderB();// B 部件

    public abstract Product GetResult();//得到构建的产品对象

}

class ConcereteBuilder : Builders {//具体的建造者

    private Product product = new Product();
    public override void BuilderA()
    {
        product.Add("A");
    }

    public override void BuilderB()
    {
        product.Add("B");
    }

    public override Product GetResult()
    {
        return product;
    }
}

class Director {//指挥类

    public void Construct(Builders builders) {
        builders.BuilderA();
        builders.BuilderB();
    }
}