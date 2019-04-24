using System;
using System.Collections.Generic;

namespace PILASYCOLAS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COLAS");
            Queue<int> Colas= new Queue<int>();
            Colas.Enqueue(1);
            Colas.Enqueue(2);
            Colas.Enqueue(3);
            Colas.Enqueue(4);
            Colas.Enqueue(5);
            Colas.Enqueue(6);
            Colas.Enqueue(7);
            Colas.Enqueue(8);
            Colas.Enqueue(9);
            Colas.Enqueue(10);
            while(Colas.Count> 0)
            {
                Console.WriteLine(Colas.Dequeue());
            }
            Console.WriteLine(" ");
            Console.WriteLine("PILAS");
            Stack<int> Pilas = new Stack<int>();
            Pilas.Push(1);
            Pilas.Push(2);
            Pilas.Push(3);
            Pilas.Push(4);
            Pilas.Push(5);
            Pilas.Push(6);
            Pilas.Push(7);
            Pilas.Push(8);
            Pilas.Push(9);
            Pilas.Push(10);
            while(Pilas.Count>0)
            {
                Console.WriteLine(Pilas.Pop());
            }
            Console.WriteLine(" ");
            Console.WriteLine("COLAS EN STRING");
            Queue<string> Colasletras = new Queue<string>();
            Colasletras.Enqueue("NIHAO");
            Colasletras.Enqueue("WOAINI");
            Colasletras.Enqueue("XIEXIE");
            Colasletras.Enqueue("XIAOYIU");
            Colasletras.Enqueue("ZAITIEN");
            Colasletras.Enqueue("MEIGUANXI");
            Colasletras.Enqueue("WO");
            Colasletras.Enqueue("NI");
            Colasletras.Enqueue("TA");
            Colasletras.Enqueue("SARANGHE");
            Colasletras.Enqueue("CHA");
            while(Colasletras.Count>0)
            {
                Console.WriteLine(Colasletras.Dequeue());
            }
            Console.WriteLine(" ");
            Console.WriteLine("PILAS EN STRING");
            Console.WriteLine(" ");
            Stack<string> Pilasletras = new Stack<string>();
            Pilasletras.Push("JULIETA");
            Pilasletras.Push("FANY");
            Pilasletras.Push("AIXA");
            Pilasletras.Push("SUSAN");
            Pilasletras.Push("YAMILA");
            Pilasletras.Push("SOFIA");
            Pilasletras.Push("GRETA");
            Pilasletras.Push("MICAELA");
            Pilasletras.Push("MELINA");
            Pilasletras.Push("KIARA");
            while (Pilasletras.Count > 0)
            {
                Console.WriteLine(Pilasletras.Pop());
            }
        }
    }
}
