using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18010755__Gregory_John_Bull__GADE5112__POE_Task_1
{
    class GameEngine
    {
        Map map;
        bool isGameOver = false;
        string winningFaction = "";
        int round = 0;

        public GameEngine()
        {
            map = new Map(10);
        }

        public bool IsGameOver
        {
            get { return isGameOver; }
        }
        
        public string WinningFaction
        {
            get { return winningFaction; }
        }
        public int Round
        {
            get { return round; }
        }

        public string GetMapDisplay()
        {
            return map.GetMapDisplay();
        }

        public string GetUnitInfo()
        {
            string unitInfo = " ";
            foreach (Unit unit in map.Units)
            {
                unitInfo += unit + "\n";
            }
            return unitInfo;
        }

        public void Reset()
        {
            map.Reset();
            isGameOver = false;
            round = 0;
        }

        public void GameLoop()
        {
            foreach(Unit unit in map.Units)
            {
                if (unit.Destroyed)
                {
                    continue;
                }

                Unit closestUnit = unit.ClosestUnit(map.Units);

                    if(closestUnit == null) {
                        isGameOver = true;
                        winningFaction = unit.Faction;
                        map.UpdateMap();
                        return;
                    }

                double healthPercentage = unit.Health / unit.MaxHealth;
                if (healthPercentage <= 0.25)
                {
                    unit.RunAway();
                }
                else if (unit.AttackRange(closestUnit))
                {
                    unit.Combat(closestUnit);

                }
                else
                {
                    unit.Move(closestUnit);
                }
                StayInBounds(unit, map.Size);

            }
            map.UpdateMap();
            round++;

            void StayInBounds(Unit unit, int size)
            {
                if(unit.X < 0)
                {
                    unit.X = 0;
                }
                else if(unit.X >= size)
                {
                    unit.X = size - 1;
                }
                if(unit.Y < 0)
                {
                    unit.Y = 0;
                }
                else if (unit.Y >= size)
                {
                    unit.Y = size - 1;
                }
            }
        }
    }//
}//
