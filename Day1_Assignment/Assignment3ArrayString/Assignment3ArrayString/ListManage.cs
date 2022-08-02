using System;
namespace Assignment3ArrayString
{
    public class ListManage
    {
        public static void ListM(List<string> lst)
        {
            while (1 == 1) {
                Console.WriteLine("Enter command(+item, -item, or-- to clear)):");
                string opt = Console.ReadLine();
                string mark = Convert.ToString(opt[0]);
                string item = opt.Substring(1);
                string add = Convert.ToString("+");
                string minus = Convert.ToString("-");


                if (mark.Equals(add))
                {
                    lst.Add(item);

                }
                else if (mark.Equals(minus))
                {
                    if (item.Equals(minus))
                    {
                        lst.Clear();
                        break;
                    }
                    else if (lst.Contains(item))
                    {
                        lst.Remove(item);
                    }
                    else
                    {
                        Console.WriteLine("Please retype your operation.");
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("Please retype your operation.");
                    continue;
                }

                //Console.WriteLine(lst);
            }
        }
    }
}

