﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxControler2Layer2 : MonoBehaviour
{
    Interface interface_ref;
    Parallax parallax_ref;

    private void Awake()
    {
        interface_ref = GameObject.Find("Cascudo").GetComponent<Interface>();
        parallax_ref = GameObject.Find("2Layer2").GetComponent<Parallax>();
    }

    // Update is called once per frame
    void Update()
    {
        DesativarParallax2Layer2();
    }
    public void DesativarParallax2Layer2()
    {
        if (interface_ref.hp <= 0)
        {
            parallax_ref.enabled = false;
        }
    }
}
