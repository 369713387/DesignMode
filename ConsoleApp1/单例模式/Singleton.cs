using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.单例模式
{
    public sealed class Singleton
    {
        private Singleton()
        {

        }

        public static Singleton Instance {
            get
            {
                return Nested.m_instance;
            }
        }

        class Nested
        {
             static Nested()
            {

            }

            internal static readonly Singleton m_instance = new Singleton();
        }


        public void Write()
        {
            Console.WriteLine("我是单例模式");
        }
    }
}
