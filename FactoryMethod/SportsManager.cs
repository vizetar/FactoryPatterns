using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public interface ISports
    {
        void Play();
        void Exit();
    }

    public class Indoor : ISports
    {
        public void Exit()
        {
            Console.WriteLine("exit indoor game successfully");
        }

        public void Play()
        {
            Console.WriteLine("indoor game started");
        }
        public void Chess()
        {
            Console.WriteLine("start playing chess");
        }
    }

    public class Outdoor : ISports
    {
        public void Exit()
        {
            Console.WriteLine("exit outdoor game successfully");
        }

        public void Play()
        {
            Console.WriteLine("outdoor game started");
        }
        public void Football()
        {
            Console.WriteLine("start playing football");
        }
    }
}
