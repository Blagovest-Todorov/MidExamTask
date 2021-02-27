using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> particles = Console.ReadLine()
                .Split('|')
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Done")
                {
                    // ToDo 
                    Console.Write("You crafted ");

                    for (int i = 0; i < particles.Count; i++)
                    {
                        Console.Write(particles[i]);
                    }

                    Console.WriteLine("!");
                    
                    break;
                }

                string[] partsData = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string comand = partsData[0];

                if (comand == "Move")
                {
                    string direction = partsData[1];
                    int idx = int.Parse(partsData[2]);

                    if (direction == "Left")
                    {
                        if (idx >= 0 && idx < particles.Count)
                        {
                            if (idx == 0)
                            {
                                // Do Nothing
                                continue;
                            }
                            else // idx != 0 
                            {
                                string currElem = particles[idx];
                                particles[idx] = particles[idx - 1];
                                particles[idx - 1] = currElem;
                            }
                        }
                    }
                    else 
                    {
                        if ( idx >= 0 && idx < particles.Count - 1)
                        {
                            string currElem = particles[idx];
                            particles[idx] = particles[idx + 1];
                            particles[idx + 1] = currElem;
                        }
                        else
                        {
                            //Do Nothing
                            continue;
                        }

                    }                   
                }

                if (comand == "Check")
                {
                    string numsAre = partsData[1]; 
                   
                    if (numsAre == "Even")
                    {     
                        for (int i = 0; i < particles.Count; i += 2)
                        {
                            Console.Write(particles[i] + " ");                           
                        }
                      
                        Console.WriteLine();
                    }
                    else //  (numsAre == "Odd")
                    {
                        for (int i = 1; i < particles.Count; i += 2)
                        {
                            Console.Write(particles[i] + " ");
                        }

                        Console.WriteLine();
                    } 
                }
            }
        }
    }
}
