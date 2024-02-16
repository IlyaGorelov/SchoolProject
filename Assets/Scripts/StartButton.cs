using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject buttonPrefab;
    private void Start()
    {
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Time.timeScale = 1f;
            buttonPrefab.SetActive(false);
        }
    }
}
