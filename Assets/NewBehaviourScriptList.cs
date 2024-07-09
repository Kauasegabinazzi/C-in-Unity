using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScriptLisr : MonoBehaviour
{
    public List<int> age = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        age.Add(1);
        age.Add(2);
        age.Add(3);
        age.Add(4);

        //age.Remove(1);

        //age.Clear();

        foreach (int i in age)
        {
            Debug.Log(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
