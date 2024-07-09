using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScriptFor : MonoBehaviour
{
    public int[] arrayInt = {1,2,3,4};

    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i < 10; i++)
        //{
        //    Debug.Log(i);
        //}

        foreach (int i in arrayInt)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
