using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawController : MonoBehaviour
{
    bool goUp, goDown;
    public Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Input to Down
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            goDown = true;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            goDown = false;
        }


        //Input to Up
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            goUp = true;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            goUp = false;
        }

        //function movement
        if (goUp)
        {
            gameObject.transform.Translate(0, 0.01f, 0);
        }

        if (goDown)
        {
            gameObject.transform.Translate(0, -0.01f, 0);
        }    
    }

    
}