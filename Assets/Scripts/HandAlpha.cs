using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAlpha : MonoBehaviour
{
    private float Alpha1 = 1;
    private float Alpha2= 0.4f;
    private float Visibility;


    private void Start()
    {
        Visibility = Alpha1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Visibility = Alpha2;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Visibility = Alpha2;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Visibility = Alpha1;
        }
        
     ChangeAlpha(this.GetComponent<Renderer>().material, Visibility);
    }

    void ChangeAlpha(Material mat, float AlphaVal)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, AlphaVal);
        mat.SetColor("_Color", newColor);
    }
}
