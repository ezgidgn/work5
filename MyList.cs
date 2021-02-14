using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work5
{
    class MyList<T>
    {
        T[] items;

        public MyList()
        {
            items = new T[0]; // 0 elemanlı bir items.
        }
        public void Add(T item)
        {
            T[] tempArray = items; //items deki değerleri geçici olarak buraya attım.
            items = new T[items.Length + 1];// T nin kapasitesini 1 arttırdım.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // tempsArray deki değerlerimi geri items a alıyorum.

            }
            items[items.Length - 1] = item; // eklenmek istenen son eleman burda eklendi.(1 eksiği son elemanı verir.


        }
           public int Length
        {
            get { return items.Length; }
        }
           
            public T[] Items
        {
            get { return items; }
        }







        }
    }
