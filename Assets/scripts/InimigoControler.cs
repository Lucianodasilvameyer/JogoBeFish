﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoControler : MonoBehaviour
{
   
    public Interface interface_ref;
    public HabilidadesGeraisInimigo habilidadesGeraisInimigo_ref;
    SpawnInimigo spawnInimigo_ref;

    private void Awake()
    {
        spawnInimigo_ref = GetComponent<SpawnInimigo>();
        interface_ref = GameObject.Find("Cascudo").GetComponent<Interface>();
        habilidadesGeraisInimigo_ref = GameObject.Find("Tubarao").GetComponent<HabilidadesGeraisInimigo>();
    }

    private void Start()
    {
        interface_ref.OnPlayerDeath += DesativarControleInimigo; //aqui ja esta adicionado a função desde o começo do jogo 
    }
    
    //Essa função é chamada quando o evento "OnPlayerDeath()" é disparado, no Script Interface
    public void DesativarControleInimigo()
    {
        Debug.Log("Chamando função DesativarControleInimigo() em " + gameObject.name);

        if (interface_ref.hp <= 0)                                             
        {                                                                             //vetor e array é a mesma coisa? 
            GameObject[] inimigosArray = spawnInimigo_ref.ListInimigosVivos.ToArray();   //aqui deve-se transformar a lista pq fica mais facil de percorer o vetor

            Debug.Log("Tamanho do vetor: " + inimigosArray.Length);
                                                                                                   
            if (inimigosArray.Length > 0) // verifica se tem objetos no array                      
            {
                for(int i = 0; i < inimigosArray.Length; i++)  //o i é um contador                          //aqui vai rodar cada objeto na lista
                {                                                                             
                    Debug.Log("Valor de i: " + i);

                    inimigosArray[i].GetComponent<HabilidadesGeraisInimigo>().enabled=false; //aqui no caso todos os da ListInimigosVivos tem essa classe?// 
                }
            }
        }
    }

    private void OnDisable()
    {
        interface_ref.OnPlayerDeath -= DesativarControleInimigo; //em que parte esta função é acionada? 
    }

}