using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HabilidadesGeraisInimigo : MonoBehaviour
{
    //AudioSource audioSource;
    //AudioClip somCausarDano;
    //AudioClip somTomarDano;

   
    HabilidadesGeraisPlayer habilidadesGeraisPlayer_ref;

    public GameObject piranha;
    public GameObject cascudo;
    

    public int strength; 

    public float speed;

    [SerializeField]
    private Vector2 direction;

    // Start is called before the first frame update
    void Awake()
    {
        VerificarPlayer();
        //habilidadesGeraisPlayer_ref = GameObject.Find("Piranha").GetComponent<HabilidadesGeraisPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }
    public void Mover()
    {
       transform.Translate(speed * direction * Time.deltaTime);
        
    }

    


    public void CausarDano(Player player)
    {
       habilidadesGeraisPlayer_ref.TomarDano(strength);
    }

    public void VerificarPlayer()
    {
        if (piranha.activeInHierarchy == true)
        {
            habilidadesGeraisPlayer_ref = GameObject.Find("Piranha").GetComponent<HabilidadesGeraisPlayer>();
        }
        if (cascudo.activeInHierarchy == true)
        {
            habilidadesGeraisPlayer_ref = GameObject.Find("Cascudo").GetComponent<HabilidadesGeraisPlayer>();
        }
    }

    /*public void SomPlay(AudioClip Som)
    {
        audioSource.clip = Som;
        audioSource.Play();
    }*/
}
