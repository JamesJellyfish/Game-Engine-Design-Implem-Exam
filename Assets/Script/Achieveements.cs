//https://www.youtube.com/watch?v=-on5HRW8v1A Galaga Tutorial
// James Pham 100741773 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achieveements : MonoBehaviour
{
    public GameObject FiveDeaft;
    public GameObject TenDeaft;
    public GameObject AllDeaft;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            FiveDeaft.SetActive(true);
            TenDeaft.SetActive(false);
            AllDeaft.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            FiveDeaft.SetActive(false);
            TenDeaft.SetActive(true);
            AllDeaft.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            FiveDeaft.SetActive(false);
            TenDeaft.SetActive(false);
            AllDeaft.SetActive(true);
        }
    }
}
