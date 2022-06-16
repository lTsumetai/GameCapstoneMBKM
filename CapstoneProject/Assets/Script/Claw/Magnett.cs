using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnett : MonoBehaviour
{
    public GameObject clawleft;
    public GameObject clawright;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            clawleft.SetActive(true);
            clawright.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
