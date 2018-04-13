using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomEscape
{

    class Player
    {
        List<int> KeyPiece = new List<int>();
        string pName; int maxPosition;
        public Player(string name, int maxPoint)
        {
            pName = name;
            maxPosition = maxPoint;
        }



        public void getKey(int keyNum)
        {
            Console.WriteLine("{0}번째 열쇠조각을 찾아냈다.", keyNum);
            KeyPiece.Add(keyNum);
        }

        public void makeKey()
        {
            if(KeyPiece.Count==maxPosition)
            {
                KeyPiece.Clear();
                Console.WriteLine("열쇠를 완성했다.\n얼른 탈출하자!");
                checkWin();
            }
            else
            {
                Console.WriteLine("이게 아닌데?");
            }
        }

        public void checkWin()
        {
            Console.WriteLine("\n\n탈출에 성공했다.\n");
            Console.WriteLine("THE END");
        }
    }
    
    class Position
    {
        string pName; bool isExp;

        public Position(string name)
        {
            pName = name;
            isExp = false;
        }
        public void setExp()
        {
            isExp = true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력 : ");
            string name=Console.ReadLine();
            Console.Write("장소 개수 입력 : ");
            int maxPosition = int.Parse(Console.ReadLine());

            Player cPlayer = new Player(name, maxPosition);
            Position[] acPosition;
            acPosition = new Position[maxPosition];
            for(int i=0;i<maxPosition;i++)
            {
                Console.Write("장소를 입력 : ");
                string positionName = Console.ReadLine();
                acPosition[i] = new Position(positionName);
            }



        }
    }
}
