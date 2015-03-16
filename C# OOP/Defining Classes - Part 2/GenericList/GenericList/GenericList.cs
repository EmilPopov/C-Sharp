
using System;
namespace GenericLists
{
    public class GenericList<T>
    {
        // Constants
        private const uint DefaultCapacity = 4;

        // Fields
        private T[] elements = null;

        // Properties
        public uint Count { get; private set; }
        public uint Capacity { get; private set; }

        // Constructors
        public GenericList(uint capacity)
        {
            this.Capacity = capacity;
            this.Count = 0;

            elements = new T[this.Capacity];
        }
        // Methods
        public void Clear()
        {
            this.Capacity = DefaultCapacity;
            this.Count = 0;
            elements = new T[this.Capacity];
        }

        private void Reserve(uint capacity)
        {
            uint oldCapacity = this.Capacity;

            if (capacity == 0 || capacity == 1)
                this.Capacity = 1;

            else if (capacity <= this.Capacity / 2)
                this.Capacity /= 2;

            else if (capacity > this.Capacity)
                this.Capacity *= 2;

            if (oldCapacity != this.Capacity)
                Array.Resize(ref elements, (int)this.Capacity);
        }
        public void Add(T elem)
        {
            this.Count++;

            Reserve(this.Count);

            this.elements[this.Count - 1] = elem;
        }

        public void Remove(uint i)
        {
            if (i >= this.Count)
                throw new IndexOutOfRangeException();

            this.Count--;

            Array.Copy(this.elements, i + 1, this.elements, i, Count - i);

            this.elements[this.Count] = default(T); // Clear last

            Reserve(this.Count);
        }
        public void Insert(uint i, T elem)
        {
            if (i > this.Count) // We can insert in the last position
                throw new IndexOutOfRangeException();

            this.Count++;

            Reserve(this.Count);

            Array.Copy(elements, i, elements, i + 1, Count - i - 1);

            this.elements[i] = elem;
        }

        public int IndexOf(T elem)
        {
            return Array.IndexOf(elements, elem);
        }

        private T MinMax(bool value)
        {
            T best = this.elements[0];

            for (int i = 1; i < this.Count; i++)
                if (value ? (best < (dynamic)this.elements[i]) : (best > (dynamic)this.elements[i]))
                    best = this.elements[i];

            return best;
        }

        public T Max()
        {
            return MinMax(true);
        }

        public T Min()
        {
            return MinMax(false);
        }

        public T this[uint index]
        {
            get
            {
                if (index >= this.Count)
                    throw new IndexOutOfRangeException();

                return elements[index];
            }
        }

        public override string ToString()
        {
            if (this.Count == 0)
                return "Empty list.";

            string[] info = new string[this.Count];

            for (int i = 0; i < this.Count; i++)
                info[i] = String.Format("{0}: {1}", i, this.elements[i].ToString());

            return String.Join(Environment.NewLine, info);
        }
    }
}

