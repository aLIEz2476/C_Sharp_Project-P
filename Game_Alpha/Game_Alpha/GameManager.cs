using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Alpha
{
    class GameManager
    {
        public enum eStage { CREATE, TOWN, INVENTORY, STORE, FILED, BATTLE, GAMEOVER, THE_END }
        public enum eMonster { SLIME, SKELETON, BOSS, MAX }
        eStage m_eStage=eStage.CREATE; eMonster m_eMonster;
        ItemManager m_cItemManager = new ItemManager();
        Player m_cPlayer;
        Player m_cStore;
        Player m_cMonster=new Player("Store");


        public eStage Stage
        {
            get { return m_eStage; }

        }

        public void Init()
        {
            m_cMonster = null;
            m_cPlayer = null;
            m_cStore.SetInventory(m_cItemManager.GetItem(ItemManager.eItem.HPPotion));
            m_cStore.SetInventory(m_cItemManager.GetItem(ItemManager.eItem.MPPotion));
            m_cStore.SetInventory(m_cItemManager.GetItem(ItemManager.eItem.Sotne));
            m_cStore.SetInventory(m_cItemManager.GetItem(ItemManager.eItem.Boom));
        }


        public void EventCreate()
        {
            Console.Write("캐릭터 이름 입력 : ");
            string strName = Console.ReadLine();
            m_cPlayer = new Player(strName, 100, 100, 10, 10, 10, 0, 1000000);
            m_eStage = eStage.TOWN;
        }

        public void EventTown()
        {
            m_cPlayer.Recovery();
            Console.WriteLine("마을입니다.\n\n체력회복 완료!\n어디로 갈 건가요? ");
            for (int i = (int)eStage.FILED; i < (int)eStage.GAMEOVER; i++)
                Console.WriteLine(String.Format("{0}. {1}", i, (eStage)i));
            m_eStage = (eStage)int.Parse(Console.ReadLine());
        }

        public void EventStore()
        {
            Console.WriteLine("뭘 할 건가요? 1. 구매 2. 판매 etc. 마을");
            int nSelect = int.Parse(Console.ReadLine());
            if (nSelect == 1)
            {
                m_cStore.ShowInventory();
                nSelect = int.Parse(Console.ReadLine());
                m_cPlayer.Buy(nSelect, m_cStore);
            }
            else if (nSelect == 2)
            {
                m_cPlayer.ShowInventory();
                nSelect = int.Parse(Console.ReadLine());
                m_cPlayer.Sell(nSelect);
            }
            else
            {
                m_eStage = eStage.TOWN;
            }
        }

        public void EventInventory()
        {
            m_cPlayer.ShowInventory();
            Console.Write("어떻게 할 건가요?\n1. 장착 2. 수리 etc. 마을");
            int nSelect = int.Parse(Console.ReadLine());

            if (nSelect == 1)
            {

            }
            else if (nSelect == 2)
            {
                nSelect = int.Parse(Console.ReadLine());
                Item cItem = m_cPlayer.GetInventory(nSelect);
                for (int i = 0; i < (int)Player.eEquipKind.MAX; i++)
                    Console.WriteLine(String.Format("{0}. {1}", i, (Player.eEquipKind)i));
            }
            else
            {
                m_eStage = eStage.TOWN;
            }
        }

        void EventField()
        {
            Console.Write("사냥터를 선택하세요 ");
            for (int i = (int)eMonster.SLIME + 1; i < (int)eMonster.MAX; i++)
                Console.WriteLine(String.Format("{0}. {1}", i, (eMonster)i));
            m_eMonster = (eMonster)int.Parse(Console.ReadLine());
            switch (m_eMonster)
            {
                case eMonster.SLIME:
                    m_cMonster = new Player("Slime", 100, 100, 20, 0, 0, 100, 0);
                    m_cMonster.SetInventory(m_cItemManager.GetItem(ItemManager.eItem.WoodenSword));
                    m_cMonster.SetInventory(m_cItemManager.GetItem(ItemManager.eItem.WoodenArmor));
                    m_cMonster.SetInventory(m_cItemManager.GetItem(ItemManager.eItem.WoodenRing));
                    break;
                case eMonster.SKELETON:
                    m_cMonster = new Player("Skeleton", 200, 200, 30, 0, 0, 200, 0);
                    m_cMonster.SetInventory(m_cItemManager.GetItem(ItemManager.eItem.BoneSword));
                    m_cMonster.SetInventory(m_cItemManager.GetItem(ItemManager.eItem.BoneArmor));
                    m_cMonster.SetInventory(m_cItemManager.GetItem(ItemManager.eItem.BoneRing));
                    break;
                case eMonster.BOSS:
                    m_cMonster = new Player("Boss", 400, 400, 50, 0, 0, 500, 0);
                    m_cMonster.SetInventory(m_cItemManager.GetItem(ItemManager.eItem.WoodenArmor));
                    m_cMonster.SetInventory(m_cItemManager.GetItem(ItemManager.eItem.WoodenRing));
                    break;
                default:
                    break;
            }
            m_eStage = eStage.BATTLE;
        }

        public bool EventBattle()
        {
            Console.WriteLine("#############");
            if (!m_cPlayer.Dead())
                m_cPlayer.Attack(m_cMonster);
            else
            {
                m_eStage = eStage.GAMEOVER;
                return true;

            }

            m_cMonster.Show();
            if (!m_cMonster.Dead())
                m_cMonster.Attack(m_cPlayer);
            else
            {
                Console.WriteLine(String.Format("몬스터를 쓰러뜨렸습니다!"));
                m_cPlayer.StillItem(m_cMonster);
                m_cPlayer.ShowInventory();
                if (m_cPlayer.LvUp())
                {
                    Console.WriteLine(String.Format("Level Up!"));
                    m_cPlayer.Show();
                    m_eStage = eStage.TOWN;
                    return true;
                }
            }
            m_cPlayer.Show();
            Console.WriteLine("##################");
            return false;
        }

        

    }
}
