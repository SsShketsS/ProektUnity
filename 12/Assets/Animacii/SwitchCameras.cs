
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameras : MonoBehaviour
{
    public bool isLoad = false;
    public GameObject Camera1; //������ � ��� ���������� ������ ������ � � ���������� ������
                               //���� ��������.
    public GameObject Camera2; //������ � ��� ���������� ������ ������ � � ���������� ������
                               //���� ���������.

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // ��� ��������, ����� ������)))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
        }
    }
}
