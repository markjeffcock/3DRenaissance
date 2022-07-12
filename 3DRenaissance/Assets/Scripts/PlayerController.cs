using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject[] paintingChange = new GameObject[16];
    public int currentPainting;

    // Start is called before the first frame update
    // Element 0 is the default painting
    void Start()
    {
        paintingChange[0].SetActive(true);
        currentPainting = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // Switch off current Painting
    // Set to newly request Painting (Button pressed)
    // Reset value of currentPainting
    public void activate(int paintingButton)
    {
        paintingChange[currentPainting].SetActive(false);
        paintingChange[paintingButton].SetActive(true);
        currentPainting = paintingButton;
    }

}
