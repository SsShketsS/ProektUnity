using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ss : MonoBehaviour
{
    public GameObject SomeGameObject;

    // Start is called before the first frame update
    void Start()
    {
        SomeGameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        SomeGameObject.SetActive(true);
    }
}
