using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Decorate
{
    private string name;
    public Decorate(string name) {
        this.name = name;
    }

    public Decorate() { }

    public virtual void show() {
        Console.WriteLine("需要搭配的{0}",name);
    }
}

class Holistic : Decorate{//整体的装饰类 不对外 不在客户端展示

    protected Decorate decorate;

    public void SetFinary(Decorate decorate) {
        this.decorate = decorate;
    }
    public override void show()
    {
        if (decorate == null) return;
        decorate.show();//搭配完成具体的展示
    }
}

class ConcreteFinartA : Holistic {//具体装饰对象A
    public override void show()
    {
        Console.WriteLine("穿内裤");
        base.show();
    }
}

class ConcreteFinartB : Holistic {//具体装饰对象B
    public override void show()
    {
        Console.WriteLine("穿外裤");
        base.show();
    }
}

public class Client { //具体的客户端代码

    public void showAll() {
        Decorate decorate = new Decorate("菜鸟");
        ConcreteFinartA concreteFinaryA = new ConcreteFinartA();
        ConcreteFinartB concreteFinaryB = new ConcreteFinartB();

        concreteFinaryB.SetFinary(decorate);//设置裤子的外层是人
        concreteFinaryA.SetFinary(concreteFinaryB);//内裤的外层是裤子
        concreteFinaryA.show();//传完之后展示
        Console.ReadLine();
    }    
}

/**
 装饰模式就是讲主类里面的装饰功能单独的写出一个类  减少主类的调用  需要注意的是 使用装饰模式的时候需要注意装饰的顺序
     */

