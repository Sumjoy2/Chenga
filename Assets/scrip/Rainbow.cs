using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainbow : MonoBehaviour
{

    public List<Color> colors;
    public Material rainbow;
    private int currentColor = 0;
    public bool canColor;

    // Start is called before the first frame update
    void Start()
    {
        rainbow.color = colors[currentColor];
        canColor = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(canColor == true)
        {
            StartCoroutine(wait());
        }
        rainbow.color = colors[currentColor];
    }

    IEnumerator wait()
    {
        canColor = false;
        yield return new WaitForSeconds(0.1f);
        if(currentColor <= 5)
        {
            currentColor += 1;
            canColor = true;
        }
        else
        {
            currentColor = 0;
            canColor = true;
        }
    }
}
