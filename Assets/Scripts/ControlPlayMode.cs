using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayMode : MonoBehaviour
{
    [SerializeField] private PlayMode playMode;

    private enum PlayMode
    {
        PC,
        phone
    }

    private void Start()
    {
    }

    private void Update()
    {
        if (playMode == PlayMode.phone)
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
