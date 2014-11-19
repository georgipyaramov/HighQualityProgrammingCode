using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public void FindValue()
    {
        bool valueFound = false;
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(array[i]);
            if (i % 10 == 0)
            {
                if (array[i] == expectedValue)
                {
                    valueFound = true;
                    break;
                }
            }
        }
        // More code here
        if (valueFound)
        {
            Console.WriteLine("Value Found");
        }

    }
    
}

