using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
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
            Console.WriteLine("start paying indoor game");
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
            Console.WriteLine("start paying outdoor game");
        }
    }
}
