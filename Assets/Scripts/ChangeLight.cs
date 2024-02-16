using UnityEngine;

public class ChangeLight : MonoBehaviour
{
    private Light[] light;
    private int quality = 1;

    private void Start()
    {
        quality = PlayerPrefs.HasKey("Quality") ? PlayerPrefs.GetInt("Quality") : 1;
        light = FindObjectsOfType<Light>();
        if (quality == 0)
        {
            foreach (Light light in light)
            {
                light.renderMode = LightRenderMode.ForceVertex;
            }
        }
    }
}
