using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class FinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı...");
        }

        public void DoSometing()
        {
            throw new NotImplementedException();
        }
    }
}
