using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignJar.模板方法模式
{
    class Template
    {
    }
}

class Paper {

    public void questionA() {
        Console.WriteLine("问题A");
        Console.WriteLine("问题A答案"+Answerl());
    }

    public void questionB() {
        Console.WriteLine("问题B");
        Console.WriteLine("问题B答案" + Answerl());
    }

    protected virtual string Answerl() {
        return "";
    }
}
// 对于重复的尽量放在父类里面        
class StudentA:Paper {
    protected override string Answerl()
    {
        return "A";
    }
}

class StudentB : Paper {
    protected override string Answerl()
    {
        return "B";
    }
}