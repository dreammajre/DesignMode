using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

class FactoryMethod
{
    public void Client() {
        ILeiFengFactory factory = new UndergraduateFacoory();
      //  LeiFeng leifeng = factory.CreateLeiFeng();
        //LeiFeng leifeng = (LeiFeng)Assembly.Load("DesignJar").CreateInstance("DesignJar.FactoryMethod.ILeiFengFactory");
        //leifeng.Cook();
        Console.ReadLine();
    }
}

class LeiFeng {
    public void Sweep() {
        Console.WriteLine("扫地");
    }
    public void Cook() {
        Console.WriteLine("做饭");
    }
    public void Laundry() {
        Console.WriteLine("洗衣");
    }
}
class Undergraduate : LeiFeng {
    
}
class Volunteer : LeiFeng {
   
}

class UndergraduateFacoory : ILeiFengFactory {//大学生工厂类
    public LeiFeng CreateLeiFeng() {
        return new Undergraduate();
    }
}

class VolunteerFactory : ILeiFengFactory {//志愿者工厂类
    public LeiFeng CreateLeiFeng() {
        return new Volunteer();
    }
}



interface ILeiFengFactory {//雷锋工厂
    LeiFeng CreateLeiFeng();
}


