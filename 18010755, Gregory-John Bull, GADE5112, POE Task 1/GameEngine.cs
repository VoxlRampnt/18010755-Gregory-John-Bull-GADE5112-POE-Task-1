using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18010755__Gregory_John_Bull__GADE5112__POE_Task_1
{
    class GameEngine
    {
        public Map map;
        private int rounds;
        private Unit[] units;
        Random random = new Random();
       
        public GameEngine(int rounds)
        {
            this.rounds = rounds;
            Map map = new Map(20);
        }

        public string GetMap()
        {
            return map.MapDisplay();
        }

        public GameEngine()
        {
            map = new Map(20);
        }

        public void Round()
        {
            int enemy;

            for (int i = 0; i < map.units.Length; i++)
            {
                enemy = map.units[i].ClosestUnit(i, map.units);

                if (enemy == -1)
                {
                    break;
                }
                else
                {
                    map.units[i].Move(map.units[i], map.units[enemy], map.TheSIZE);
                }
            }
        }

        
        


    }//
}//
