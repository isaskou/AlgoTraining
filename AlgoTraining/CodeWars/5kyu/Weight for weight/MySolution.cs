using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weight_for_weight
{
    public class MySolution
    {
        public string orderWeight(string strng)
        {
            string[] result = new string[] { "" };

            if (String.IsNullOrEmpty(strng))
            {
                return "";
            }
            

            else
            {
                result = strng.Split(' ');
                Array.Sort(result);

                int[] intArray = Array.ConvertAll(result, x => int.Parse(x));

                List<int> listSum = new List<int>();

                //pour calculer la somme de chq nombre du tableau 

                int sum = 0, number, temp;

                for (int i = 0; i < intArray.Length; i++)
                {
                    number = intArray[i];
                    sum = 0;
                    temp = 0;
                    while (number != 0)
                    {
                        temp = number % 10;
                        sum += temp;
                        number /= 10;
                    }

                    listSum.Add(sum);
                }

                //Pour comparer les 2 tableaux

                int temp2;

                for (int i = 0; i < listSum.Count; i++)
                {
                    for (int j = 1; j <= listSum.Count - 1; j++)
                    {
                        if (listSum[j] < listSum[j - 1])
                        {
                            temp2 = intArray[j];
                            temp = listSum[j];
                            intArray[j] = intArray[j - 1];
                            listSum[j] = listSum[j - 1];
                            intArray[j - 1] = temp2;
                            listSum[j - 1] = temp;
                        }
                    }
                }



                //Pour afficher la liste en string
                string response = "";

                for (int i = 0; i < intArray.Length; i++)
                {
                    if (i != intArray.Length - 1)
                    {
                        response += intArray[i].ToString() + " ";

                    }
                    else
                    {
                        response += intArray[i].ToString();
                    }


                }
                //foreach (var item in intArray)
                //{
                //    response += item.ToString()+" ";
                //}

                return response;
            }




        }





    }
}

