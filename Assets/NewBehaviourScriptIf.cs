using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScriptIf : MonoBehaviour
{
    public bool IsAlive = false;
    // Start is called before the first frame update
    void Start()
    {
        if (IsAlive == true)
        {
            Debug.Log("sim");
        }
        else
        {
            Debug.Log("Não");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("z");
        }
    }
}
