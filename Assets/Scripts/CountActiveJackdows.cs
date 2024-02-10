using UnityEngine;
using UnityEngine.SceneManagement;

public class CountActiveJackdows : MonoBehaviour
{
    [SerializeField] GameObject[] Jackdows;
    int count = 0;
   
    private void OnDestroy()
    {
        foreach (GameObject j in Jackdows)
        {
            if (j.activeSelf)
            {
                count += 1;
            }
        }
        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 7:
                CompleteTasks.Movement = count;
                Debug.Log(CompleteTasks.Movement);
                PlayerPrefs.SetInt("Movement", CompleteTasks.Movement);
                break;

            case 8:
                CompleteTasks.Mass = count;
                PlayerPrefs.SetInt("Mass", CompleteTasks.Mass);
                break;

            case 9:
                CompleteTasks.Force = count;
                PlayerPrefs.SetInt("Force", count);
                break;

            case 10:
                CompleteTasks.Pressure = count;
                PlayerPrefs.SetInt("Pressure", CompleteTasks.Pressure);
                break;

            case 11:
                CompleteTasks.Arbeit = count;
                PlayerPrefs.SetInt("Arbeit", CompleteTasks.Arbeit);
                break;
        }
        Debug.Log(CompleteTasks.Force);
    }
}
