using UnityEngine;

public class PanelOfPause : MonoBehaviour
{
    [SerializeField] GameObject PausePanel;

    public void OpenPanelPause()
    {
        PausePanel.SetActive(true);
    }

    public void ClosePanelPause()
    {
        PausePanel.SetActive(false);
    }
}
