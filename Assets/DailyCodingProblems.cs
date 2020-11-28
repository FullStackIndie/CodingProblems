using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyCodingProblems : MonoBehaviour
{

    private void Start()
    {
        int[] test = new int[5] { 1, 2 , 3, 4, 5};

         var t = MultiplyArray(test);
        Debug.Log(t.ToString());
    }

    public bool DailyCodingProblems_Day1(List<int> numList, int k)
    {
        // complete
        // Iterate thru list and find all combinations that return k
        // this method returns true at first combo found, doesnt search all
        for(int i = 0; i < numList.Count; i++)
        {
            foreach(int num in numList)
            {
                 if(num + numList[i] == k)
                {
                    Debug.Log($"num {num} : numList[{numList[i]}] :  == k {k}");
                    return true;
                }
                else
                {
                    Debug.Log($"num {num} : numList[{numList[i]}] :  == k {num + numList[i]}");
                }
            }
        }
        return false;
    }


    public int[] DailyCodingProblems_Day2(int[] array)
    {
        int[] result = array;
        int indexValue = 0;
        int[] lastIndex = array;
        for(int i = 0; i < array.Length; i++)
        {
            for(int r = 0; r < array.Length; r++)
            {
                if(array[r] != array[i])
                {
                    foreach(int num in array)
                    {
                        if(num != array[i])
                        {

                        }
                    }
                }
                
            }
           
            result[i] = indexValue;
            Debug.Log($"index value == {indexValue}");
            indexValue = 0;

        }
        return result;
    }



    public int[] MultiplyArray(int[] toMultiply)
    {
        int[] result = toMultiply;
        int[] lastIndex = toMultiply;

        for(int i = 0; i < toMultiply.Length; i++)
        {
            for(int r = 0; r < toMultiply.Length; i++)
            {
                if(r != i)
                {
                    Debug.Log("test");
                }
            }
        }

        return result;
    }
}
