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
        private const int SIZE = 20;
        private char[,] mapArray = new char[SIZE, SIZE];
        public Unit[] units;
        private static Random random = new Random();

        public Map(int numUnits)
        {
            units = new Unit[numUnits];
            BattleField();
        }

        public int TheSIZE
        {
            get { return SIZE; }
        }

        private void BattleField()
        {
            for(int i = 0; i < units.Length; i++)
            {
                if (random.Next(0, 2) == 0)
                {
                    MeleeUnit meleeUnit = new MeleeUnit();
                    meleeUnit.X = random.Next(0, SIZE);
                    meleeUnit.Y = random.Next(0, SIZE);

                    if(random.Next(0, 2) == 0)
                    {
                        meleeUnit.Faction = 0;
                    }
                    else
                    {
                        meleeUnit.Faction = 1;
                    }

                    units[i] = meleeUnit;
                }
                else 
                {
                    RangedUnit rangedUnit = new RangedUnit();
                    rangedUnit.X = random.Next(0, SIZE);
                    rangedUnit.Y = random.Next(0, SIZE);

                    if (random.Next(0, 2) == 0)
                    {
                        rangedUnit.Faction = 0;
                    }
                    else
                    {
                        rangedUnit.Faction = 1;
                    }

                    units[i] = rangedUnit;
                }
            }
        }

       /* public void UnitInformation(RichTextBox txtbox)
        {
            for (int i = 0; i < units.Length; i++)
            {
                txtbox.Text += units[i].ToString() + "\n";
            }
        }*/

        public string MapDisplay()
        {
            string map = "";
            for(int col = 0; col < SIZE; col++)
            {
                for (int row = 0; row < SIZE; row++)
                {
                    mapArray[col, row] = '\0';
                }
            }

            for(int i = 0; i < units.Length; i++)
            {
                mapArray[units[i].Y, units[i].X] = units[i].Symbol;
                Console.WriteLine(units[i].Y + units[i].X);
            }

            for(int col = 0; col < SIZE; col++)
            {
                for(int row = 0; row < SIZE; row++)
                {
                    if (mapArray[col, row] == '\0')
                    {
                        mapArray[col, row] = '=';
                        map += '=';
                        map += "  ";
                    }
                    else
                    {
                        map += mapArray[col, row];
                        map += "  ";
                    }
                }
                map += "\n";
            }
            return map;
        }

        
    }//
}//
