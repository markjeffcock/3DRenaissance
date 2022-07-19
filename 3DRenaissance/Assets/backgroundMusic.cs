using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class backgroundMusic : MonoBehaviour

{

    public AudioSource musicPiece;
 //   public Material showingMaterial;

    // Start is called before the first frame update

    void Start()
    {
        musicPiece.enabled = true;
    //    showingMaterial = transform.Find("AudioToggle").GetComponent<Material>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Switch on Music

    public void toggle(int onOff)
    {
        if (musicPiece.enabled)
        {
            musicPiece.enabled = false;
       //     image.enabled = false;
        }

        else
        {
             musicPiece.enabled = true;
        }
    }
    
}
