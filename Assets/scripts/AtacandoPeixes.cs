using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;

public class AtacandoPeixes : MonoBehaviour
{
    
    public bool armadura = true;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Piranha"))
        {
            
            var ColisaoContraPiranha = GetComponent<HabilidadesGeraisInimigo>();

            if(ColisaoContraPiranha != null)
            {
                ColisaoContraPiranha.CausarDano(collision.GetComponent<Player>());
            }

            Debug.Log("acertou");
        }
        else if (collision.gameObject.CompareTag("Cascudo"))
        {
            if (armadura == true)
            {
                IntervaloParaDano();
            }
            else
            {
                var ColisaoContraCascudo = GetComponent<HabilidadesGeraisInimigo>();

                if (ColisaoContraCascudo != null)
                {
                    ColisaoContraCascudo.CausarDano(collision.GetComponent<Player>());
                }
                ReativarArmadura();

            }
            

        }
    }
    public void IntervaloParaDano()
    {
        
       StartCoroutine("PoderTomarDano");
    }
    IEnumerator PoderTomarDano()
    {
        yield return new WaitForSeconds(0.5f);
        armadura = false;  
    }
    public void ReativarArmadura()
    {
       StartCoroutine("RecuperarArmadura");
        
    }
    IEnumerator RecuperarArmadura()
    {
        yield return new WaitForSeconds(4.0f);
        armadura = true;
    }
    
}
