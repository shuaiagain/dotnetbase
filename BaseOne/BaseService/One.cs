using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace BaseService
{
    public class One
    {
        public static void EqualDiff()
        {
            string a = "123";
            string b = "123";

            Console.WriteLine("a={0},b={1}, a==b is:{2}", a, b, a == b);
            Console.WriteLine("a.hashcode={0},b.hashcode={1}", a.GetHashCode(), b.GetHashCode());

            string c = a;
            Console.WriteLine("b={0},c={1}, b==c is:{2}", b, c, b == c);
            Console.WriteLine("b.hashcode={0},c.hashcode={1}", b.GetHashCode(), c.GetHashCode());


            Console.WriteLine("a={0},b={1}, a.Equals(b) is:{2}", a, b, a.Equals(b));

            int aa = 1;
            int bb = 1;
            aa.Equals(bb);
            Console.WriteLine("aa={0},bb={1}, aa.Equals(bb) is:{2}", aa, bb, aa.Equals(bb));
            Console.WriteLine("aa={0},bb={1}, aa==bb is:{2}", aa, bb, aa == bb);

            OneDTO d = new OneDTO { Name = "123" };
            OneDTO e = new OneDTO { Name = "123" };
            OneDTO f = d;
            Console.WriteLine("d={0},e={1}, d.Equals(e) is:{2}", d, e, d.Equals(e));
            Console.WriteLine("d={0},e={1}, d==e is:{2}", d, e, d == e);

            Console.WriteLine("d={0},f={1}, d.Equals(f) is:{2}", d, f, d.Equals(f));
            Console.WriteLine("d={0},f={1}, d==f is:{2}", d, f, d == f);


            Console.WriteLine("========");
            Console.WriteLine("========");

            string cc = new string(new char[] { '1', '2' });
            string dd = new string(new char[] { '1', '2' });
            Console.WriteLine("cc={0},dd={1}, cc.Equals(dd) is:{2}", cc, dd, cc.Equals(dd));
            Console.WriteLine("cc={0},dd={1}, cc==dd is:{2}", cc, dd, cc == dd);

            object h = cc;
            string.Intern(cc);
            object i = dd;
            Console.WriteLine("h={0},cc={1}, h.Equals(cc) is:{2}", h, cc, h.Equals(cc));
            Console.WriteLine("h={0},i={1}, h==i is:{2}", h, i, h == i);
            Console.WriteLine("h={0},i={1}, h.Equals(i) is:{2}", h, i, h.Equals(i));

        }
    }
}
