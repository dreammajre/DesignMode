using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 class Agent
{
    public void client() {
        PusureGirl pusuregirl = new PusureGirl("婷婷");
        AgentBox agentBox = new AgentBox(pusuregirl);
        agentBox.GiftA();
        agentBox.GiftB();
        Console.ReadLine();
   }
 
}


class PusureGirl {//被追求者
    public string pusureGirlName;

    public PusureGirl(string pusureGirlName) {
        this.pusureGirlName = pusureGirlName;
    }
}

interface IGift {//礼物接口
    void GiftA();
    void GiftB();
}

class PusureBoy:IGift {//追求者类
    PusureGirl pusuregirl;
    public PusureBoy(PusureGirl pusualgirl) {
        this.pusuregirl = pusualgirl;
    }
    public void GiftA() {
        Console.WriteLine("送礼物A"+pusuregirl.pusureGirlName);
    }
    public void GiftB() {
        Console.WriteLine("送礼物B"+pusuregirl.pusureGirlName);
    }
}

class AgentBox : IGift {
    PusureBoy pusureBox;
    public AgentBox(PusureGirl pusuregirl) {
        pusureBox = new PusureBoy(pusuregirl);   
    }

    public void GiftA() {
        pusureBox.GiftA();
    }

    public void GiftB() {
        pusureBox.GiftB();
    }
}

/*
   代理模式 为其他对象提供一种代理 以控制对这个对象的访问
     */
