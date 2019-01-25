using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.组合模式
{
    class FinanceDepartment : Company
    {
        public FinanceDepartment(string name) : base(name)
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
            Console.Write("部门" + name+"的工作是 ： ");
            Audit();
        }

        public override void Remove(Company company)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 审核
        /// </summary>
        private void Audit()
        {
            Console.WriteLine("进行审核");
        }
    }
}
