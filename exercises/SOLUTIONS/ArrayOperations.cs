using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayOperations : MonoBehaviour
{

    public int[] quizes = { 10, 20, 30 };

    //1.Create a script that accepts a List/Array of numbers and Sums its values
    public int sumArray(int[] toBeSummed)
    {
        int sum = 0;
        foreach (int item in toBeSummed)
        {
            sum += item;
        }
        return sum;
    }

    //2.Create a script that accepts a List/Array of numbers and Outputs
    //  the Average of its values
    public int avgArray(int[] toBeAvg)
    {
        int sum = 0;
        int i = 0;
        int avg = 0;
        foreach (int item in toBeAvg)
        {
            sum += item;
            i++;
        }
        avg = sum / i;
        return avg;
    }

    //3.Create a script that accepts a List/Array of numbers and produces
    //  a second List containing only the numbers divisible by 3.
    public int[] crtNewArray(int[] toBeCrtList)
    {
        List<int> newList = new List<int>();

        foreach (int item in toBeCrtList)
        {
            if (item % 3 == 0)
            {
                newList.Add(item);
            }
        }
        return newList.ToArray();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
        int sum1 = sumArray(quizes);
        Debug.Log(sum1);
        int avg1 = avgArray(quizes);
        Debug.Log(avg1);
        int[] quizesDivByThree = crtNewArray(quizes);
    }

    // Update is called once per frame
    void Update()
    {

    }


}

