using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass
{
    public int apples;
    public int banannas;


    private int stapler;
    private int sellotapes;


    // Start is called before the first frame update
    public void FruitMachine (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total:" + answer);
    }

    // Update is called once per frame
    private void OfficeSort (int a, int b) 
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total:" + answer);
    }
}
