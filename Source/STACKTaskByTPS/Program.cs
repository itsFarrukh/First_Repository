using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACKTaskByTPS
{


    class Program
    {
        STACK ss = new STACK(10);
        char ans;

       
       
    }
    public class STACK 
    {
      
        public int Top;
        int[] StackArr;
        
        public STACK(int SizeOfStack) 
        {
            Top = -1;
            StackArr = new int[SizeOfStack];
        }
        public bool isEmpty() {

            if (Top == -1)
                return true;
            else
                return false;
        }
        public bool isFull() {
            if(Top>=StackArr.Length-1)
            return true;
            else
            return false;
        }
        public void push(int val)
        {
            Top++;
            StackArr[Top] = val;
        }
        public void pop() {
            int item = StackArr[Top];
            Top--;

        }
        public void dis()
        {
            if(!isEmpty()){
            for (int i = Top; i <0; i--)
			{
			 Console.WriteLine(StackArr[i]);
			}
            
            }
            else
                Console.WriteLine("Stack is empty");
        }
    }
}
