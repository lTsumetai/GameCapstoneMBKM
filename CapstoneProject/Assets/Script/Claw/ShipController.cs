using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    bool goLeft, goRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input to Left
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            goLeft = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            goLeft = false;
        }

        //Input to Right
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            goRight = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            goRight = false;
        }

        if (goRight)
        {
            gameObject.transform.Translate(0.01f, 0, 0);
        }

        if (goLeft)
        {
            gameObject.transform.Translate(-0.01f, 0, 0);
        }
    }
}
