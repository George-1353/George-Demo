using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newawaer : MonoBehaviour
{

    bool answer = !(709 < 20);
    bool another1 = !(60 == 20);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(answer);

        Debug.Log(another1);
    }
}
