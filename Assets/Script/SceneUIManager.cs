using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneUIManager : MonoBehaviour
{
    public void GoHome()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void GoToDepanFMIPA()
    {
        SceneManager.LoadScene("DepanFMIPAScene");
    }

    public void GoToGC()
    {
        SceneManager.LoadScene("GoldenCornerScene");
    }

    public void GoToKomlong()
    {
        SceneManager.LoadScene("KomlongScene");
    }

    public void GoToLab1()
    {
        SceneManager.LoadScene("Lab1Scene");
    }

    public void GoToLab2()
    {
        SceneManager.LoadScene("Lab2Scene");
    }

    public void GoToLab3()
    {
        SceneManager.LoadScene("Lab3Scene");
    }
}