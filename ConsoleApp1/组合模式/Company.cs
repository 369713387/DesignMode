using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.组合模式
{
    /// <summary>
    /// 节点
    /// </summary>
    abstract class Company
    {
        public string name;

        public Company(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// 增加组件
        /// </summary>
        public abstract void Add(Company company);
        /// <summary>
        /// 移除组件
        /// </summary>
        public abstract void Remove(Company company);

        /// <summary>
        /// 显示函数
        /// </summary>
        public abstract void Display();

        /// <summary>
        /// 处理任务
        /// </summary>
        public abstract void Handle();
    }
}
