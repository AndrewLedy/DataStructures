using System.ComponentModel;

namespace DataStructures
{
    public class CustomArray
    {
        private int[] Items { get; set; }
        private int Count { get; set; }
        public CustomArray(int length = 3)
        {
            Items= new int[length];
            Count = 0;
        }

        public int[] Insert(int value)
        {
            if (Count == Items.Length)
            {
                int[] newItems = new int[Count * 2];
                for (int i = 0; i < Count; i++) //Why not length?
                {
                    newItems[i] = Items[i];
                }

                newItems[Count++] = value;
                Items= newItems;
            }
            else
            {
                Items[Count++] = value;               
            }            
            return Items;            
        }

        public void RemoveAt(int index)
        {
            if (index<0 || index>=Count)
            {
                throw new InvalidDataException();
            }
            for (int i=index; i<Count; i++)
            {
                Items[i] = Items[i + 1];
            }
            Count--;
        }

        public void Print()
        {
            for (int i=0;i<Count;i++)
            {
                Console.WriteLine(Items[i]);
            }
        }

        public int indexOf(int value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Items[i] == value) return i;
            }
            return -1;
        }
    }
}
