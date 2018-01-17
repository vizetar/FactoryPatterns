using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{

    public abstract class BaseFactory 
    {
        public void DisplayResult()
        {
            ISports sports = this.Create();
            sports.Play();
            sports.Exit();
        }

        public abstract ISports Create();
        
    }

    public class IndoorFactory : BaseFactory
    {
        public override ISports Create()
        {
            Indoor indoor = new Indoor();
            indoor.Chess();
            return indoor;
        }
    }

    public class OutdoorFactory : BaseFactory
    {
        public override ISports Create()
        {
            Outdoor outdoor = new Outdoor();
            outdoor.Football();
            return outdoor;
        }
    }
}
