using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardTranslate : MonoBehaviour
{
    public Transform target;
    public float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
            Debug.LogWarning("Keyboard Translate Target is NULL");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            TranslateTarget(Vector3.up); // (0,1,0)
        else if (Input.GetKey(KeyCode.DownArrow))
            TranslateTarget(Vector3.down); // (0,-1,0)
        else if (Input.GetKey(KeyCode.LeftArrow))
            TranslateTarget(Vector3.left); // (-1,0,0)
        else if (Input.GetKey(KeyCode.RightArrow))
            TranslateTarget(Vector3.right); // (1,0,0)
    }

    private void TranslateTarget(Vector3 direction)
    {
        if (target == null)
            Debug.LogError("Target is NULL");

        target.Translate(direction * speed * Time.deltaTime);
    }
}
