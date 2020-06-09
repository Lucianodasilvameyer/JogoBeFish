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
    
   
    

    public int strength; 

    public float speed;

    [SerializeField]
    private Vector2 direction;

    // Start is called before the first frame update
    void Awake()
    {
        
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Piranha"))
        {
            var ColisaoComPiranha = GameObject.Find("Piranha").GetComponent<HabilidadesGeraisPlayer>();

            if(ColisaoComPiranha != null)
            {
                habilidadesGeraisPlayer_ref = ColisaoComPiranha;
            }
        }
        else if (collision.gameObject.CompareTag("Cascudo"))
        {
            var ColisaoComCascudo = GameObject.Find("Cascudo").GetComponent<HabilidadesGeraisPlayer>();

            if(ColisaoComCascudo != null)
            {
                habilidadesGeraisPlayer_ref = ColisaoComCascudo;
            }
        }
    }

   

    /*public void SomPlay(AudioClip Som)
    {
        audioSource.clip = Som;
        audioSource.Play();
    }*/
}
