using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RoleState
    {
        private int hp;

        private int atk;

        private int def;

        public int Hp { get => hp; set => hp = value; }
        public int Atk { get => atk; set => atk = value; }
        public int Def { get => def; set => def = value; }

        public RoleState(int hp, int atk,int def)
        {
            this.Hp = hp;
            this.Atk = atk;
            this.Def = def;
        }

       
    }
}
