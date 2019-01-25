using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.组合模式
{
    /// <summary>
    /// 树叶节点
    /// </summary>
    class HRDepartment : Company
    {
        public HRDepartment(string name) : base(name)
        {
        }

        public override void Add(Company company)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            Console.WriteLine("部门名 ：" + name);
        }

        public override void Handle()
        {
            Console.Write("部门" + name+"的工作是 ：");
            Train();
        }

        public override void Remove(Company company)
        {
            throw new NotImplementedException();
        }

        private void Train()
        {
            Console.WriteLine("培训新人");
        }
    }
}
