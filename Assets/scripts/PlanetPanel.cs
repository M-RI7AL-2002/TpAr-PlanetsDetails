using UnityEngine;

public class PlanetInfoKey : MonoBehaviour
{
    public GameObject infoPanel;  // drag your info panel here
    public AudioSource audioSource; // optional, for narration

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))  // press 'I' key
        {
            if (infoPanel != null)
                infoPanel.SetActive(!infoPanel.activeSelf); // toggle panel

            if (audioSource != null)
                audioSource.Play();  // optional
        }
    }
}
