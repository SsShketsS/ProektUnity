using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabotaEscp : MonoBehaviour
{
    
    public GameObject PanelMenu;
    bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (!isActive)
            {
                PanelMenu.SetActive(true);
                isActive = true;
            }
            else
            {
                PanelMenu.SetActive(false);
                isActive = false;
            }
        }
    }
}
