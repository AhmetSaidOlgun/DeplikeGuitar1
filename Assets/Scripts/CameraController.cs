using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;

    public GameObject Pointers;

    private GameObject GameControl;
    private GameController ControlScript;
    
    // Start is called before the first frame update

    // Update is called once per frame

    private void Start()
    {
        GameControl = GameObject.FindGameObjectWithTag("GameController");
        ControlScript = GameControl.GetComponent<GameController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
            Pointers.SetActive(true);
            
            if (ControlScript.t6 != null && ControlScript.t7 != null)
            {
                Destroy(ControlScript.t6);
                ControlScript.t7.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
        
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
            Pointers.SetActive(false);
            
            if (ControlScript.t9 != null)
            {
                Destroy(ControlScript.t9);
               
            }
            
            
            
           
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
           
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
            Pointers.SetActive(true);

            if (ControlScript.t8 != null && ControlScript.t9 != null)
            {
                Destroy(ControlScript.t8);
                ControlScript.t9.SetActive(true);
            }
            
        }
    }
}
