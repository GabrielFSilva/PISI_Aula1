using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSwap : MonoBehaviour
{
    public Renderer target;

    public Material redMaterial;
    public Material greenMaterial;
    public Material blueMaterial;
    public Material cyanMaterial;
    public Material magentaMaterial;
    public Material yellowMaterial;
    public Material blackMaterial;
    public Material whiteMaterial;

    // Private variables don't show in Inspector
    private Material hiddenMaterial;

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
            Debug.LogWarning("Material Swapper Target is NULL");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            SwapMaterial(redMaterial);
        else if (Input.GetKeyDown(KeyCode.G))
            SwapMaterial(greenMaterial);
        else if (Input.GetKeyDown(KeyCode.B))
            SwapMaterial(blueMaterial);
        else if (Input.GetKeyDown(KeyCode.C))
            SwapMaterial(cyanMaterial);
        else if (Input.GetKeyDown(KeyCode.M))
            SwapMaterial(magentaMaterial);
        else if (Input.GetKeyDown(KeyCode.Y))
            SwapMaterial(yellowMaterial);
        else if (Input.GetKeyDown(KeyCode.K))
            SwapMaterial(blackMaterial);
        else if (Input.GetKeyDown(KeyCode.W))
            SwapMaterial(whiteMaterial);
    }

    private void SwapMaterial(Material targetMaterial)
    {
        if (target == null)
            Debug.LogError("Target is NULL");

        target.material = targetMaterial;
    }
}
