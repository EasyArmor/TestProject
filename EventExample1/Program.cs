using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample1
{
    //Add some remarks
    delegate void Cheeze();
    public delegate void Del(Subj ob);


    class Program
    {
        static void Main(string[] args)
        {
            Nose nose = new Nose();
            nose.ItchingINTheNose += new Cheeze(nose.MethodCheeze);            
            nose.StartEvent();
            Console.WriteLine("\n");

            Subj s = new Subj();
            SomeClass sc = new SomeClass();

            s.RegistrationMethod(sc.SomeMethod);
            s.StartSituation();
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
