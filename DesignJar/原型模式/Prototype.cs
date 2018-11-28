using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Prototype
{
    public void Client()
    {
        Resume a = new Resume("Jamk");
        a.setInfo("10","男");
        a.setwork("1");
        Resume b = a.getResume() as Resume;
        b.setInfo("11","女");
        b.setwork("3");
        a.show();
        b.show();
        Console.ReadLine();
    } 
}

class Resume:IClone {
    private string name;
    private string age;
    private string sex;
    private Work work;
    public Resume(string name) {
        this.name = name;
        work = new Work();
    }
    public Resume(Work work) {
        this.work = work.getResume() as Work;//克隆工作经历
    }
    public void setInfo(string age,string sex) {
        this.age = age;
        this.sex = sex;
    }
    public void setwork(string working) {
        work.Workinglife = working;
    }     
    public void show() {
        Console.WriteLine("{0} {1} {2}",name,age,sex);
        Console.WriteLine("{0}",work.Workinglife);
    }

    public Object getResume() {
        Resume obj = new Resume(this.work);
        obj.name = this.name;
        obj.sex = this.sex;
        obj.age = this.age;
        return obj;//对于值类型的引用 能够克隆值  对于引用对象 只能克隆引用不能改变值
    }
   

}

class Work : IClone{//工作经历类
    private string workinglife;
    public string Workinglife { get { return workinglife; } set { workinglife = value; } }

    public Object getResume() {
        return (Object)this.MemberwiseClone();
    }
       
   
}

interface IClone {
     Object getResume();
}


