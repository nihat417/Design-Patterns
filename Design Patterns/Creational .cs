using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//SingletonPattern


//olkenin bir prezidenti ola biler ve o tek hazrki vezyeti ve borcu olduquycun isleyir burda single Presidentdir

namespace Design_Patternsl;

public sealed class President
{

    private President()
    {
        // konstruktoru gizledrik
    }

    private static President Instance;

    public static President GetInstance()//nu president klasina accses ucn lazmdir.ise salnanda static sahede saxlanilir
    {
        if (Instance == null)
        {
            Instance = new President();
        }
        return Instance;
    }

    public void Someworks()
    {

    }
}

class Program
{
    static void Main()
    {
        President p1 = President.GetInstance();
        President p2 = President.GetInstance();


        if (p1 == p2)
        {
            Console.WriteLine("true");
        }
    }
}