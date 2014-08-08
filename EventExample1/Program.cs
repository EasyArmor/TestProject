using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample1
{
    delegate void Cheeze();

    class Program
    {
        static void Main(string[] args)
        {
            Nose nose = new Nose();
            nose.ItchingINTheNose += new Cheeze(nose.MethodCheeze);            
            nose.StartEvent();
        }

                
    }

    class Nose
    {
        public event Cheeze ItchingINTheNose;

        public void StartEvent()
        {
            if (ItchingINTheNose != null)
                ItchingINTheNose();
        }

        public void MethodCheeze()
        {
            Console.WriteLine("Чьху!!!");
        }
    }
}
