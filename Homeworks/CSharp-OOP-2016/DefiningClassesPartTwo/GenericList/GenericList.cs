////Problem 5. Generic class
////Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.

namespace GenericList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GenericList<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 4;

        private T[] arrayOfElements;
        private int count = 0;

        ////Keep the elements of the list in an array with fixed capacity 
        ////which is given as parameter in the class constructor.

        public GenericList(int capacity)
        {
            this.arrayOfElements = new T[capacity];
        }

        public GenericList()
            : this(DefaultCapacity)
        {
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public int Capacity
        {
            get
            {
                return this.arrayOfElements.Length;
            }
        }

        //// Implement methods for:
        //// adding element , removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
        
        ////accessing element by index
        public T this[int index]
        {
            get
            {
                this.CheckIndex(index);
                T result = this.arrayOfElements[index];
                return result;
            }
        }
        
        //// adding element
        public void Add(T element)
        {
            this.Autogrow(this.arrayOfElements);
            this.arrayOfElements[this.Count] = element;
            this.count++;
        }

        ////removing element by index
        public void RemoveAt(int index)
        {
            for (int i = index + 1; i <= this.count - 1; i++)
            {
                this.arrayOfElements[i - 1] = this.arrayOfElements[i];
            }

            this.arrayOfElements[this.count - 1] = default(T);
            this.count--;
        }
        ////inserting element at given position
        public void Insert(int index, T item)
        {
            this.CheckIndex(index);
            this.Autogrow(this.arrayOfElements);
            for (int i = this.count; i > index; i--)
            {
                this.arrayOfElements[i] = this.arrayOfElements[i - 1];
            }

            this.arrayOfElements[index] = item;
            this.count++;
        }

        ////clearing the list
        public void Clear()
        {
            this.arrayOfElements = new T[DefaultCapacity];
            this.count = 0;
        }

        ////finding element by its value
        public int IndexOf(T value)
        {
            if (this.arrayOfElements.Contains(value))
            {
                int index = 0;
                for (int i = 0; i < this.Count; i++)
                {
                    if (this.arrayOfElements[i] == (dynamic)value)
                    {
                        index = i;
                        break;
                    }
                }

                return index;
            }
            else
            {
                return -1;
            }
        }

        ////ToString()
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.count; i++)
            {
                result.Append(this.arrayOfElements[i]);
                if (this.count != 1 && i != this.count - 1)
                {
                    result.Append(", ");
                }
            }

            return result.ToString();
        }

        ////Min<T>()
        public T Min()
        {
            this.ArrayIsNotEmpty();
            T currentMin = this.arrayOfElements[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (currentMin.CompareTo(this.arrayOfElements[i]) > 0)
                {
                    currentMin = this.arrayOfElements[i];
                }
            }

            return currentMin;
        }

        ////Max<T>()
        public T Max()
        {
            this.ArrayIsNotEmpty();
            T currentMax = this.arrayOfElements[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (currentMax.CompareTo(this.arrayOfElements[i]) < 0)
                {
                    currentMax = this.arrayOfElements[i];
                }
            }

            return currentMax;
        }

        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }

        private void Autogrow(T[] t)
        {
            if (this.Count == this.arrayOfElements.Length)
            {
                var newArray = new T[this.arrayOfElements.Length * 2];
                for (int i = 0; i < this.arrayOfElements.Length; i++)
                {
                    newArray[i] = this.arrayOfElements[i];
                }

                this.arrayOfElements = newArray;
            }
        }

        private void CheckIndex(int index)
        {
            if (index >= this.count)
            {
                throw new IndexOutOfRangeException($"Invalid index: {index}.");
            }
        }

        private void ArrayIsNotEmpty()
        {
            if (this.count == 0)
            {
                throw new ArgumentException("The GenericList is empty!");
            }
        }
    }
}