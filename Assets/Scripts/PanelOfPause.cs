using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelOfPause : MonoBehaviour
{
    [SerializeField] GameObject Panel_of_pause;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Pause()
    {
        Panel_of_pause.SetActive(true);
    }

    public void RestartCurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackInMenu()
    {
        SceneManager.LoadScene(0);
    }
}
