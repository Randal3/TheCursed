﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Libreria : MonoBehaviour
{
    private Animator animator;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Soluzione.youWin == true)
        {
            Invoke("Active", 2);
        }
    }
    void Active()
    {
        audio.Play();
        animator.SetBool("trovato", true);
    }
}
