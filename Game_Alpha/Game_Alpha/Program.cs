using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Alpha
{
    class ItemManager
    {
        public enum eItem { WoodSword, BoneSword, WoodenArmor, BoneArmor, Ring, BoneRing, HPPotion, MPPotion, Sotne, Boom, MAX }
        List<Item> m_listItemList;

        public ItemManager()
        {
            m_listItemList = new List<Item>(); // 생성자 만듦

            m_listItemList.Add(new Item(Item.eItemKind.Weapon, "목검(Wooden Sword)", "데미지증가", new Status(100), 100));
            m_listItemList.Add(new Item(Item.eItemKind.Weapon, "본 소드(Bone Sword)", "데미지증가", new Status(200), 200));
            m_listItemList.Add(new Item(Item.eItemKind.Armor, "나무갑옷(Wooden Armor)", "방어력증가", new Status(0, 100), 100));
            m_listItemList.Add(new Item(Item.eItemKind.Armor, "본 아머(Bone Armor)", "방어력증가", new Status(0, 200), 200));
            m_listItemList.Add(new Item(Item.eItemKind.Acc, "나무반지(Wooden Ring)", "지능증가", new Status(0, 0, 100), 100));
            m_listItemList.Add(new Item(Item.eItemKind.Acc, "해골반지(Skull Ring)", "지능증가", new Status(0, 0, 200), 200));
            m_listItemList.Add(new Item(Item.eItemKind.Etc, "힐링포션(Healing Potion)", "체력회복", new Status(0, 0, 0, 100), 100));
            m_listItemList.Add(new Item(Item.eItemKind.Etc, "마나포션(Mana Potion)", "마나회복", new Status(0, 0, 0, 0, 100), 100));
            m_listItemList.Add(new Item(Item.eItemKind.Etc, "짱돌(Great Stone)", "단일 적 데미지", new Status(100), 100));
            m_listItemList.Add(new Item(Item.eItemKind.Etc, "폭탄(Bomb)", "다수 적 데미지", new Status(100), 100));

        }

        public Item GetItem(eItem idx)
        {
            return m_listItemList[(int)idx];
        }
    }
    // 아이템 메니저 생성.
    // 아이템 메니저를 통하여 아이템 종류 및 설정을 변경할 수 있다.
    class Item
    {
        public enum eItemKind { Weapon, Armor, Acc, Etc } // enum을 이용해 아이템 종류 지정

        public Item(eItemKind eitemkind, string name, string comment, Status sStatus, int nGold)
        {
            m_eItemKind = eitemkind;
            m_strName = name; m_strComment = comment;
            m_sFunc = sStatus;
            m_nGold = nGold;
        } // 아이템 생성자 지정
        // 종류, 템명, 템설명, 능력치, 판매가

        eItemKind m_eItemKind;
        Status m_sFunc;
        string m_strName, m_strComment;
        int m_nGold;

        // 
        public eItemKind ItemKind
        {
            get { return m_eItemKind; }
            set { m_eItemKind = value; }
        } // 통합 접근제한자(get, set 동시지원)

        public string Name
        {
            get { return m_strName; }
            set { m_strName = value; }
        }

        public string Comment
        {
            get { return m_strComment; }
            set { m_strComment = value; }
        }

        public Status Func
        {
            get { return m_sFunc; }
            set { m_sFunc = value; }
        }

        public int Gold
        {
            get { return m_nGold; }
            set { m_nGold = value; }
        }

    }

    struct Status
    {
        public int m_nHp;
        public int m_nMp;
        public int m_nStr, m_nDef, m_nInteli;

        public Status(int nStr = 0, int nDef = 0, int nInteli = 0, int nHp = 0, int nMp = 0)
        {
            m_nHp = nHp;
            m_nMp = nMp;
            m_nStr = nStr; m_nDef = nDef; m_nInteli = nInteli;
        }
        // 구조체 기본 생성자를 이용하여 구조체 영역 초기화
        // 구조체 멤버 변수 초기화

        public static Status operator +(Status a, Status b)
        {
            return new Status(a.m_nHp + b.m_nHp, a.m_nMp + b.m_nMp,
                a.m_nStr + b.m_nStr, a.m_nDef + b.m_nDef, a.m_nInteli + b.m_nInteli);
        }

        public static Status operator -(Status a, Status b)
        {
            return new Status(a.m_nHp - b.m_nHp, a.m_nMp - b.m_nMp,
                a.m_nStr - b.m_nStr, a.m_nDef - b.m_nDef, a.m_nInteli - b.m_nInteli);
        }

        public void AddStatus(int var)
        {
            m_nHp += var; m_nMp += var;
            m_nStr += var; m_nDef += var; m_nInteli += var;
        }

        // 연산자 오버로딩

    }// 정적할당 목적을 위한 구조체 생성


    class Player
    {
        // 스텟        
        Status m_cStatus;
        // 이름
        string m_strName;
        int m_nLv, m_nExp;
        int m_nMaxHp, m_nMaxMp;

        int m_nGold; // 소지금
        List<Item> m_listInventory = new List<Item>(); // 인벤토리
        List<Item> m_listEquip = new List<Item>(); // 장비창
        public enum eEquipKind { Weapon, Armor, Acc, MAX }

        public Player(string name, int nHp = 100, int nMp = 100, int nStr = 10, int nDef = 10, int nInteli = 10, int nExp = 0, int nGold = 100)
        {
            m_cStatus = new Status(nStr, nDef, nInteli, nHp, nMp);
            m_strName = name;
            m_nMaxHp = nHp; m_nMaxMp = nMp;
            m_nExp = nExp; m_nGold = nGold;
            m_nLv = 1;


        }
        // 플레이어 생성자 작성과 동시에 상태 생성자 생성

        

        public void Attack(Player cTarget)
        {
            cTarget.m_cStatus.m_nHp -= (m_cStatus.m_nStr - cTarget.m_cStatus.m_nDef);
        }

        public bool Dead()
        {
            if (m_cStatus.m_nHp <= 0)
                return true;
            return false;
        }

        public void Recovery()
        {
            m_cStatus.m_nHp = m_nMaxHp;
            m_cStatus.m_nMp = m_nMaxMp;
        } // 마을 회복

        public bool Buy(int nInventoryIdx, Player cTarget)
        {
            Item cItem = cTarget.GetInventory(nInventoryIdx);
            if (cItem.Gold <= m_nGold)
            {
                SetInventory(cItem);
                m_nGold -= cItem.Gold;
                return true;
            }
            return false;
        }

        public void Sell(int nInventoryIdx)
        {
            Item cItem = GetInventory(nInventoryIdx);
            DeleteInventory(cItem);
            m_nGold += cItem.Gold;
        }

        public void SetInventory(Item item)
        {
            m_listInventory.Add(item);
        } // 인벤토리 아이템 추가

        public Item GetInventory(int idx)
        {
            return m_listInventory[idx];
        } // 템 얻기

        public void StillItem(Player cTarget)
        {
            SetInventory(cTarget.GetInventory(0));
            m_nExp += cTarget.m_nExp;
        } // 템 뺐기

        public bool LvUp(int var = 10, int maxexp = 100)
        {
            if (m_nExp > maxexp)
            {
                m_cStatus.AddStatus(10);
                m_nMaxHp += var; m_nMaxMp += var;
                m_nExp -= maxexp;
                return true;
            }
            return false;


        }

        public void DeleteInventory(Item item)
        {
            m_listInventory.Remove(item);
        }// 인벤토리 아이템 제거



        public void SetEquip(Item item)
        {
            if (item.ItemKind < Item.eItemKind.Etc)
            {
                ReleaseEquip((eEquipKind)item.ItemKind);
                Item cEquipItem = m_listEquip[(int)eEquipKind.Weapon];
                m_cStatus += item.Func;

                DeleteInventory(item);
            }// 해당 아이템을 끼고 있다면 장착 해제하고 매개변수로 온 아이템을 장착

        }// 아이템 장착 멤버함수

        public void ReleaseEquip(eEquipKind eEquipment)
        {
            Item cEquipItem = m_listEquip[(int)eEquipment];

            if (cEquipItem != null)
            {
                SetInventory(cEquipItem);
                m_cStatus -= cEquipItem.Func;
            } // 끼고 있는 탬이 없으면 스테이스터에스 아이템 장착 기능을 빼버린다.

        } // 아이템해제

        public void Show()
        {
            Console.WriteLine(String.Format("############ {0} ##########", m_strName));
            Console.WriteLine(String.Format("HP : {0}/{1}", m_cStatus.m_nHp, m_nMaxHp));
            Console.WriteLine(String.Format("MP : {0}/{1}", m_cStatus.m_nMp, m_nMaxMp));
            Console.WriteLine(String.Format("HP : Str/Int/Def:{0}/{1}/{2}", m_cStatus.m_nStr, m_cStatus.m_nDef, m_cStatus.m_nInteli));
            Console.WriteLine(String.Format("Lv:{0}", m_nLv)); Console.WriteLine(String.Format("Lv:{0}", m_nGold));
            Console.WriteLine(String.Format("Lv:{0}", m_nExp));

        } // 상태 표시

        public void ShowInventory()
        {
            Console.WriteLine(String.Format("############ Equipment ##########", m_strName));
            for (int i = 0; i < m_listEquip.Count; i++)
            {
                Console.WriteLine(String.Format("{0} : {1}", (eEquipKind)i, m_listEquip[i].Name));
            } // 현재 장비중인 장비 표시

            Console.WriteLine(String.Format("############ Inventory ##########", m_strName));
            for (int i = 0; i < m_listInventory.Count; i++)
            {

                Console.WriteLine(String.Format("{0} : {1}", i, m_listInventory[i].Name));
            } // 현재 인벤토리 표시

        }
    }

    class Program
    {
        

        static bool Battle(Player cPlayer, Player cMonster)
        {
            Console.WriteLine("#############");
            if (!cPlayer.Dead())
                cPlayer.Attack(cMonster);
            else
            {
                m_eStage = eStage.GAMEOVER;


            }

            cMonster.Show();
            if (!cMonster.Dead())
                cMonster.Attack(cPlayer);
            else
            {
                Console.WriteLine(String.Format("몬스터를 쓰러뜨렸습니다!"));
                cPlayer.StillItem(cMonster);
                cPlayer.ShowInventory();
                if (cPlayer.LvUp())
                {
                    Console.WriteLine(String.Format("Level Up!"));
                    cPlayer.Show();
                    m_eStage = eStage.TOWN;
                    return true;
                }
            }
            return false;
        }
        static void swapStatus(Status a, Status b)
        {
            int temp = a.m_nStr;
            a.m_nStr = b.m_nStr;
            b.m_nStr = temp;
        }

        static void SwapTest()
        {
            Status sA, sB;
            sA = new Status(100); // 동적할당으로 전환
            sB = new Status(0, 100); // 동적할당으로 전환
            swapStatus(sA, sB);
            Console.WriteLine("{0}, {1}", sA.m_nStr, sA.m_nDef);
            Console.WriteLine("{0}, {1}", sB.m_nStr, sB.m_nDef);
            
        }

        static void Main(string[] args)
        {
            GameManager cGameManager = new GameManager();
            ItemManager cItemManager = new ItemManager();
            eMonster m_eMonster = eMonster.SLIME;
            Player cPlayer = null; // 구조체 포인터와 유사한 역할을 함. C++기준으로 동적할당이 됨.
            Player cMonster = null;
            Player cStore = new Player("Store");
            // C#에서 구조체는 무조건 정적할당.


            cStore.SetInventory(cItemManager.GetItem(ItemManager.eItem.HPPotion));
            cStore.SetInventory(cItemManager.GetItem(ItemManager.eItem.MPPotion));
            cStore.SetInventory(cItemManager.GetItem(ItemManager.eItem.Sotne));
            cStore.SetInventory(cItemManager.GetItem(ItemManager.eItem.Boom));

            Status sStatus = new Status(100);
            



            int nSelect;

            while (cGameManager.e != eStage.GAMEOVER)
            {
                switch (m_eStage)
                {
                    case eStage.CREATE:
                        Console.Write("캐릭터 이름 입력 : ");
                        string strName = Console.ReadLine();
                        cPlayer = new Player(strName, 100, 100, 10, 10, 10, 0, 100);
                        m_eStage = eStage.TOWN;
                        break;
                    case eStage.STORE:
                        Console.WriteLine("뭘 할 건가요? 1. 구매 2. 판매 etc. 마을");
                        nSelect = int.Parse(Console.ReadLine());
                        if (nSelect == 1)
                        {
                            cStore.ShowInventory();
                            nSelect = int.Parse(Console.ReadLine());
                            cPlayer.Buy(nSelect, cStore);
                        }
                        else if (nSelect == 2)
                        {
                            cPlayer.ShowInventory();
                            nSelect = int.Parse(Console.ReadLine());
                            cPlayer.Sell(nSelect);
                        }
                        else
                        {
                            m_eStage = eStage.TOWN;
                        }
                        break;
                    case eStage.TOWN:
                        cPlayer.Recovery();
                        Console.WriteLine("마을입니다.\n\n체력회복 완료!\n어디로 갈 건가요? ");
                        for (int i = (int)eStage.FILED; i < (int)eStage.GAMEOVER; i++)
                            Console.WriteLine(String.Format("{0}. {1}", i, (eStage)i));
                        m_eStage = (eStage)int.Parse(Console.ReadLine());
                        break;
                    case eStage.INVENTORY:
                        cPlayer.ShowInventory();
                        Console.Write("어떻게 할 건가요?\n1. 장착 2. 수리 etc. 마을");
                        nSelect = int.Parse(Console.ReadLine());

                        if (nSelect == 1)
                        {

                        }
                        else if (nSelect == 2)
                        {
                            nSelect = int.Parse(Console.ReadLine());
                            Item cItem = cPlayer.GetInventory(nSelect);
                            for (int i = 0; i < (int)Player.eEquipKind.MAX; i++)
                                Console.WriteLine(String.Format("{0}. {1}", i, (Player.eEquipKind)i));
                        }
                        else
                        {
                            m_eStage = eStage.TOWN;
                        }
                        break;
                    case eStage.FILED:
                        Console.Write("사냥터를 선택하세요 ");
                        for (int i = (int)eMonster.SLIME + 1; i < (int)eMonster.MAX; i++)
                            Console.WriteLine(String.Format("{0}. {1}", i, (eMonster)i));
                        m_eMonster = (eMonster)int.Parse(Console.ReadLine());
                        switch (m_eMonster)
                        {
                            case eMonster.SLIME:
                                cMonster = new Player("Slime", 100, 100, 20, 0, 0, 100, 0);
                                cMonster.SetInventory(cItemManager.GetItem(ItemManager.eItem.WoodSword));
                                cMonster.SetInventory(cItemManager.GetItem(ItemManager.eItem.WoodenArmor));
                                cMonster.SetInventory(cItemManager.GetItem(ItemManager.eItem.Ring));
                                break;
                            case eMonster.SKELETON:
                                cMonster = new Player("Skeleton", 200, 200, 30, 0, 0, 200, 0);
                                cMonster.SetInventory(cItemManager.GetItem(ItemManager.eItem.BoneSword));
                                cMonster.SetInventory(cItemManager.GetItem(ItemManager.eItem.BoneArmor));
                                cMonster.SetInventory(cItemManager.GetItem(ItemManager.eItem.BoneRing));
                                break;
                            case eMonster.BOSS:
                                cMonster = new Player("Boss", 400, 400, 50, 0, 0, 500, 0);
                                cMonster.SetInventory(cItemManager.GetItem(ItemManager.eItem.WoodenArmor));
                                cMonster.SetInventory(cItemManager.GetItem(ItemManager.eItem.Ring));
                                break;
                            default:
                                break;
                        }
                        m_eStage = eStage.BATTLE;
                        break;
                    case eStage.BATTLE:
                        Battle(cPlayer, cMonster);
                        break;
                    case eStage.THE_END:
                        Console.WriteLine("THE END");
                        break;
                }
            }

            cPlayer.Show();
            Console.WriteLine("#############");
        }

    }
}

