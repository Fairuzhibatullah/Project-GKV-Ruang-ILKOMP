using UnityEngine;

public class MapManager : MonoBehaviour
{
    public GameObject mapPopup;

    public void OpenMap()
    {
        mapPopup.SetActive(true);
    }

    public void CloseMap()
    {
        mapPopup.SetActive(false);
    }
}