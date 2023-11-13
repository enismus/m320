using System;
using System.Collections.Generic;

namespace Browser_Simulator
{
    public class StringStack
    {
        private LinkedList<string> elements = new LinkedList<string>();

        public void Push(string item)
        {
            elements.AddLast(item);
        }

        public string Pop()
        {
            if (IsEmpty)
            {
                return "Es gibt kein weiteres Element im Stapel.";
            }

            string lastItem = elements.Last.Value;
            elements.RemoveLast();
            return lastItem;
        }

        public string Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Der Stapel ist leer.");
            }

            return elements.Last.Value;
        }

        public void Clear()
        {
            elements.Clear();
        }

        public override string ToString()
        {
            return string.Join(", ", elements);
        }

        public bool IsEmpty => elements.Count == 0;

        public int Count => elements.Count;
    }
}
