using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HmGenerics
{

    class BaseProper
    {
        public string Id { get; set; }

    }
    class Teacher : BaseProper
    {
        public int StudentWasRegistred { get; set; }
        public override string ToString()
        {
            return $"Teacher";
        }
    }
    class stuclass : BaseProper
    {
        public int numberofsudnet { get; set; }
        public override string ToString()
        {
            return "class";
        }
    }
    class GenericId<T> where T : BaseProper
    {
        T[] listid = new T[10];
        public int count { get; set; } = 1;
        public void Add(T data)
        {
            for (int i = 0; i < listid.Length; i++)
            {
                if (listid[i] == null)

                {
                    listid[i] = data;
                    listid[i].Id = $"{count}";
                    count++;
                    break;
                }
                
            }
        }
    
        public string findById(string id)
        {
            for (int i = 0; i < listid.Length; i++)
            {
                if (listid[i] !=null)
                {
                if (listid[i].Id == id)
                {
                    return listid[i].ToString();
                }

                }

            }
            return "not exist";
        }
    }
}

