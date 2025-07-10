using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript1 : MonoBehaviour
{

    //private string name = "George";

    bool answer = (4 > 1); // True or Falso;
    bool another1 = !(60 == 20);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("Hello! My name is" + name);

        Debug.Log(answer); 
        Debug.Log(another1); 
        
    }
}
