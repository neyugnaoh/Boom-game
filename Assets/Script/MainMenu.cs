using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private bool optionPanelStatus = false;
    public GameObject optionPanel;
    public GameObject mainMenuPanel;

    public void startClicked()
    {
        SceneManager.LoadScene(4);
    }

    public void quitClicked()
    {
        Application.Quit();
    }

    public void optionClicked()
    {
        mainMenuPanel.SetActive(optionPanelStatus);
        optionPanelStatus = !optionPanelStatus;
        optionPanel.SetActive(optionPanelStatus);
    }
}
