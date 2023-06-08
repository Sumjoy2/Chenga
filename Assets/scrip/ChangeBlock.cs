using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBlock : MonoBehaviour
{

    public List<GameObject> blocks;
    public List<Material> materials;
    public GameObject paint;
    public GameObject select;
    private Material selectedMaterial;
    private int selected = 0;

    // Start is called before the first frame update
    void Start()
    {
        selectedMaterial = materials[selected];
    }

    // Update is called once per frame
    void Update()
    {
        selectedMaterial = materials[selected];
        foreach (GameObject block in blocks)
        {
            // Should check if selected block. ignore if selected block. if not selected block change color back to white
            if (block.GetComponent<MeshRenderer>().material.color != Color.red)
                block.GetComponent<MeshRenderer>().material = selectedMaterial;
        }
    }



    public void Select(int whichOne)
    {
        selected = whichOne;
        select.SetActive(false);
    }

    public void showPaint()
    {
        paint.SetActive(true);
    }
}

