using System;
using System.Collections.Generic;
namespace Assignment4
{
    class Program
    {

        static MyStack<string> mystack = new MyStack<string>();
        static MyQueue<string> myqueue = new MyQueue<string>();
        static void Main(string[] args)
        {

            int answer = -1;

            do{

                Console.WriteLine(  "Welcome to DataStructures 101\n" +
                                    "1.Use Stack\n" +
                                    "2.Use Queue\n" +
                                    "3.Quit\n"
                                    );
                int.TryParse(Console.ReadLine(), out answer);

                if(answer == 1){
                    useStack();
                } else if(answer == 2){
                    useQueue();
                }

            }while(answer != 3);                
        }

        public static void useStack(){
            int answer = -1;
            do{
                Console.WriteLine(  "Welcome to Stacks 101\n" +
                                    "1.Add element\n" +
                                    "2.Remove element\n" +
                                    "3.List elements\n" + 
                                    "4.Quit\n"
                                    );
                int.TryParse(Console.ReadLine(),out answer);
                switch (answer)
                {
                    case 1: 
                        addStack();
                        break;
                    case 2: 
                        removeStack();
                        break;
                    case 3: 
                        listStack();
                        break;
                    default:
                        break;
                }
            }while(answer != 4);
        }

        static void addStack(){
            Console.WriteLine("Please enter a word");
            mystack.push(Console.ReadLine());
        }
        static void removeStack(){
            Console.WriteLine("Your removed " + mystack.pop());
            
        }
        static void listStack(){
            mystack.listElements();
        }
        public static void useQueue(){
            int answer = -1;
            do{
                Console.WriteLine(  "Welcome to Queues 101\n" +
                                    "1.Add element\n" +
                                    "2.Remove element\n" +
                                    "3.List elements\n" + 
                                    "4.Quit\n"
                                    );
                int.TryParse(Console.ReadLine(),out answer);
                switch (answer)
                {
                    case 1: 
                        addQueue();
                        break;
                    case 2: 
                        removeQueue();
                        break;
                    case 3: 
                        listQueue();
                        break;
                    default:
                        break;
                }
            }while(answer != 4);
        }

        static void addQueue(){
            Console.WriteLine("Please enter a word");
            myqueue.offer(Console.ReadLine());
        }
        static void removeQueue(){
            Console.WriteLine("Your removed " + myqueue.poll());
            
        }
        static void listQueue(){
            myqueue.listElements();
        }
        
    }
}
