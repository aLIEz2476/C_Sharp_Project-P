using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCS.CShap;
using WF_Test.Properties;


namespace WF_Test
{
    public partial class UseItem : Form
    {
        Form1 m_cForm;
        public UseItem(Form1 form)
        {
            m_cForm = form;
            InitializeComponent();
        }
        private void btn_Inven_Use_Click(object sender, EventArgs e)
        {
            Player cPlayer = GameManager.GetInstance().Player;
            int idx = Inventory_Box.SelectedIndex;
            GameManager.GetInstance().EventItem(idx);
            m_cForm.TurnEnd(cPlayer, this, "");
            this.Close();

        }
        private void btn_Inven_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inventory_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void InitInventoryList()
        {
            
            List<Item> listInventory = new List<Item>();
            ListBox listboxInventory = new ListBox();

            listboxInventory.Items.Add(listInventory);

        }

        

        
    }
}
