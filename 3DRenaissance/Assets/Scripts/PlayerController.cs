using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject painting1;
    public GameObject painting2;

    public GameObject[] paintingChange = new GameObject[16];
    // Material[1]
    // Material[2] etc
    // Start is called before the first frame update
    // Element 0 is the default painting
    void Start()
    {
        paintingChange[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void activate(int paintingButton)
    {
        painting1.SetActive(false);
        painting2.SetActive(false);
        paintingChange[paintingButton].SetActive(true);
    }
        public void activate1(string empty1)
    {
        painting1.SetActive(true);
        painting2.SetActive(false);
    }
    public void activate2(string empty2)
    {
        painting1.SetActive(false);
        painting2.SetActive(true);
    }
}
