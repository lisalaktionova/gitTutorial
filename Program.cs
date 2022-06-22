using System;

namespace Program
{
    class Program1
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int[] answer = new int[t];

            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string s = Console.ReadLine();
                string[] array=s.Split(' ');
                int[]mas=array.Select(int.Parse).ToArray();
                List<int> l = new List<int>();
                

                for(int j=0; j<n; j++)
                {
                    l.Add(mas[j]);
                }
                int count = 1;
                int index_yes = 0;
                int index_no = 0;
                for (int j=0; j<n; j++)
                {
                    for(int k=0; k<n; k++)
                    {
                        if (l[j] == l[k])
                        {
                            index_yes = k;
                        }
                        if (l[j] != l[k])
                        {
                            index_no = k;
                        }
                    }
                    for(int k=0; k<n-1; k++)
                    {
                        if (l[k] != l[k + 1])
                        {
                            count++;
                        }
                    }
                    if (l.Count()!=count)
                    {
                        l.Remove(mas[index_yes]);
                        l.Remove(mas[index_no]);
                        n = n - 2;
                    }
                    count = 1;
                    index_yes = 0;
                    index_no = 0;
                }
                answer[i] = l.Count();
            }

            for (int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }
    }
}
