using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate_Cookie
{
    class Cookie
    {
        public Cookie()
        {
            Console.WriteLine("Cookie~!");
        }
    }

    class MilkCookie : Cookie
    {
        public MilkCookie()
        {
            Console.WriteLine("MilkCookie~!");
        }
    }

    class ChocolateCookie : Cookie
    {
        public ChocolateCookie()
        {
            Console.WriteLine("ChocolateCookie!");
        }
    }

    class AlmondChocoCookie:ChocolateCookie
    {
        string a = "Almond";
        public AlmondChocoCookie()
        {
            Console.WriteLine(a + " ChocoCookie!");
        }
    }

    class MacadamiaChocoCookie:ChocolateCookie
    {
        string m = "Macadamia";
        public MacadamiaChocoCookie()
        {
            Console.WriteLine(m + " ChocoCookie!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cookie ck = new Cookie();
            MilkCookie mck = new MilkCookie();
            ChocolateCookie cck = new ChocolateCookie();
            AlmondChocoCookie ack = new AlmondChocoCookie();
            MacadamiaChocoCookie mcck = new MacadamiaChocoCookie();
        }
    }
}
