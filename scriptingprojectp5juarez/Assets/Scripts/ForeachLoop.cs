using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string[] strings = new string[3];

        strings[0] = "Firststrings";
        strings[1] = "Secondstring";
        strings[2] = "Thirdstring";

        foreach(string item in strings)
        {
            print(item);
        }
        
    }
}
