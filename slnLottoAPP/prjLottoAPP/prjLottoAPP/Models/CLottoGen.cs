using System;
using System.Collections.Generic;
using System.Text;

namespace prjLottoAPP.Models
{
    public class CLottoGen
    {
        public string GetLotto()
        {    
            //while (count < 6)
            //{
            //    int temp = rng.Next(1, 50);

            //    bool isSelected = false;

            //    for(int i = 0; i < numbers.Length; i++)
            //    {
            //        if (temp == numbers[i])
            //        {
            //            isSelected = true;
            //            break;
            //        }
            //    }
            //    if (!isSelected)
            //    {
            //        numbers[count] = temp;

            //        count++;
            //    }      
            //}

            List<int> ball = new List<int>();

            for(int i = 1; i <= 49; i++)
            {
                ball.Add(i);
            }

            
            
            int[] numbers = new int[6];

            int count = 0;

            while (count < 6)
            {
                Random rng = new Random(Guid.NewGuid().GetHashCode());

                int temp = rng.Next(1, 50);

                if (ball.Contains(temp))
                {
                    numbers[count] = temp;

                    ball.Remove(temp);

                    count++;
                }
                else
                {
                    continue;
                }
            }


            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length-1; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        int tmp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = tmp;
                    }
                }
            }

            string s = string.Empty;

            foreach (int item in numbers)
            {
                s += item.ToString() + " ";
            }

            return s;
        }
    }
}
