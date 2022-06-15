using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] Text CountdownText;

    void Start()
    {
        currentTime = startingTime;
    }
    
    void update()
    {
        currentTime -= 1 * Time.deltaTime;
        CountdownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
