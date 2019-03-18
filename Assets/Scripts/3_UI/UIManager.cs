using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleChanged(bool value)
    {
        Debug.Log("Toggled value is: " + value);
    }

    public void DropdownChanged(int value)
    {
        Debug.Log("Dropdown value is: " + value);
    }

    public void ScrollbarChanged(float value)
    {
        Debug.Log("Scrollbar value is: " + value);
    }

    public void ChangeScene(string targetScene)
    {
        SceneManager.LoadScene(targetScene);
    }

}
