using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class RoverList : RoverListBase
    {
        // Add any variables you need here
        int check = 0;
        protected Node curry;

        public RoverList ()
        {
            head = null;
        }

        public override int Count 
        {
            get {
                return 0;
            }
        }

        public override void Add(object data)
        {
            if (head == null)
            {
                head = new Node(data);
                current = head;
            }
           else
            {
                current.Next = new Node(data);
                current = current.Next;
            }
        }

        public override void Add(int Position, object data)
        {
            Node newNode = new Node(data);
            curry = head;
            check = 0;
            while (check != Position - 1)
            {
                curry = curry.Next;
                check++;
            }
            newNode.Next = curry.Next;
            curry.Next = newNode;
        }

        public override void Clear()
        {
            head = null;
        }

        public override Node ElementAt(int Position)
        {
            curry = head;
            check = 0;
            while (check != Position)
            {
                curry = curry.Next;
                check++;
            }
            return curry;
        }

        public override void ListNodes()
        {

            
        }

        public override bool RemoveAt(int Position)
        {
            throw new NotImplementedException();
        }
    }
}
