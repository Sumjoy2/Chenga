using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGround : MonoBehaviour
{

    public bool hitGround;
    public GameObject blocks;

    // Start is called before the first frame update
    void Start()
    {
        hitGround = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground" && hitGround == false)
        {
            blocks.GetComponent<BlockInteraction>().blockHitGround += 1;
            hitGround = true;
        }
    }
}
