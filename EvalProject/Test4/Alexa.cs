using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    public class Alexa
    {        
        public Alexa()
        {            
        }

        public string Talk()
        {            
            return String.IsNullOrEmpty(GreetingMessage) ? "hello, i am Alexa" : GreetingMessage.Replace("{OwnerName}", OwnerName);            
        }

        public string GreetingMessage { get; set; }

        public string OwnerName { get; set; }

        public void Configure(Action<Alexa> action)
        {
            action(this);
        }
    }
}
