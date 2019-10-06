using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18010755__Gregory_John_Bull__GADE5112__POE_Task_1
{
    public partial class FrmMap : Form
    {
        GameEngine GameEngine = new GameEngine();
        public FrmMap()
        {
            InitializeComponent();
           
            lblMap.Text = GameEngine.GetMap();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameEngine.Round();
            //map.UnitInformation(rchTxtBxList);
        }
    }//
}//
