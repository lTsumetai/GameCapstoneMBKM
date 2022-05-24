using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private Animator anim;
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
        if (collision.tag == "Ship")
        {
            anim.SetTrigger("GoDestroyItem");
            StartCoroutine(nameof(DelayDestroy));
        }
    }

    private IEnumerator DelayDestroy()
    {
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);
    }
}