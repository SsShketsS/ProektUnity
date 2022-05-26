using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scc : MonoBehaviour
{
    public GameObject SomeGameObject;
    public GameObject SomeGameObject2;

    // Start is called before the first frame update
    void Start()
    {
        SomeGameObject2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        SomeGameObject.SetActive(false);
        SomeGameObject2.SetActive(true);
    }
}
