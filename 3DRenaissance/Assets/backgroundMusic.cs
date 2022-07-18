using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMusic : MonoBehaviour

{

    public AudioSource musicPiece;

    // Start is called before the first frame update

    void Start()
    {
        musicPiece.enabled = true;
        musicPiece.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Switch on Music

    public void activateOn()
    {
        musicPiece.Play();
    }
    
}
