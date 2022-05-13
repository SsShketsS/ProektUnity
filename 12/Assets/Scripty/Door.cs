using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool _isOpened;
    [SerializeField] private Animator anim;

    public AudioSource AudioDoor;
    
   public void Open()
    {
        anim.SetBool("isOpened", _isOpened);
        _isOpened = !_isOpened;
        AudioDoor.Play();
    }
}
