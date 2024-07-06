using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    protected float h;
    public float velocidad;
    protected bool bloquearDerecha = false;
    protected bool bloquearIzquierda = false;
    public GameObject puntuacion;

    void Start()
    {
        velocidad = 8.0f;
        Time.timeScale = 1.0f;
        General.nToques = 0;
    }
    void Update()
    {
        h = Input.GetAxis("Horizontal") * Time.deltaTime * velocidad;
        if(h > 0){

            if(!bloquearDerecha){

            this.gameObject.transform.Translate(h, 0.0f, 0.0f);
            }
        }
        else if(h < 0){

            if(!bloquearIzquierda){

            this.gameObject.transform.Translate(h, 0.0f, 0.0f);
            }
        }
    
    }
    private void OnTriggerEnter2D(Collider2D other){

        if(other.gameObject.tag == "LimiteDerecho"){
           
           bloquearDerecha = true;
        }
        if(other.gameObject.tag == "LimiteIzquierdo"){
            
            bloquearIzquierda = true;
        }

    }
    private void OnTriggerExit2D(Collider2D other){

        if(other.gameObject.tag == "LimiteDerecho"){
           
           bloquearDerecha = false;
        }
        if(other.gameObject.tag == "LimiteIzquierdo"){
            
            bloquearIzquierda = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D other){

        if(other.gameObject.tag == "Balon"){

            General.nToques = General.nToques + 1;
            puntuacion.GetComponent<Text>().text = General.nToques.ToString();
        }


    }
}
