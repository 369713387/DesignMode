using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GameRole
    {
        private int hp;
        public int Hp { get { return hp; } set { hp = value; } }

        private int atk;
        public int Atk { get => atk; set => atk = value; }

        private int def;
        public int Def { get => def; set => def = value; }
        
        public GameRole()
        {

        }

        public void InitState()
        {
            this.atk = 100;
            this.hp = 100;
            this.def = 100;
        }

        public void Fight()
        {
            this.atk = 0;
            this.hp = 0;
            this.def = 0;
        }

        public RoleState saveRoleState()
        {
            return new RoleState(hp, atk, def);
        }

        public void RecoveryState(RoleState state)
        {
            this.hp = state.Hp;
            this.atk = state.Atk;
            this.def = state.Def;
        }

        public void Print()
        {
            Console.WriteLine("生命值 ："+this.hp+" 攻击力 : "+this.atk+" 防御力 ： "+ this.def);
        }

    }
}
