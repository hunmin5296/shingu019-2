using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContainer<T>
{
    private T[] items;                  //커스텀 배열
    private int currentIndex = 0;       //item 지금 번호


    public GenericContainer(int capacity)
    {
        items = new T[capacity];
    }

    public void Add(T item)
    {
        if(currentIndex < items.Length)
        {
            items[currentIndex] = item;
            currentIndex++;
        }
    }

    public T[] GetItems()
    {
        return items;
    }
}
