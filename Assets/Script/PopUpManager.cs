using UnityEngine;

public class PopupManager : MonoBehaviour
{
    public GameObject mapPopup;
    public GameObject infoPopup;

    public void OpenMap()
    {
        mapPopup.SetActive(true);
    }

    public void CloseMap()
    {
        mapPopup.SetActive(false);
    }

    public void OpenInfo()
    {
        infoPopup.SetActive(true);
    }

    public void CloseInfo()
    {
        infoPopup.SetActive(false);
    }
}