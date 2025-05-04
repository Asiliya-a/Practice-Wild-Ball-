using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public void PressButtonChooseLevel(int level)
    {
        SceneManager.LoadScene(level);
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
