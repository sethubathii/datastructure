using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructure
{
    class customlinked
    {
        public node head;
        ///<summary>
        ///UC 1 insert elements at last
        ///</summary>
        ///<param name="new_data"></param>
        public void InsertLast(int new_data)
        {
            node new_node = new node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                node lastnode = GetLastnode();
                
                
                lastnode.next = new_node;
            }
            Console.WriteLine("inserted into list " + new_node.data);

        }
        public node GetLastnode()
        {
            node temp = this.head;
            while(temp.next != null );
            {
                temp = temp.next;
            }
            return temp;
        }

    }
}
