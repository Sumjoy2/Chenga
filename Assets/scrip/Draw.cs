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

}
