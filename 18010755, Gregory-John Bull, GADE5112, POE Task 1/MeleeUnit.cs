using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18010755__Gregory_John_Bull__GADE5112__POE_Task_1
{
    class MeleeUnit : Unit
    {
        public MeleeUnit() : base(0, 0, 45, 45, 1, 4, 1, 0, 'M', false)
        {
        }

        public override int X
        {
            get { return x; }
            set { x = value; }
        }

        public override int Y
        {
            get { return y; }
            set { y = value; }
        }

        public override int Faction
        {
            get { return faction; }
            set { faction = value; }
        }

        public override int Health
        {
            get { return health; }
            set { health = value; }
        }

        public override int MaxHealth
        {
            get { return health; }
        }

        public override int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public override int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public override bool Attacking
        {
            get { return attacking; }
            set { attacking = value; }
        }

        public override char Symbol
        {
            get { return symbol; }
        }

        public override int ClosestUnit(int num, Unit[] uArray)
        {
            int index = -1;

            double dist = Double.MaxValue;

            for (int l = 0; l < uArray[num].Faction;)
            {
                if (uArray[l].Faction == uArray[num].Faction)
                {
                    continue;
                }
                else
                {
                    if (dist > Math.Sqrt(Math.Pow(uArray[l].X - uArray[num].X, 2) + Math.Pow(uArray[l].Y - uArray[num].Y, 2)))
                    {

                        index = l;
                    }
                }

            }

            return index;

        }

        public override bool AttackRange(Unit unit, Unit enemy)
        {
            if (Math.Sqrt(Math.Pow(unit.X - enemy.X, 2) + Math.Pow(unit.Y - enemy.Y, 2)) <= attackRange)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override void Combat(Unit unit, Unit enemy)
        {
            throw new NotImplementedException();
        }

        public override void Move(Unit unit, Unit enemy, int size)
        {
            double dUP = 0;
            double dDOWN = 0;
            double dLEFT = 0;
            double dRIGHT = 0;
            Random random = new Random();
            int check;

            dUP = Math.Sqrt(Math.Pow(unit.X - enemy.X, 2) + Math.Pow(unit.Y - enemy.Y, 2));
            dDOWN = Math.Sqrt(Math.Pow(unit.X - enemy.X, 2) + Math.Pow(unit.Y - enemy.Y, 2));
            dLEFT = Math.Sqrt(Math.Pow(unit.X - enemy.X, 2) + Math.Pow(unit.Y - enemy.Y, 2));
            dRIGHT = Math.Sqrt(Math.Pow(unit.X - enemy.X, 2) + Math.Pow(unit.Y - enemy.Y, 2));

            if (unit.RestCounter() != true)
            {
                if (unit.Health > unit.MaxHealth * 0.25)
                {
                    if (dUP == dRIGHT && dUP == dDOWN && dUP == dLEFT)
                    {
                        check = random.Next(0, 4);
                        if (check == 0)
                        {
                            if (unit.Y != 0)
                            {
                                unit.Y--;
                            }
                        }
                        else if (check == 1)
                        {
                            if (unit.X != size - 1)
                            {
                                unit.X++;
                            }
                        }
                        else if (check == 2)
                        {
                            if (unit.Y != size - 1)
                            {
                                unit.Y++;
                            }
                        }
                        else if (check == 0)
                        {
                            if (unit.X != 0)
                            {
                                unit.X--;
                            }
                        }
                    }
                    else if (dUP == dDOWN)
                    {
                        check = random.Next(0, 2);
                        if (check == 0)
                        {
                            if (unit.Y != 0)
                            {
                                unit.Y--;
                            }
                        }
                        else if (check == 1)
                        {
                            if (unit.Y != size - 1)
                            {
                                unit.Y++;
                            }
                        }
                        else if (dRIGHT == dLEFT)
                        {
                            check = random.Next(0, 2);
                            if (check == 0)
                            {
                                if (unit.X != 0)
                                {
                                    unit.X--;
                                }
                            }
                            else if (check == 1)
                            {
                                if (unit.X != size - 1)
                                {
                                    unit.X++;
                                }
                            }
                        }
                        else if (dUP > dRIGHT && dUP > dDOWN && dUP > dLEFT && unit.Y != 0)
                        {
                            unit.Y--;
                        }
                        else if (dRIGHT > dDOWN && dRIGHT > dLEFT && dRIGHT > dUP && unit.X != size - 1)
                        {
                            unit.X++;
                        }
                        else if (dDOWN > dLEFT && dDOWN > dUP && dDOWN > dRIGHT && unit.Y != size - 1)
                        {
                            unit.Y++;
                        }
                        else if (dLEFT > dUP && dLEFT > dRIGHT && dLEFT > dDOWN && unit.X != 0)
                        {
                            unit.X--;
                        }
                    }

                }
                else
                {
                    if (dUP < dRIGHT && dUP < dDOWN && dUP < dLEFT)
                    {
                        unit.Y--;
                    }
                    else if (dRIGHT < dDOWN && dRIGHT < dLEFT && dRIGHT < dUP)
                    {
                        unit.X++;
                    }
                    else if (dDOWN < dLEFT && dDOWN < dUP && dDOWN < dRIGHT)
                    {
                        unit.Y++;
                    }
                    else if (dLEFT < dUP && dLEFT < dRIGHT && dLEFT < dDOWN)
                    {
                        unit.X--;
                    }
                }
            }



        }

        public override void DeathCheck()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return null;
        }

        public override bool RestCounter()
        {
            if (restCounter == speed)
            {
                restCounter = 1;
                return false;

            }
            restCounter++;
            return true;
        }


    }//
}//


