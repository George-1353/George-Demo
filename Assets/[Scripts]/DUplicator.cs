using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DUplicator : MonoBehaviour
{
    public GameObject ball;

    public Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(ball, spawn.position, spawn.rotation);
    }
}
