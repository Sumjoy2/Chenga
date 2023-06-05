using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Draw : MonoBehaviour
{

    public GameObject cursor;
    public GameObject menu;
    public Slider Red;
    public Slider Green;
    public Slider Blue;
    private Color currentColor;
    public GameObject current;
    private float size = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        currentColor = new Color(Red.value, Green.value, Blue.value);
        current.GetComponent<MeshRenderer>().material.color = currentColor;
        cursor.GetComponent<MeshRenderer>().material.color = currentColor;
        cursor.transform.localScale = new Vector3(size, 0.01f, size/2);
        Vector3 mousePos = Input.mousePosition;
        cursor.transform.position = new Vector3(mousePos.x/100 -9.5f, mousePos.y/100, -12f);
        if (Input.GetMouseButton(0))
        {
            cursor.transform.position = new Vector3(mousePos.x/ 100 - 9.5f, mousePos.y/ 100, -11.85f);
        }
    }

    public void done()
    {
        menu.SetActive(false);
    }

    public void sizeUp()
    {
        size += 0.1f;
    }
    public void sizeDown()
    {
        if(size != 0.1)
        {
        size -= 0.1f;
        }
    }
}
