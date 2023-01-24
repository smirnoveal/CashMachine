using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashMachine
{
    public class Workbankomat
    {
        public string Pin;
        public static String message;


        //В данном методе устанавливаем возможность попыток пинкода и исхода, в случае если пин-код неверный
        public void PinCode(Client client) 
        {
            for (int i = 3; i > 0; i--)
            {
                if (i == 0)
                {
                    message = "Ваша карта заблокирована";
                    BlockCard();
                    break;
                }
                else
                {
                    if (Pin.Length != 4)
                    {
                        message = "Пин-код неверный, введите Пин-код, состоящий из 4-х цифр";
                    }
                    if (Pin.Equals(value: client.PinCode) != true)
                    {
                        message = "Пин-код неверный, введите Пин-код";
                    }
                    else
                    {
                        message = "Ваша карта заблокирована";
                        BlockCard();
                        break;
                    }
                }
               
            }
           
        }

        public void BlockCard()
        {
            throw new NotImplementedException();
        }

        public void BlockCard(Client client, string message) 
        {
            using (StreamWriter writetext = new StreamWriter("Confiscation.txt"))
            {
                writetext.WriteLine(Client.NumberCard);
            }
            CashMachine.Exit();
        }

        public void Acces(string NumberCard) 
        
        {
            CashMachine.NumberCard = NumberCard;
            //Сравниваем введенный номер в текстбокс номера карты с конфискованными картами, если карты там нет, то записываем новую карту в файл Card
            using (StreamWriter writetext = new StreamWriter("Card.txt"))
            {
                writetext.WriteLine(NumberCard);
            }
            //далее запускаем метод PinCode, для проверки пинкода
            PinCode();

        }

        private void PinCode()
        {
            throw new NotImplementedException();
        }
    }
}
