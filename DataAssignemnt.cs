using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Names:   Tanner Lenon, Dallin Faulkner, Chase Kunz, Brigham Duncan
 * Class:   IS402
 * Date:    September 26, 2016
 * Description: This program creats a stack, query, and dictionary and allows the user to manipulate the data that is entered
 * by either adding an item, deleting it, or displaying all items in each respective data structure.  The application is based around a
 * simple menu with selections between one and seven after selection one of four options.
 */

namespace Data_Structure_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0; // Used in Option 3 (Dictionary), Selection 1

            string input;
            bool inputCheck = false;
            string stackInput;
            bool stackInputCheck = false;
            string queueInput;
            bool queueInputCheck = false;
            string dictionaryInput;
            bool dictionaryInputCheck = false;

            bool inputRepeat = false;
            bool stackInputRepeat = false;
            bool queueInputRepeat = false;
            bool dictionaryInputRepeat = false;

            Stack<string> stack = new Stack<string>(); //creates new stack
            Queue<string> queue = new Queue<string>(); //creates new queue
            Dictionary<string, int> dictionary = new Dictionary<string, int>(); //creates new dictionary

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch(); // Initiates stopwatch

            do
            {

                Console.WriteLine("1. Stack");//--Option 1
                Console.WriteLine("2. Queue");//--Option 2
                Console.WriteLine("3. Dictionary");//--Option 3
                Console.WriteLine("4. Exit\n");//--Option 4
                Console.Write("Please  enter a number: ");

                do
                {

                    inputCheck = false;
                    input = Console.ReadLine();

                    if (input == "1")                    // Stack
                    {

                        do
                        {
                            stackInputRepeat = false;

                            Console.WriteLine("\n1. Add one item to Stack");//--1/1
                            Console.WriteLine("2. Add a huge list of items to Stack");//--1/2
                            Console.WriteLine("3. Display Stack");//--1/3
                            Console.WriteLine("4. Delete from Stack");//--1/4
                            Console.WriteLine("5. Clear Stack");//--1/5
                            Console.WriteLine("6. Search Stack");//--1/6
                            Console.WriteLine("7. Return to Main Menu");//--1/7
                            Console.Write("\nPlease enter a number: ");

                            do
                            {
                                stackInputCheck = false;
                                stackInput = Console.ReadLine();

                                if (stackInput == "1")//---------------Add one item to Stack-------1/1---------
                                {
                                    Console.Write("Input a string to add to the Stack: ");
                                    stack.Push(Console.ReadLine());
                                    Console.Write("Your input was sucessfully added to the stack.\n");
                                }
                                else if (stackInput == "2")//----Add Huge List of Items to Stack---1/2---------
                                {
                                    stack.Clear();

                                    for (int iCount = 0; iCount < 2000; iCount++)
                                    {
                                        stack.Push("New Entry " + (iCount + 1));
                                    }
                                }
                                else if (stackInput == "3")//---------Display Stack----------------1/3---------
                                {
                                    if (stack.Count == 0)
                                    {
                                        Console.WriteLine("There are no strings in the stack");
                                    }
                                    else
                                    {
                                        int iCount = 0;
                                        foreach (string element in stack)
                                        {
                                            Console.WriteLine(stack.ElementAt(iCount));
                                            iCount++;
                                        }
                                    }
                                }
                                else if (stackInput == "4")//---------Delete from Stack------------1/4---------
                                {
                                    if (stack.Count == 0)
                                    {
                                        Console.WriteLine("There are no strings in the stack");
                                    }
                                    else
                                    {
                                        Stack<string> temp = new Stack<string>(); //creates a temporary stack

                                        bool contains = false;

                                        Console.Write("\nInput a string to delete from the Stack: ");
                                        string stackDelete = Console.ReadLine();

                                        for (int iCount = 0; iCount < stack.Count; iCount++)
                                        {
                                            if (stackDelete == stack.ElementAt(iCount))
                                            {
                                                contains = true;
                                            }
                                        }
                                        if (contains == false)
                                        {
                                            Console.Write("The Stack doesn't contain this string\n");
                                        }
                                        else
                                        {
                                            while (!(stack.Peek() == stackDelete))
                                            {
                                                temp.Push(stack.Pop()); //pops the item to the temporary stack
                                            }

                                            stack.Pop();

                                            int tCount = temp.Count;
                                            for (int iCount = 0; iCount < tCount; iCount++)
                                            {
                                                stack.Push(temp.Pop()); //pops the item back onto the original stack
                                            }
                                        }

                                    }
                                }
                                else if (stackInput == "5")//----------Clear Stack-----------------1/5---------
                                {
                                    stack.Clear();
                                }
                                else if (stackInput == "6")//----------Search Stack----------------1/6---------
                                {
                                    if (stack.Count == 0)
                                    {
                                        Console.WriteLine("There are no strings in the stack");
                                    }
                                    else
                                    {
                                        Console.Write("Please enter item to search for: ");
                                        string findItem = Console.ReadLine();
                                        bool itemFound = false;

                                        sw.Start(); //starts the stopwatch after searching for the item

                                        for (int iCount = 0; iCount < stack.Count; iCount++)
                                        {
                                            if (findItem == stack.ElementAt(iCount))
                                            {
                                                itemFound = true;
                                                sw.Stop(); //stopwatch ends
                                            }
                                        }

                                        if (itemFound == true)
                                        {
                                            Console.WriteLine("\nYour iteam was found");
                                            Console.Write("The search took: " + sw.Elapsed + "\n");
                                        }
                                        else if (itemFound == false)
                                        {
                                            Console.WriteLine("\nYour iteam was not found");
                                            Console.Write("The search took: " + sw.Elapsed + "\n");
                                        }

                                        sw.Reset();
                                    }
                                }
                                else if (stackInput == "7")//-------Return to Main Menu------------1/7---------
                                {
                                    stackInputRepeat = true;
                                }
                                else
                                {
                                    Console.WriteLine("\nPlease enter a number between 1 and 7");
                                    stackInputCheck = true;
                                }

                            } while (stackInputCheck == true);

                        } while (stackInputRepeat == false);
                    }


                    else if (input == "2")  //Option 2 - Queue
                    {

                        do
                        {
                            queueInputRepeat = false;

                            Console.WriteLine("\n1. Add one item to Queue");//--2/1
                            Console.WriteLine("2. Add Huge List of Items to Queue");//--2/2
                            Console.WriteLine("3. Display Queue");//--2/3
                            Console.WriteLine("4. Delete from Queue");//--2/4
                            Console.WriteLine("5. Clear Queue");//--2/5
                            Console.WriteLine("6. Search Queue");//--2/6
                            Console.WriteLine("7. Return to Main Menu");//--2/7
                            Console.Write("\nPlease enter a number: ");

                            do
                            {
                                queueInputCheck = false;
                                queueInput = Console.ReadLine();

                                if (queueInput == "1")//---------------Add one item to Queue-------2/1---------
                                {
                                    Console.Write("Input a string to add to the Queue: ");
                                    queue.Enqueue(Console.ReadLine());
                                    Console.Write("Your input was sucessfully added to the queue.\n");
                                }
                                else if (queueInput == "2")//---Add Huge List of Items to Queue----2/2---------
                                {
                                    queue.Clear();

                                    for (int iCount = 0; iCount < 2000; iCount++)
                                    {
                                        queue.Enqueue("New Entry " + (iCount + 1));
                                    }
                                }
                                else if (queueInput == "3")//-------Display Queue------------------2/3---------
                                {
                                    if (queue.Count == 0)
                                    {
                                        Console.WriteLine("There are no strings in the queue");
                                    }
                                    else
                                    {
                                        foreach (string element in queue)
                                        {
                                            Console.WriteLine(element);
                                        }
                                    }
                                }
                                else if (queueInput == "4")//------Delete from Queue---------------2/4---------
                                {
                                    if (queue.Count == 0)
                                    {
                                        Console.WriteLine("There are no strings in the queue");
                                    }
                                    else
                                    {
                                        Queue<string> temp = new Queue<string>(); //creates a temporary queue to store information

                                        bool contains = false;

                                        Console.Write("Input a string to delete from the Queue: ");
                                        string queueDelete = Console.ReadLine();

                                        for (int iCount = 0; iCount < queue.Count; iCount++)
                                        {
                                            if (queueDelete == queue.ElementAt(iCount))
                                            {
                                                contains = true;
                                            }
                                        }
                                        if (contains == false)
                                        {
                                            Console.Write("The Queue doesn't contain this string\n");
                                        }
                                        else
                                        {
                                            while (!(queue.Peek() == queueDelete))
                                            {
                                                temp.Enqueue(queue.Dequeue());
                                            }

                                            queue.Dequeue();

                                            int qCount = queue.Count;
                                            for (int iCount = 0; iCount < qCount; iCount++)
                                            {
                                                temp.Enqueue(queue.Dequeue());
                                            }

                                            int tCount = temp.Count;
                                            for (int iCount = 0; iCount < tCount; iCount++)
                                            {
                                                queue.Enqueue(temp.Dequeue());
                                            }
                                        }
                                    }

                                }
                                else if (queueInput == "5")//--------Clear Queue-------------------2/5---------
                                {
                                    queue.Clear();
                                }
                                else if (queueInput == "6")//--------Search Queue------------------2/6---------
                                {
                                    if (queue.Count == 0)
                                    {
                                        Console.WriteLine("There are no strings in the queue");
                                    }
                                    else
                                    {
                                        Console.Write("Please enter item to search for: ");
                                        string findItem = Console.ReadLine();
                                        bool itemFound = false;

                                        sw.Start(); //starts stopwatch when searching

                                        for (int iCount = 0; iCount < queue.Count; iCount++)
                                        {
                                            if (findItem == queue.ElementAt(iCount))
                                            {
                                                itemFound = true;
                                                sw.Stop(); //stopwatch ends
                                            }
                                        }

                                        if (itemFound == true)
                                        {
                                            Console.WriteLine("\nYour iteam was found");
                                            Console.Write("The search took: " + sw.Elapsed + "\n");
                                        }
                                        else if (itemFound == false)
                                        {
                                            Console.WriteLine("\nYour iteam was not found");
                                            Console.Write("The search took: " + sw.Elapsed + "\n");
                                        }

                                        sw.Reset(); //resets the stopwatch
                                    }
                                }
                                else if (queueInput == "7")//------Return to Main Menu-----------2/7---------
                                {
                                    queueInputRepeat = true;
                                }
                                else
                                {
                                    Console.WriteLine("\nPlease enter a number between 1 and 7");
                                    queueInputCheck = true;
                                }

                            } while (queueInputCheck == true);

                        } while (queueInputRepeat == false);
                    }

                    else if (input == "3") //Option 3, Dictionary
                    {

                        do
                        {
                            dictionaryInputRepeat = false;

                            Console.WriteLine("\n1. Add one item to Dictionary");//--3/1
                            Console.WriteLine("2. Add Huge List of Items to Dictionary");//--3/2
                            Console.WriteLine("3. Display Dictionary");//--3/3
                            Console.WriteLine("4. Delete from Dictionary ");//--3/4
                            Console.WriteLine("5. Clear Dictionary");//--3/5
                            Console.WriteLine("6. Search Dictionary");//--3/6
                            Console.WriteLine("7. Return to Main Menu");//--3/7
                            Console.Write("\nPlease enter a number: ");

                            do
                            {
                                dictionaryInputCheck = false;
                                dictionaryInput = Console.ReadLine();

                                if (dictionaryInput == "1")//-------Add one item to Dictionary----------3/1---------
                                {
                                    value++;
                                    Console.Write("Input a string to add to the Dictionary: ");
                                    string dictionaryAdd = Console.ReadLine();
                                    Console.Write("Your input was sucessfully added to the dictionary.\n");

                                    if (dictionary.ContainsKey(dictionaryAdd))
                                    {
                                        Console.WriteLine("This name is already included in your the dictionary");
                                    }
                                    else
                                    {
                                        dictionary.Add(dictionaryAdd, value);
                                    }
                                }
                                else if (dictionaryInput == "2")//--Add Huge List of Items to Dictionary----3/2-----
                                {
                                    value = 0;
                                    dictionary.Clear();

                                    for (int iCount = 0; iCount < 2000; iCount++)
                                    {
                                        dictionary.Add("New Entry " + (iCount + 1), (iCount + 1));
                                    }

                                    value = 2000;
                                }
                                else if (dictionaryInput == "3")//--------Display Dictionary-----------3/3---------
                                {
                                    if (dictionary.Count == 0)
                                    {
                                        Console.WriteLine("There are no strings in the dictionary");
                                    }
                                    else
                                    {
                                        foreach (KeyValuePair<string, int> KV in dictionary)
                                        {
                                            Console.Write(KV.Key + "\t");
                                            Console.WriteLine(KV.Value);
                                        }
                                    }
                                }
                                else if (dictionaryInput == "4")//-------Delete from Dictionary--------3/4---------
                                {
                                    if (dictionary.Count == 0)
                                    {
                                        Console.WriteLine("There are no strings in the dictionary");
                                    }
                                    else
                                    {
                                        Console.Write("Input a string to delete from the Dictionary: ");
                                        string dictionaryDelete = Console.ReadLine();

                                        if (!dictionary.ContainsKey(dictionaryDelete))
                                        {
                                            Console.WriteLine("The Dictionary doesn't contain this string\n");
                                        }
                                        else
                                        {
                                            for (int iCount = 0; iCount < dictionary.Count; iCount++)
                                            {
                                                if (dictionary.ContainsKey(dictionaryDelete))
                                                {
                                                    dictionary.Remove(dictionaryDelete); //deletes item from the dictionary
                                                }
                                            }
                                        }
                                    }
                                }
                                else if (dictionaryInput == "5")//----------Clear Dictionary------------3/5---------
                                {
                                    value = 0;
                                    dictionary.Clear();
                                }
                                else if (dictionaryInput == "6")//----------Search Dictionary-----------3/6---------
                                {
                                    if (dictionary.Count == 0)
                                    {
                                        Console.WriteLine("There are no strings in the dictionary");
                                    }
                                    else
                                    {
                                        Console.Write("Please enter item to search for: ");
                                        string findItem = Console.ReadLine();
                                        bool itemFound = false;

                                        sw.Start(); //starts stopwatch when searching

                                        if (dictionary.ContainsKey(findItem))
                                        {
                                            itemFound = true;
                                            sw.Stop(); //ends stopwatch
                                        }

                                        if (itemFound == true)
                                        {
                                            Console.WriteLine("\nYour item was found");
                                            Console.Write("The search took: " + sw.Elapsed + "\n");
                                        }
                                        else if (itemFound == false)
                                        {
                                            Console.WriteLine("\nYour item was not found");
                                            Console.Write("The search took: " + sw.Elapsed + "\n");
                                        }

                                        sw.Reset(); //resets stopwatch

                                    }
                                }
                                else if (dictionaryInput == "7")//---------Return to Main Menu----------3/7---------
                                {
                                    dictionaryInputRepeat = true;
                                }
                                else
                                {
                                    Console.WriteLine("\nPlease enter a number between 1 and 7");
                                    dictionaryInputCheck = true;
                                }

                            } while (dictionaryInputCheck == true);

                        } while (dictionaryInputRepeat == false);

                    }

                    else if (input == "4")  // Option 4 EXIT MENU
                    {
                        inputRepeat = true;
                    }

                    else
                    {
                        Console.WriteLine("\nPlease enter a 1, 2, 3, or 4");
                        inputCheck = true;
                    }

                } while (inputCheck == true);

                Console.WriteLine("");

            } while (inputRepeat == false);
        }
    }
}
