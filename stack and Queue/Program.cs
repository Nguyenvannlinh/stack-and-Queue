using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lmao
{
    class lmeo
    {

    }
    // bài 1
    class Node
    {
        public int info;
        public Node pNext;
        public Node(int Info)
        {
            info = Info;
            pNext = null;
        }
    }
    public class liststack
    {
        private Node top;

        public liststack()
        {
            top = null;
        }
        public bool IsEmpty()
        {
            return top == null;
        }
        public void push(int data)
        {
            Node n = new Node(data);
            n.pNext = top;
            top = n;
        }
        public int pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Empty");
                return -1;
            }
            int data = top.info;
            top = top.pNext;
            return data;
        }
        public int peek()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack Empty, Cannot peek");
                return -1;
            }
            return top.info;
        }
    }
    // bài 2
    class StackN 
    {
        private int[] elements;
        private int top;
        private int max_count;
        public StackN(int Max)
        {
            max_count = Max;
            elements = new int[Max];
            top = -1;
        }
        
        public bool IsEmtpy()
        {
            return top == -1;
        }
        public bool fullstack()
        {
            return top == max_count - 1;
        }
        public void push(int data)
        {
            if (fullstack())
            {
                Console.WriteLine("stack full, cannot push");
            }
            else
            {
                elements[++top] = data;
            }
        }
        public int peek()
        {
            if (fullstack())
            {
                Console.WriteLine("stack full, cannot peek");
                return default(int);
            }
            return elements[top];
        }
        public int pop()
        {
            if (fullstack())
            {
                Console.WriteLine("stack full, cannot pop");
                return default(int);
            }
            return elements[top--];
        }
        public int[] n()
        {
            int[]r= new int[top + 1];

            for (int i = 0;i <= top; i++)
            {
                r[i] = elements[i];
            }
            return r;
        } 
    }
   

    class Node1
    {
        public int info;
        public Node pNext;
        public Node1(int Info)
        {
            info = Info;
            pNext = null;
        }
    }
    class listQueue
    {
        private int front;
        private int rear;
    }
    // bài 3
    

    class stacknaodo
    {
        public char[] stackchar;
        public int top;
        public int max_count;
        
        public stacknaodo(int max)
        {
            stackchar = new char[max];
            top = -1;
        }
        public void push(char c)
        {
            if(top == stackchar.Length)
            {
                Console.WriteLine("stack full, cannot push");
            }
            else
            {
                stackchar[++top] = c;
            }
        }
        public string pop()
        {
            if(top == -1)
            {
                Console.WriteLine("stack is Empty, cannot pop");
                return null;
            }   
            else
            {
                return stackchar[top--].ToString();
            }
        }
        public bool IsEmpty()
        {
            return top == -1;
        }
        public void show()
        {
            
        }
    }
    // bài 5
    public class Node<T>
    {
        public T info;
        public Node<T> pNext;
        public Node(T Info)
        {
            info = Info;
            pNext = null;
        }
    }
    class queue5<T>
    {
        Node<T> front;
        Node<T> rear;
        public queue5()
        {
            front = null;
            rear = null;
        }
        public bool IsEmpty()
        {
            return rear == null; 
        }
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            if (IsEmpty())
            {
                front = node;
                rear = node;
            }
            else
            {
                rear.pNext = node;
                rear = node;
            }
        }
        
        public T Dequeue()
        {
            T data = front.info;
            front = front.pNext;
            if (IsEmpty())
            {
                throw new Exception("Queue is Empty");
            }
            else
            {
                if(front == null)
                {
                    rear = null;
                }    
            }
            return data;
        }

        public T peek()
        {
            if(IsEmpty())
            {
                throw new Exception("Queue is Empty");
            }
            else { return front.info; }
        }
        public void show()
        {
            Node<T> node = front;
            if (IsEmpty())
            {
                throw new Exception("Queue is Empty");
            }
            else
            {
                while (node != null)
                {
                    Console.Write($"{node.info} ");
                    node = node.pNext;
                }
                Console.WriteLine();
            }
        }
        public void Sort()
        {
            Node<T> node = front;
            if (IsEmpty())
            {
                throw new Exception("Queue is Empty");
            }
            int count = 0;
            while (node != null)
            {
                count++;
                node = node.pNext;
            }
            T[] array = new T[count];
            node = front;
            for (int i = 0; i < count; i++)
            {
                array[i] = node.info;
                node = node.pNext;
            }
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (Comparer<T>.Default.Compare(array[j], array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            front = null;
            rear = null;
            foreach (T item in array)
            {
                Enqueue(item);
            }
        }
        public void showpart7()
        {
            Node <T> node = front;
            if (IsEmpty()) { throw new Exception("Queue is Empty"); }
            else
            {
                while(node != null)
                {
                    Console.Write($"{node.info}  ");
                    Thread.Sleep(100);
                    node = node.pNext;
                }

            }
        }


    }

    // bài 4
    class queue4
    {
        DataType[] que; 
        int front , rear, max;
        public queue4(int mac)
        {
            max = mac;
            que = new DataType[max];
            front = 0;
            rear = -1;
        }
        public bool IsEmpty()
        {
            return rear == -1;
        }
        public void Equeue(DataType data)
        {
            if (rear == max - 1)
            {
                rear = -1;
            }
            que[++rear] = data;

        }
        public DataType Dequeue ()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            else
            {
                DataType data = que[front];
                front++;
                if (front > rear)   
                {
                    front = 0;
                    rear = -1;
                }   
                return data;
            }
        }
        public DataType peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            else { return que[front]; }
        }
    }
    
    public class progame
    {
        static void Part1()
        {
            
            liststack l = new liststack();
            Console.Write("nhập độ lớn stack: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Stack {i + 1} số nguyên n: ");
                int m = int.Parse(Console.ReadLine());
                l.push(m);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(l.pop());
            }
        }
        static void Part2()
        {
            
            StackN n = new StackN(50);
            Console.Write("nhập cơ số 10: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("nhập cơ số a: ");
            int b = int.Parse(Console.ReadLine());
            int x = 0;
            if (c == 0)
            {
                n.push(0);
            }
            while (c > 0)
            {
                x = c % b;
                n.push((int)x);
                c /= b;
            }
            int[] elements = n.n();
            Console.Write($"Số nguyên dương trong hệ {b} là: ");
            for (int i = elements.Length - 1; i >= 0; i--)
            {
                Console.Write(elements[i]);
            }
            Console.WriteLine();
        }
        public static bool Part3(string n)
        {
            stacknaodo s = new stacknaodo(n.Length);
            foreach(char i in n)
            {
                if(i == '(')
                {
                    s.push(i);
                }
                else if(i == ')')
                {
                    if(s.IsEmpty())
                    {
                        return false;
                    }
                    else
                    {
                        s.pop();
                    }
                }
                else { return false; }
            }
            //Console.WriteLine("stack sau khi thêm");
            //foreach(char i in n)
            //{
            //    Console.Write($"{i}");
            //}
            Console.WriteLine();
            return s.IsEmpty();
        }
        // bài 6
        public static void Part6()
        {
            queue5<int> que = new queue5<int>();
            while (true)
            {
                Console.Write("nhập C là kết thúc danh sách: ");
                if (Console.ReadLine() == "c") { break; }
                Console.Write("nhập số :");
                que.Enqueue(int.Parse(Console.ReadLine()));
            }

            que.Sort();
            que.show();
        }
        
        public static void Part7()
        {
            queue5<string> que = new queue5<string>();
            while (true)
            {
                Console.Write("nhập C là kết thúc danh sách: ");
                if (Console.ReadLine() == "c") { break; }
                Console.Write("nhập chữ :");
                que.Enqueue(Console.ReadLine());    
            }
            que.showpart7();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Part7();
            //string input = "hello world";
            //const string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //string output = "";
            //int index = 0;
            //while (input != output)
            //{
            //    if (input[index] == ' ')
            //    {
            //        output += " ";
            //        index++;
            //        continue;
            //    }

            //    Random random = new Random();
            //    char randomAlphabet = alphabet[random.Next(alphabet.Length)];

            //    if (input[index] == randomAlphabet)
            //    {
            //        output += randomAlphabet;
            //        index++;
            //        Console.WriteLine(output);
            //    }
            //    else
            //    {
            //        Console.WriteLine(output + randomAlphabet);
            //    }

            //    Thread.Sleep(1);
            //}
        }
    }

}


