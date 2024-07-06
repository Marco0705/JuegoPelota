using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balon : MonoBehaviour
{
    public GameObject panelDerrota;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other){

        if(other.gameObject.tag == "LimitePorteria"){

            panelDerrota.SetActive(true);
            Time.timeScale = 0.0f;

            if(PlayerPrefs.HasKey("TOQUESRECORD")){

                if(General.nToques > PlayerPrefs.GetInt("TOQUESRECORD")){

                    PlayerPrefs.SetInt("TOQUESRECORD", General.nToques);
                }
            }
            else{

                PlayerPrefs.SetInt("TOQUESRECORD", General.nToques);
            }
            
        }
    }
}
