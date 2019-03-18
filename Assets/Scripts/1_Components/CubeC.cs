using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(name + " began collision with: " + collision.gameObject.name);
    }

    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log(name + " continued collision with: " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log(name + " ended collision with: " + collision.gameObject.name);
    }
}
