﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soluzione : MonoBehaviour
{
    public static bool youWin;
    public Transform[] pictures;
    public GameObject player;
    public GameObject game;
    public Camera camera;
    public bool open;
    public GameObject libro1;
    private bool cont;

    // Start is called before the first frame update
    void Start()
    {
        youWin = false;
        cont = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pictures[0].rotation.eulerAngles.z == 180 &&
            pictures[1].rotation.eulerAngles.z == 0 &&
            pictures[2].rotation.eulerAngles.z == 180 && 
           (pictures[3].rotation.eulerAngles.z == 0 ||
            pictures[3].rotation.eulerAngles.z == 270 ) &&
            pictures[4].rotation.eulerAngles.z == 270 &&
            pictures[5].rotation.eulerAngles.z == 0)
        {
            youWin = true;
            game.SetActive(false);
            camera.enabled = true;
            if (cont == false)
            {
                libro1.SetActive(true);
                cont= true;
            }

        }
    }
}
