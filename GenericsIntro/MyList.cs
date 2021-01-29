using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{ 


    class MyList<T> //T verilen tipe karşılık gelir
    {

        T[] items;
        
        //constructor  
        public MyList()  //ctor yazıp tab tab yap
        {
            items = new T[0];
        }

        public void Add(T item)
        {        //geçicidizi
            T[] TempArray = items;
            items = new T[items.Length+1]; //dizinin eleman sayısı(items.Lenght)//new'leyince elemanlar gider bu yüzden geçicidizi oluşturulur.
            for (int i = 0; i < TempArray.Length; i++)
            {
                items[i] = TempArray[i];
            }

            items[items.Length - 1] = item;



        }


    }
}
