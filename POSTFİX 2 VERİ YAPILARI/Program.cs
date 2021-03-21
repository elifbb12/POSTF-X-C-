using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTFİX_2_VERİ_YAPILARI
{
    class Program
    {
        public delegate int YeniDelagate(int p, int q);
        static void calistir(int a, int b, YeniDelagate yd)
        {
            Console.WriteLine(yd(a, b));
        }
        static int topla(int a, int b)
        {
            return a + b;
        }
        static int cıkart(int a, int b)
        {
            return a - b;
        }
        static int carp(int a, int b)
        {
            return a * b;
        }
        static int bol(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            string postfix = "abc*+";  //abcdefgh*+; abc de  fgh;
            
             string alfabe = "abcdefghjklmn";
            int[] value = { 10, 20, 2 ,56,78,90,56,34,12,34,};
            Stack<int> st = new Stack<int>();
            string op = " +-*/";
            for (int i = 0; i < postfix.Length; i++)
            {
                int adr = op.IndexOf(postfix[alfabe.IndexOf(postfix[i])]); //çok önemli bir yapıdır.
                if(adr==-1)
                {
                    st.Push(value[i]);
                    continue;
                }
                int oprnd2 = st.Pop();
                int oprnd1 = st.Pop();
                if(adr==0)
                {
                    st.Push(topla(oprnd1,oprnd2));
                    continue;
                }
                if(adr==1)
                {
                    st.Push(cıkart(oprnd1, oprnd2));
                    continue;
                }
                if (adr == 2)
                {
                    st.Push(carp(oprnd1, oprnd2));
                    continue;
                }
                if (adr == 2)
                {
                    st.Push(bol(oprnd1, oprnd2));
                    continue;
                }
                Console.WriteLine(st.Pop());
            }
            Console.ReadLine();
        }
    }
}
