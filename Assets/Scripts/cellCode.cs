using TMPro;
using UnityEngine;

public class cellCode : MonoBehaviour
{
    public GameObject text;
    public ChekingCode code;
    [Header("InputField")]
    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
    public TMP_InputField inputField3;

    
    public void Create()
    {
        text.SetActive(true);
    }
    public void Cheaking()
    {
        foreach(char t in inputField1.text)
        {
            if (t == '/')
                code.i++;
        }
        foreach (char t in inputField2.text)
        {
            if (t == '/')
                code.q++;
        }
        foreach (char t in inputField3.text)
        {
            if (t == '/')
                code.q++;
        }
        
    }


}
