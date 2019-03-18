using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotate : MonoBehaviour
{
    public Transform target;
    public float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            Debug.LogError("Target is NULL");

        Vector3 rot = new Vector3();
        rot.x = Input.GetAxis("Mouse Y");
        rot.y = -Input.GetAxis("Mouse X");
        //Vector3 rot = new Vector3(Input.GetAxis("Mouse Y"), -Input.GetAxis("Mouse X"), 0f);
        target.Rotate(rot * speed * Time.deltaTime);
    }
}
