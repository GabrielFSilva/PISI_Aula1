using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeT : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(name + "entered trigger named: " + other.name);
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(name + "continued inside trigger named: " + other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(name + "exited trigger named: " + other.name);
    }
}
