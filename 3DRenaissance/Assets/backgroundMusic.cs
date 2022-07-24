using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class backgroundMusic : MonoBehaviour

{

    public AudioSource musicPiece;
    public GameObject[] audioOn = new GameObject[3];
    public GameObject[] audioOff = new GameObject[3];

    //   public Material showingMaterial;

    // Start is called before the first frame update

    void Start()
    {
        musicPiece.enabled = true;
   
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Switch on/off Music & Audio icons

    public void toggle(int onOff)
    {
        if (musicPiece.enabled)
        {
            musicPiece.enabled = false;
            audioOn[0].SetActive(false);
            audioOn[1].SetActive(false);
            audioOn[2].SetActive(false);
            audioOff[0].SetActive(true);
            audioOff[1].SetActive(true);
            audioOff[2].SetActive(true);
        }

        else
        {
             musicPiece.enabled = true;
             audioOn[0].SetActive(true);
             audioOn[1].SetActive(true);
             audioOn[2].SetActive(true);
            audioOff[0].SetActive(false);
            audioOff[1].SetActive(false);
            audioOff[2].SetActive(false);
        }
    }
    
}
