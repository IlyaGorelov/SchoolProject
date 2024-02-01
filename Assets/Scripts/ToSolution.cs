using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.UI.Image;

public class ToSolution : MonoBehaviour
{
    
    public Transform playerPOSITION;
    public Transform playerSecPos;
    public float speed;
    
    Vector3 playerNewPos;

        
    public void ToSolut()
    {
        Debug.Log("good");
        playerNewPos=playerSecPos.position;
        playerPOSITION.position = Vector3.Lerp(transform.localPosition, playerNewPos, speed);
    }
    
    // Update is called once per frame

}
