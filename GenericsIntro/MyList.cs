using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        //first we declare an array as T which means I don't have to spesify the type of array now. 
        public T[] items;

        //we made a constructor here. And give a new adress to items for 1 member array. 
        public MyList()
        {
            items = new T[0];
        }

        //Now. We want to add a new member to items. Normaly it can't accept because length of items 
        // is one. Out of bondry error would have been accur. 
        //So we make a function. We dont spesify parameter so we say T item. 
        //And then we give the adress of items array to tempArray so that tempArray can hold the values for us.
        //and then items hold a new adress for 1 more value( items.Length+1)
        //But our old values doesn't lost. tempArray keeping them. 
        // Now we give all values of tempArray to items array back. 
        //That is how we do generic arrays. 
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        //this is for getting values from this class when we are at another class. 
        // if we create an instance of this class. lets say "names". 
        // we can get the length of names by typing names.Length. 
        //Same for T[] Items. It returns array itself. 


        public int Length { get { return items.Length; } set { } }
        public T[] Items { get { return items; } set { } }
    }
}
