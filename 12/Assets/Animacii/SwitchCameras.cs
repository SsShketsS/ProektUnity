
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameras : MonoBehaviour
{
    public bool isLoad = false;
    public GameObject Camera1; //кидаем в эту переменную камеру первую и в инспекторе должна
                               //быть включена.
    public GameObject Camera2; //кидаем в эту переменную камеру вторую и в инспекторе должна
                               //быть Отключена.

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // тут подзабыл, может ошибка)))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
        }
    }
}
