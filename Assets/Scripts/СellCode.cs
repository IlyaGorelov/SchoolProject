using TMPro;
using UnityEngine;

public class СellCode : MonoBehaviour
{
    public GameObject text;
    public ChekingCode code;
    [Header("InputField")]
    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
    public TMP_InputField inputField3;

    private void Update()
    {
        ReplaceText();
    }
    public void Create()
    {
        text.SetActive(true);
    }
    public void Cheaking()
    {
        foreach (char t in inputField1.text)
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

    void ReplaceText()
    {
        inputField1.text = inputField1.text.Replace(":", "^");
        inputField1.text = inputField1.text.Replace("p1", "ρ");
        inputField1.text = inputField1.text.Replace("n1", "η");
        inputField1.text = inputField1.text.Replace("m1", "μ");
        inputField1.text = inputField1.text.Replace("v1", "ν");
    }
}
