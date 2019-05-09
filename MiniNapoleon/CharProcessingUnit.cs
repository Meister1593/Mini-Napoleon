using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MiniNapoleon
{
    //23 6
    public class CharProcessingUnit
    {
        // Таблица соответсвий буквы и кода
        // 53
        // Символ и код имеют одинаковый индекс между таблицами
        private string[] napoleonStrings =
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" ,"L",
            "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V",
            "Z", "ar", "bu", "ca", "de", "es", "fa", "ga", "hi", "jai",
            "lu", "ma", "ne", "ot", "po", "que", "ra", "sa", "ti", "ve",
            "al", "bo", "ce", "et", "fe", "le", "ni", "re", "se", "to",
            "vi", "bi", "en", "fo", "la", "ri", "si", "vo", "so", "su"
        };

        private int[] napoleonInts =
        {
            15, 37, 6, 23, 53, 55, 81, 85, 119, 87, 96,
            114, 115, 90, 137, 173, 169, 167, 176, 138,
            164, 166, 25, 3, 32, 52, 82, 69, 51, 77,
            122, 103, 107, 94, 153, 152, 136, 146, 171, 145,
            132, 39, 35, 20, 50, 58, 117, 116, 126, 177,
            157, 161, 29, 68, 71, 106, 148, 134, 175, 168, 174
        };

        /*
         *Этот кусок принадлежит шифратору
         *intFromString != 0 Говорит о том, что у нас нашёлся символ из таблицы и можно подставлять
         *Программа ставит в конец наш код и удаляет символ в начале с помощью StringBuilder
         */
        public StringBuilder TextToInts(string inputText)
        {
            inputText = inputText.Trim();
            StringBuilder outputString = new StringBuilder(inputText);
            if (outputString[0].ToString() == " ")
            {
                outputString.Remove(0, 1);
            }

            for (int i = 0; i < inputText.Length; i++)
            {
                int intFromString = ReturnIntFromString(inputText[i].ToString());
                if (intFromString != 0)
                {
                    outputString.Append(intFromString);
                    outputString.Append(" ");
                    outputString.Remove(0, 1);
                    continue;
                }

                if (i + 1 < inputText.Length)
                {
                    intFromString = ReturnIntFromString(inputText[i].ToString() + inputText[i + 1].ToString());
                    if (intFromString != 0)
                    {
                        outputString.Append(intFromString);
                        outputString.Append(" ");
                        outputString.Remove(0, 2);
                        continue;
                    }
                }

                if (i + 2 < inputText.Length)
                {
                    intFromString = ReturnIntFromString(inputText[i].ToString() + inputText[i + 1].ToString() +
                                                        inputText[i + 2].ToString());
                    if (intFromString != 0)
                    {
                        outputString.Append(intFromString);
                        outputString.Append(" ");
                        outputString.Remove(0, 3);
                    }
                }
            }

            outputString.Remove(outputString.Length - 1, 1);
            return outputString;
        }

        /*
         *Тут перевод из цифрового представления в символьное (дешифратор)
         *Принцип очень схож с шифрованием, за исключением того, что учитываются пробелы между кодами
         *Вместо 0 , stringFromInt использует знак / , не присутствующий в таблице.
         *Чтобы удостовериться, что у нас точно один символ или 2 или 3, проверяем i + 1 или i+2 символ на наличие пробела.
         */
        public StringBuilder IntsToText(string inputInts)
        {
            inputInts = inputInts.Trim();
            StringBuilder outputString = new StringBuilder(inputInts);
            if (outputString[0].ToString() == " ")
            {
                outputString.Remove(0, 1);
            }

            
            outputString.Append(" ");
            for (int i = 0; i < inputInts.Split(' ').Length; i++)
            {
                string stringFromInt = ReturnStringFromInt(outputString[0].ToString());
                if (stringFromInt != "/" && stringFromInt != " " && outputString[1].ToString() == " " )
                {
                    outputString.Append(stringFromInt);
                    outputString.Remove(0, 2);
                    continue;
                }

                if (i + 1 < inputInts.Length)
                {
                    stringFromInt = ReturnStringFromInt(outputString[0].ToString() + outputString[1].ToString());
                    if (stringFromInt != "/" && stringFromInt != " " && outputString[1].ToString() != " " && outputString[2].ToString() == " ")
                    {
                        outputString.Append(stringFromInt);
                        outputString.Remove(0, 3);
                        continue;
                    }
                }

                if (i + 2 < inputInts.Length)
                {
                    stringFromInt = ReturnStringFromInt(outputString[0].ToString() + outputString[1].ToString() +
                                                        outputString[2].ToString());
                    if (stringFromInt != "/" && stringFromInt != " " && outputString[1].ToString() != " " &&
                        outputString[2].ToString() != " " && outputString[3].ToString() == " ")
                    {
                        outputString.Append(stringFromInt);
                        outputString.Remove(0, 4);
                        continue;
                    }
                }
            }

            return outputString;
        }

        // Перебор таблицы на 100% сходство с оригиналом

        private int ReturnIntFromString(string inputChars)
        {
            int output = 0;

            for (int i = 0; i < napoleonStrings.Length; i++)
            {
                if (inputChars == napoleonStrings[i])
                {
                    output = napoleonInts[i];
                    return output;
                }
            }

            return output;
        }

        private string ReturnStringFromInt(string inputChars)
        {
            string output = "/";

            for (int i = 0; i < napoleonStrings.Length; i++)
            {
                if (inputChars == napoleonInts[i].ToString())
                {
                    output = napoleonStrings[i];
                    return output;
                }
            }

            return output;
        }
    }
    //15 87
}