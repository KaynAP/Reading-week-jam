using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public CanvasGroup MainPanelGroup;

    public GameObject pauseMenuPanel;

    public GameObject pauseMenuUI;

    public GameObject SettingsMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuPanel.SetActive(false);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        MainPanelGroup.interactable = true;
        MainPanelGroup.blocksRaycasts = true;

    }

    public void Pause()
    {
        pauseMenuPanel.SetActive(true);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        MainPanelGroup.interactable = false;
        MainPanelGroup.blocksRaycasts = false;
    }

    public void SettingsMenu()
    {
        SettingsMenuUI.SetActive(true);
        pauseMenuUI.SetActive(false);
    }

    public void BackToPauseMenu()
    {
        SettingsMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);
    }
    public void QuitGame()
    {
        if (Application.isEditor)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
        {
            Application.Quit();
        }
    }
}
