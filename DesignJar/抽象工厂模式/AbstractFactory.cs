using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


class AbstractFactory
{
    public void Client() {
        Form user = new User();//表1
        user.ID = 1;
        user.Name = "YY";
        Form bus = new Business();//表2
        bus.ID = 2;
        bus.Name = "TT";
        DataBase database =  DataAccess.Create();

        database.Insert(user);
        database.GetForm(1);
        database.Insert(bus);
        database.GetForm(1);

        Console.ReadLine();
    }    
}

class DataAccess {
     
    
      // 1 修复IOS主界面头像显示异常问题
      // 2 增加回调通知脚本渠道区分标识
      // 3 增加头像购买界面购买标识的区分                                                                                                                                                                

    private static readonly string AssemblyName = "抽象工厂模式";   
    private static readonly string accessname = "sql";//acc
    public static DataBase Create() {
        DataBase database = null;
        switch (accessname)
        {
            case "sql":
                SqlFactory sql = new SqlFactory();//只需要换这里就OK 0.  
                database = sql.CreateDataBase();
                break;
            case "acc":
                AccessFactory acc = new AccessFactory();
                database = acc.CreateDataBase();
                break;
            default:
                break;
        }
        return database;
    }
}




class User:Form {
 
}
class Business:Form {
   
}

class Form {
    private int _id;
    private string _name;
    public int ID { get { return _id; } set { _id = value; } }
    public string Name { get { return _name; } set { _name = value; } }
}



abstract class DataBase {
    public abstract void Insert(Form user);
    public abstract Form GetForm(int id);

   
   
}
abstract class DataBaseFactory {//数据库工厂类 
    public abstract DataBase CreateDataBase();
}

class SqlFactory:DataBaseFactory {//sql工厂
    public override DataBase CreateDataBase()
    {
        return new Sql();
    }
}
class AccessFactory : DataBaseFactory {//access工厂
    public override DataBase CreateDataBase()
    {
        return new Access();
    }
}
class Sql:DataBase {
   public override void Insert(Form user) {
        Console.WriteLine("插入一条记录 : "+user.ID+" Name : "+user.Name);
   }
    public override Form GetForm(int id) {
        Console.WriteLine("根据ID获取一天表的记录");
        return null;
    }
}
class Access : DataBase
{
    public override void Insert(Form user)
    {
        Console.WriteLine("插入一条记录 : " + user.ID + " Name : " + user.Name);
    }
    public override Form GetForm(int id)
    {
        Console.WriteLine("根据ID获取一天表的记录");
        return null;
    }
}