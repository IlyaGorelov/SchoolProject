using TMPro;
using UnityEngine;

public class SpecSymbols : MonoBehaviour
{
    private TMP_InputField inputField1;
    private void Start()
    {
        inputField1 = GetComponent<TMP_InputField>();
    }

    private void Update()
    {
        ReplaceText();
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
