using System.Collections.Generic;
using System;
namespace Assignment4
{
    class MyQueue<T> {

        List<T> list; 
        
        public MyQueue(){
            this.list = new List<T>();
        }
        // add element and returns if it was successful
        public bool offer(T data){
            list.Insert(0,data);
            return true;
        }
        // gets and removes head 
        public T poll(){
            T element = list[list.Count-1];
            list.Remove(element);

            return element;
        }
        // gets but does not remove head
        public T peek(){
            return list[list.Count-1];
        }
        public void listElements(){
            foreach (T item in list)
            {
                
                Console.WriteLine(item);
            }
        }

    }
    
}