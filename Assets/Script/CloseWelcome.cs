using UnityEngine;

public class PopupManager : MonoBehaviour
{
    public GameObject WelcomePopup;

    public void CloseWelcome()
    {
        WelcomePopup.SetActive(false);
    }
}