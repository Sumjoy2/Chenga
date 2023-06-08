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

