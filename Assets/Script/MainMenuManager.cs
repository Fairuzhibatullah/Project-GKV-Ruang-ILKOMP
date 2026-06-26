using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject mainMenuPanel;
    public GameObject helpPanel;
    public GameObject aboutPanel;

    // START TOUR
    public void StartTour()
    {
        SceneManager.LoadScene("KomlongScene");
        
    }

    // HELP
    public void OpenHelp()
    {
        helpPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
    }

    public void CloseHelp()
    {
        helpPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    // ABOUT
    public void OpenAbout()
    {
        aboutPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
    }

    public void CloseAbout()
    {
        aboutPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    // EXIT
    public void ExitApp()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}