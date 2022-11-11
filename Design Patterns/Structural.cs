using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//bridge-abstraksyani ve implementeysonu bir birinen ayrmaq ucn istfade olnr yani bir birinen asili olmassnar iksnde deywmek olsn
//esasen abstraksionun implementeysina bagliliqinan qacmaq ucn istfade olnr
//ve abstraksiyanin deywmesi implementeysini deywmemelidir




abstract class Abstraction//implementator obyektne reference saxlyr base interfeysi mueyyenlewdrir
{
    protected Implementor implementor;
    public Implementor Implementor
    {
        set { implementor = value; }
    }
    public Abstraction(Implementor imp)
    {
        implementor = imp;
    }
    public virtual void Operation()
    {
        implementor.OperationImp();
    }
}

abstract class Implementor//base interfeysi mueyyen edir ve yungul funksyalar burda olr cetinler abstractionda
{
    public abstract void OperationImp();
}

class RefinedAbstraction : Abstraction//abstractionan toreyir ve interfeysn waxelenmesine komey edir
{
    public RefinedAbstraction(Implementor imp)
        : base(imp)
    { }
    public override void Operation()
    {
    }
}

class ConcreteImplementorA : Implementor
{
    public override void OperationImp()
    {
    }
}

class ConcreteImplementorB : Implementor
{
    public override void OperationImp()
    {
    }
}


class Client//abstraksiani istfade edir
{
    static void Main()
    {
        Abstraction abstraction;
        abstraction = new RefinedAbstraction(new ConcreteImplementorA());
        abstraction.Operation();
        abstraction.Implementor = new ConcreteImplementorB();
        abstraction.Operation();
    }
}
