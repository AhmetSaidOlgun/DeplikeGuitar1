using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam2Rotate : MonoBehaviour
{
    private float x;
    private float y;
    private Vector3 rotateValue;
    
    private GameObject GameControl;
    private GameController ControlScript;

    private void Start()
    {
        GameControl = GameObject.FindGameObjectWithTag("GameController");
        ControlScript = GameControl.GetComponent<GameController>();
    }
 
    void Update()
    {
        y = Input.GetAxis("Mouse X");
        //x = Input.GetAxis("Mouse Y");
        Debug.Log(x + ":" + y);
        rotateValue = new Vector3(x, y * -1, 0);
        transform.eulerAngles = transform.eulerAngles - rotateValue;

        if (y > 0.2 || y<-0.2)
        {
            
            if (ControlScript.t7 != null && ControlScript.t8 != null)
            {
                Destroy(ControlScript.t7);
                ControlScript.t8.SetActive(true);
            }
           
        }
        
        
    }
}
