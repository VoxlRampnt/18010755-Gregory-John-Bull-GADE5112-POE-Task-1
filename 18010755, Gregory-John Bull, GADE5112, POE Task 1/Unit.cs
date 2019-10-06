using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18010755__Gregory_John_Bull__GADE5112__POE_Task_1
{
    public abstract class Unit
    {
        protected int x, y, health, maxHealth, speed, attack, attackRange, faction, restCounter = 1;
        protected char symbol;
        protected bool attacking;

        protected Unit(int x, int y, int health, int MaxHealth, int speed, int attack, int attackRange, int faction, char symbol, bool attacking)
        {
            this.x = x;
            this.y = y;
            this.health = health;
            maxHealth = health;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.faction = faction;
            this.symbol = symbol;
            this.attacking = attacking;
        }

        public abstract void Move(Unit unit, Unit enemy, int size);

        public abstract void Combat(Unit unit, Unit enemy);

        public abstract bool AttackRange(Unit unit, Unit enemy);

        public abstract int ClosestUnit(int num, Unit[] array);

        public abstract void DeathCheck();

        public abstract bool RestCounter();

        public abstract override string ToString();


        public abstract int X
        {
            get;
            set;
        }

        public abstract int Y
        {
            get;
            set;
        }

        public abstract int Health
        {
            get;
            set;
        }

        public abstract int MaxHealth
        {
            get;
            
        }

        public abstract int Speed
        {
            get;
            set;
        }

        public abstract int Attack
        {
            get;
            set;
        }

        public abstract char Symbol
        {
            get;
        }

        public abstract int Faction
        {
            get;
            set;
        }

        public abstract bool Attacking
        {
            get;
            set;
        }
        public int Length { get; internal set; }
    }//
}//
