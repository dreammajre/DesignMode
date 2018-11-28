using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class watch
{
   /*
    观察者模式  

    
    观察者模式定义了一种一对多的依赖关系，让多个观察者同事监听某一个对象，当这个对象发生改变的时候 ，其他对象会抽到相同的通知   当一个对象改变需要改变其他对象的时候

    // 委托就是一种引用方法的类型。一旦为委托分配了方法，委托将于给方法具有完全相同的行为。委托的使用可以向其他任何方法一样具有返回值和参数。

    //1 关闭作弊模式,出游戏测试包
       2 修改多人对战角色死亡游戏数据同步问题
       3 增加监听是否连接上服务区的通知
     */
}

abstract class Watch {//抽象的观察者
    //public abstract void watchs();//观察者方法

    //public Watch(SubJect ss) {//需要具体的通知者

    //}
}

class watchA : Watch {//具体的观察者A
    //public override void watchs()
    //{
        
    //}
}

interface SubJect {//通知者接口
    //void add(Watch watch);//添加需要通知的观察者
    //void del(Watch watch);//删除需要添加的观察者

    //string SubJect {
    //    get;
    //    set;
    //}
}

class Boss : SubJect {//具体的通知者
  //实现具体的接口
}
