using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//表示一个客户端
namespace DesignJar
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory abs = new AbstractFactory();
            abs.Client();
        }
        #region 简单工厂
        static void Factory() {
            Operation a;
            a = OperationFactory.createOperation("+");
            a.NumbleA = 1;
            a.NumbleB = 2;
            double result = a.GetResult();
            Console.WriteLine(result);
            Console.ReadKey();
        }
        #endregion
        #region 策略
        static void strategy() {
            Context context = new Context(new ConcretsStaregyA());
            context.ContextInterface();
            Console.ReadKey();
        }
        #endregion
    }
}
