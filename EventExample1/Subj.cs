using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample1
{
    public class Subj
    {
        private Del del;

        public void RegistrationMethod(Del d)
        {           
            del += d;
        }

        public void StartSituation()
        {
            if (del != null)
            {
                Console.WriteLine("Action in Subj");
                del(this);
            }
        }
    }
}
