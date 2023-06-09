using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject TheTower;
    // Start is called before the first frame update
    void Start()
    {
        TheTower = GameObject.Find("Blocks");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(TheTower.transform.position);
    }
}
