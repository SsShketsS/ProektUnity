using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{



    //Работа кнопки старта игры 
        public void StartScence()
    {
        Application.LoadLevel("Demo");
    }


    //Работа кнопки опций
    public void Options(GameObject window)
    {
        window.SetActive(true);
    }

    //Работа кнопки выхода
    public void Quit()
    {
        Application.Quit();
    }
}
