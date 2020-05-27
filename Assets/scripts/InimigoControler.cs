using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoControler : MonoBehaviour
{

    BarraDeVida barraDeVida_ref;
   
    SpawnInimigo spawnInimigo_ref;

    private void Awake()
    {
        spawnInimigo_ref = GetComponent<SpawnInimigo>();
        barraDeVida_ref = GameObject.Find("Game").GetComponent<BarraDeVida>();  
    }

    public void DesativarControleInimigo()
    {

        Debug.Log("Chamando função DesativarControleInimigo() em " + gameObject.name);

        Debug.Log("Tamanho do vetor: " + spawnInimigo_ref.objetosObstaculosIsca.Length);
                                                                                                   
            if (spawnInimigo_ref.objetosObstaculosIsca.Length > 0) // verifica se tem objetos no array                      
            {
                for(int i = 0; i < spawnInimigo_ref.objetosObstaculosIsca.Length; i++)                            //aqui vai rodar cada objeto na lista
                {                                                                             
                    Debug.Log("Valor de i: " + i);

                    spawnInimigo_ref.objetosObstaculosIsca[i].GetComponent<HabilidadesGeraisInimigo>().enabled=false; //aqui no caso todos os da ListInimigosVivos tem essa classe?// 
                }
            }
            if (spawnInimigo_ref.objetoObstaculoTubarao.Length > 0)
            {
                for (int i = 0; i < spawnInimigo_ref.objetoObstaculoTubarao.Length; i++)
                {
                   spawnInimigo_ref.objetoObstaculoTubarao[i].GetComponent<HabilidadesGeraisInimigo>().enabled = false;
                }
            }
            if (spawnInimigo_ref.objetosObstaculosRede.Length > 0)
            {
                 for(int i=0; i< spawnInimigo_ref.objetosObstaculosRede.Length; i++)
                 {
                    spawnInimigo_ref.objetosObstaculosRede[i].GetComponent<HabilidadesGeraisInimigo>().enabled = false;  
                 } 
 
            }
            
        
    }

    private void OnEnable()
    {
        barraDeVida_ref.OnPlayerDeath += DesativarControleInimigo;
    }

    private void OnDisable()
    {
        barraDeVida_ref.OnPlayerDeath -= DesativarControleInimigo; 
    }

}
