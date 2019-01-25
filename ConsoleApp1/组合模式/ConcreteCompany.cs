using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.组合模式
{
    /// <summary>
    /// 树枝节点or根节点
    /// </summary>
    class ConcreteCompany : Company
    {
        public List<Company> children = new List<Company>();

        public ConcreteCompany(string name) : base(name)
        {
        }

        public override void Add(Company company)
        {
            if(!children.Contains(company))
                children.Add(company);
        }

        public override void Display()
        {
            Console.WriteLine("公司名 ：" + name);
            for (int i = 0; i < children.Count; i++)
            {
                children[i].Display();
            }
        }

        public override void Handle()
        {
            Console.WriteLine("公司" + name + "的职责是 ：");
            for (int i = 0; i < children.Count; i++)
            {
                children[i].Handle();
            }
        }

        public override void Remove(Company company)
        {
            children.Remove(company);
        }
    }
}
