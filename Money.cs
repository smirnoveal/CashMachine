using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    
    internal class Money
    {
        int money_bank;
        public static void balance() 
        {
            //Открываем текстовый файл Card, в котором указана сумма на счету, она выводится на Label
        }

        public static void OutCash(int money_bank, int sum) 
        {
            //Открываем текстовый файл Bank, в котором указана сумма в банкомате и купюры, а также текстовый файл Card, в котором указана сумма на счету
            //Если введенная сумма в наличии в банке и у клиента, её вычитают из счета клиента становится активной кнопка "Заберите Вашу карту",сумма выводится на Label
        }

        public static void Transfer()
        {
            //Открываем текстовый файл Card, в котором указана сумма на счету, в поле ввода вводится 16 значный код другой карты, осуществляется перевод
            //Из счета клиента вычитается сумма перевода, в файл Card вводится номер карты получателя и сумма перевода
        }

        internal static void OutCash()
        {
            throw new NotImplementedException();
        }
    }
}
