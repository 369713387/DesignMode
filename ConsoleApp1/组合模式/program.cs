//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp1.组合模式
//{
//    class program
//    {
//        static void Main(string[] args)
//        {
//            ConcreteCompany root = new ConcreteCompany("北京总公司");
//            root.Add(new HRDepartment("总公司人力资源部"));
//            root.Add(new FinanceDepartment("总公司财务部"));

//            ConcreteCompany component = new ConcreteCompany("上海分公司");
//            component.Add(new HRDepartment("上海分公司人力资源部"));
//            component.Add(new FinanceDepartment("上海分公司财务部"));
//            root.Add(component);

//            root.Display();
//            root.Handle();
//            Console.Read();
//        }
//    }
//}
