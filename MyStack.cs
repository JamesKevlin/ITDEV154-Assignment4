using System.Collections.Generic;
using System.Collections;
using System;
namespace Assignment4
{
    class MyStack<T>{
        
        List<T> list;
        public MyStack(){
            this.list = new List<T>();
        }

        public bool push(T data){
            list.Insert(0,data);
            return true;
        }
        public T pop(){
            T element = list[0];
            list.RemoveAt(0);
            return element;
        }
        public void listElements(){
            foreach (T item in list)
            {
                
                Console.WriteLine(item);
            }
        }

    }
    
}