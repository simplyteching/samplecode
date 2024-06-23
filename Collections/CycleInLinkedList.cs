using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public static class CycleInLinkedList
    {
        private class MyLinkedList<T>
        {
            public MyLinkedList<T> node { get; set; }
            public T value { get; set; }
            public MyLinkedList(T value)
            {
                this.value = value;
            }
            public MyLinkedList() { }
        }
        public static void Display()
        {
            MyLinkedList<int> node1 = new MyLinkedList<int>(1);
            MyLinkedList<int> node2 = new MyLinkedList<int>(2);
            MyLinkedList<int> node3 = new MyLinkedList<int>(3);
            MyLinkedList<int> node4 = new MyLinkedList<int>(4);
            MyLinkedList<int> node5 = new MyLinkedList<int>(5);
            MyLinkedList<int> node6 = new MyLinkedList<int>(6);
            MyLinkedList<int> node7 = new MyLinkedList<int>(7);


            MyLinkedList<int> listWithoutCycle = new MyLinkedList<int>(0);

            listWithoutCycle.node = node1;
            node1.node = node2;
            node2.node = node3;
            node3.node = node4;
            node4.node = node5;
            node5.node = node6;
            node6.node = node7;

            Console.WriteLine("List without Cycle:");
            MyLinkedList<int> temp = listWithoutCycle;
            while(temp != null)
            {
                Console.WriteLine(temp.value);
                temp = temp.node;
            }

            Console.WriteLine(IsLinkedListHaveCycle(listWithoutCycle));
            MyLinkedList<int> listWithCycle = new MyLinkedList<int>(0);
            listWithCycle.node = node1;
            node1.node = node2;
            node2.node = node3;
            node3.node = node4;
            node4.node = node5;
            node5.node = node2; //Creates cycle
            node6.node = node7;

            Console.WriteLine("List with Cycle:");
            temp = listWithCycle;
            int cycle = 1;
            while (temp != null)
            {
                Console.WriteLine(temp.value);
                temp = temp.node;
                cycle++;
                if(cycle>15)
                {
                    break;
                }
            }
            Console.WriteLine(IsLinkedListHaveCycle(listWithCycle));
        }

        private static bool IsLinkedListHaveCycle<T>(MyLinkedList<T> list)
        {
            if (list == null || list.node == null)
                return false;
            MyLinkedList<T> runner = list.node.node;
            MyLinkedList<T> walker = list.node;

            while(runner != null && walker != null)
            {
                if (runner.node == null)
                    return false;
                if (runner == walker)
                    return true;
                runner = runner.node.node;
                walker = walker.node;
            }
            return false;
        }
    }
}
