using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayLevel : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PressButtonChooseLevel_1()
    {
        SceneManager.LoadScene(1);
    }

    public void PressButtonChooseLevel_2()
    { 
        SceneManager.LoadScene(2);
    }

    public void PressButtonChooseLevel_3()
    {
        SceneManager.LoadScene(3);
    }

    public void PressButtonChooseLevel_4()
    {
        SceneManager.LoadScene(4);
    }

    public void PressButtonChooseLevel_5()
    {
        SceneManager.LoadScene(5);
    }

    public void PressButtonChooseLevel_6()
    {
        SceneManager.LoadScene(6);
    }
}
