using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBlock : MonoBehaviour
{

    public List<GameObject> blocks;
    public List<Material> materials;
    public Material selectedMaterial;

    // Start is called before the first frame update
    void Start()
    {
        if(selectedMaterial == null)
        {
            selectedMaterial = materials[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject block in blocks)
        {
            block.GetComponent<MeshRenderer>().material = selectedMaterial;
        }
    }
}
