using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.职责链模式
{
    class Request
    {
        private string username;
        private string priority;
        private string content;
        public string Username { get => username; set => username = value; }
        public string Priority { get => priority; set => priority = value; }
        public string Content { get => content; set => content = value; }

        public Request()
        {

        }

        public Request(string uname,string pty,string con)
        {
            username = uname;
            priority = pty;
            content = con;
        }


    }
}
