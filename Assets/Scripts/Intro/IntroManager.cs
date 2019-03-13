using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Q Pressed");
        }
        else if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Left Button Pressed");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //SceneManager.LoadScene(1);
            //SceneManager.LoadScene("1-Behaviours");
        }

    }
}
