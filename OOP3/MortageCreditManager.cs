using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortageCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı...");
        }

        public void DoSometing()
        {
            throw new NotImplementedException();
        }
    }
}
