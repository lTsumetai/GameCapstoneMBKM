using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    private Animator anim;
    public GameObject progresStatus;
    public int progresvalue;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "CheckPoint")
        {
            //.SetTrigger("GoDestroyItem");
            StartCoroutine(nameof(DelayDestroy));
            progresStatus.GetComponent<Text>().text = progresvalue + "%";
        }
    }

    private IEnumerator DelayDestroy()
    {
        yield return new WaitForSeconds((float)0.5);
        gameObject.SetActive(false);
    }
}
