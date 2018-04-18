using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Test.Properties;
using NCS.CShap;


namespace WF_Test
{
    public partial class Form1 : Form
    {
        GameManager m_cGameManager=new GameManager();
        public Form1()
        {
            m_cGameManager.Init();
            InitializeComponent();
        }




        private void Btn_Item_Click(object sender, EventArgs e)
        {
            ItemManager inventory = new ItemManager();
            UseItem cUseItem = new UseItem(this);
            cUseItem.TopMost = true;
            cUseItem.Show();
            
        }

        private void Btn_Atk_Click(object sender, EventArgs e)
        {
            m_cGameManager.EventAttack();
        }

        private void Btn_Skill_Click(object sender, EventArgs e)
        {
            m_cGameManager.EventAttack();
        }

        private void Btn_Run_Click(object sender, EventArgs e)
        {
            
        }

        private void Mon_HP_Click(object sender, EventArgs e)
        {
            
        }

        public void SetProgressBar(object Target, int hp, int mp)
        {

        }

        public void TurnEnd(Player cPlayer, Player cTarget, string msg)
        {
            
        }

    }
}
