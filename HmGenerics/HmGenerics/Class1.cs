using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HmGenerics
{
    class Basic
    {
        public int Id { get; set; }
        public string name { get; set; }
    }
    class student : Basic
    {
        public int StudentWasRegistred { get; set; }
        public override string ToString()
        {
            return $"student";
        }
    }
    class ReadOnlycolletion<T> where T :Basic
    {
        T[] list = new T[1000];
        public bool IsReadOnly { get; set; }
        public int count { get; set; } = 1;
        public void AddToList(T data)
        {
            if (!IsReadOnly)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] == null)

                    {
                        list[i] = data;
                        list[i].Id = count;
                        list[i].name = $"{data.ToString()}{count}";
                        count++;
                        break;

                    }
                }
            }
            else
            {
                throw new InvalidOperationException(" list is read onyl");
            }
        }
        public void StopReadOnly()
        {
            if (IsReadOnly == true)
            {
                IsReadOnly = false;
            }
            else
            {
                IsReadOnly = true;
            }
        }
        public string findById(int id)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Id == id)
                {
                    return list[i].name;
                }
            }
            return null;
        }
    }
}
