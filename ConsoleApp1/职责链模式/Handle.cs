using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.职责链模式
{
    abstract class Handle
    {
        protected Handle handle;

        public Handle()
        {

        }

        public Handle(Handle handle)
        {
            this.handle = handle;
        }

        public void SetHandle(Handle handle)
        {
            this.handle = handle;
        }

        abstract public void ExecutedRequest(Request request);
    }
}
