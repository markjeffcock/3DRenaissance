using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseToggle : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Toggle BaseControllerPanel On
    public void Toggle(int switchToPanel)
    {
        if (switchToPanel == 1)
        { 
            panel1.SetActive(true);
            panel2.SetActive(false);
            panel3.SetActive(false);
        }

        if (switchToPanel == 2)
        {
            panel1.SetActive(false);
            panel2.SetActive(true);
            panel3.SetActive(false);
        }

        if (switchToPanel ==3 )
        {
            panel1.SetActive(false);
            panel2.SetActive(false);
            panel3.SetActive(true);
        }

    }
}
