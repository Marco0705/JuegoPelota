using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour
{
    public GameObject recordUI;
    void Start()
    {
        if(PlayerPrefs.HasKey("TOQUESRECORD")){

            recordUI.GetComponent<Text>().text = PlayerPrefs.GetInt("TOQUESRECORD").ToString();
        }
        else{
            recordUI.GetComponent<Text>().text = "";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
