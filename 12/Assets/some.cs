using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class some : MonoBehaviour
{
    public GameObject SomeGameObject;

    void OnMouseOver()
    {
        SomeGameObject.SetActive(true);
    }

    void OnMouseExit()
    {
        SomeGameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        SomeGameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
