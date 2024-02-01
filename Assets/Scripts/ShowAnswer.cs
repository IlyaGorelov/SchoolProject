using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAnswer : MonoBehaviour
{
    public GameObject text;
    

    // Update is called once per frame
  public  void Show()
    {
        
        if(text.activeSelf)
        {
            text.SetActive(false);
        }
        else if(!text.activeSelf)
        {
            text.SetActive(true);
        }
    }
}
