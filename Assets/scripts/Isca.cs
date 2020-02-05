﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isca : MonoBehaviour
{
    [SerializeField]
    Isca IscaDoPeixe;

    
    SpawnInimigo spawnInimigo;

    // Start is called before the first frame update
    void Awake()
    {
        
        spawnInimigo = GameObject.Find("Game").GetComponent<SpawnInimigo>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ColisorDeTras"))
        {
            spawnInimigo.adicionarOuDestruir(IscaDoPeixe.gameObject);
        }
    }

}
