using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Weight_for_weight
{
    public class MySolution
    {
        public string orderWeight(string strng)
        {
            Regex regex = new Regex(@"^[0-9]+$");

            string[] result = new string[] { "" };

            //vérifier si c'est vide
            if (String.IsNullOrEmpty(strng))
            {
                return "";
            }
            else
            {

                result = strng.Split(' ');
                Array.Sort(result);

                //Vérifier que c'est des nombres
                foreach (var item in result)
                {
                    if (!regex.IsMatch(item))
                    {
                        return "";
                    }
                }
                if (result.Length == 1)
                {
                    return strng;
                }

                else
                {
                    List<long> listSum = new List<long>();

                    //pour calculer la somme de chq nombre du tableau 
                    long sum = 0, number, temp;

                    for (int i = 0; i < result.Length; i++)
                    {
                        number = long.Parse(result[i]);
                        sum = 0;
                        temp = 0;
                        while (number != 0)
                        {
                            temp = number % 10;
                            sum += temp;
                            number /= 10;
                        }
                        //ajouter la somme de chaque nombre dans la liste
                        listSum.Add(sum);
                    }

                    //Pour comparer les 2 tableaux
                    long temp2;
                    //si juste un élément

                    for (int i = 0; i < listSum.Count; i++)
                    {
                        for (int j = 1; j <= listSum.Count - 1; j++)
                        {
                            if (listSum[j] < listSum[j - 1])
                            {
                                temp2 = long.Parse(result[j]);
                                temp = listSum[j];
                                result[j] = result[j - 1];
                                listSum[j] = listSum[j - 1];
                                result[j - 1] = temp2.ToString();
                                listSum[j - 1] = temp;
                            }
                        }
                    }



                    //Pour afficher la liste en string
                    string response = "";

                    for (int i = 0; i < result.Length; i++)
                    {
                        if (i != result.Length - 1)
                        {
                            response += result[i].ToString() + " ";

                        }
                        else
                        {
                            response += result[i].ToString();
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
}

