using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolorbox : MonoBehaviour
{
    public Material[] material;
    public int x;
    Renderer rend;


    void Start()
    {
        x = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[x];
    }


    void Update()
    {
        rend.sharedMaterial = material[x];
    }

    public void NextColor()
    {
        if (x < 2)
        {
            x++;
        }
        else
        {
            x = 0;
        }
    }

    
}
