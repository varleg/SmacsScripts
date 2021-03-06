﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    IEnumerator OnTriggerEnter(Collider other) 
    {
        anim.SetBool("open", true);
        yield return new WaitForSeconds(3);
        anim.SetBool("open", false);
    }

    private void OnTriggerExit(Collider other) 
    {
        anim.SetBool("open", false);
    }

    void Update()
    {
        
    }
}
