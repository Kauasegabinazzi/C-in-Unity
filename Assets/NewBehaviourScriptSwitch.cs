using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScriptSwitch : MonoBehaviour
{
    public int dayOfTheWeek = 1;

    // Start is called before the first frame update
    void Start()
    {
        switch (dayOfTheWeek)
        {
            case 1:
                Debug.Log("Monday");
                break;
            case 2:
                Debug.Log("Tuesday");
                break;
            case 3:
                Debug.Log("wednesdayfr");
                break;
            case 4:
                Debug.Log("Thursday");
                break;
            default:
                Debug.Log("Not found");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
