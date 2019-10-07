using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18010755__Gregory_John_Bull__GADE5112__POE_Task_1
{
    class Map
    {
        int SIZE = 20;
        Random random = new Random();
        int numUnits;
        Unit[] units;
        string[,] map;
        string[] factions = { "Exo-Team", "Alt-Team" };

        public Map(int numUnits)
        {
            this.numUnits = numUnits;
            Reset();
        }

        public Unit[] Units
        {
            get { return units; }
        }
      
        public int Size
        {
            get { return SIZE; }
        }

        public string GetMapDisplay()
        {
            string mapString = " ";
            for(int y = 0; y < SIZE; y++)
            {
                for(int x = 0; x < SIZE; x++)
                {
                    mapString += map[x, y];
                }
                mapString += "\n";
            }
            return mapString;
        }

        public void UpdateMap() // updates the map as the game goes on
        {
            for(int y = 0; y < SIZE; y++)
            {
                for(int x = 0; x < SIZE; x++)
                {
                    map[x, y] = " . ";
                }
            }
        }

        public void InitializeUnits() // initializes the units onto the map
        {
            for(int i = 0; i < units.Length; i++)
            {
                int x = random.Next(0, SIZE);
                int y = random.Next(0, SIZE);
                int factionIndex = random.Next(0, 2);
                int unitType = random.Next(0, 2);

                while(map[x,y] != null)
                {
                    x = random.Next(0, SIZE);
                    y = random.Next(0, SIZE);
                }
                if(unitType == 0)
                {
                    units[i] = new MeleeUnit(x, y, factions[factionIndex]);
                }
                else
                {
                    units[i] = new MeleeUnit(x, y, factions[factionIndex]);
                }
                map[x, y] = units[i].Faction[0] + "/" + units[i].Symbol;
            }
        }

        public void Reset()
        {
            map = new string[SIZE, SIZE];
            units = new Unit[numUnits];
            InitializeUnits();
            UpdateMap();
        }
        
    }//
}//
