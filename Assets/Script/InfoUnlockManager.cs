using UnityEngine;

public class InfoUnlockManager : MonoBehaviour
{
    public GameObject nextButton;

    public string locationID;

    void Start()
    {
        if(PlayerPrefs.HasKey(locationID + "_InfoRead"))
        {
            nextButton.SetActive(true);
        }
        else
        {
            nextButton.SetActive(false);
        }
    }

    public void UnlockNext()
    {
        PlayerPrefs.SetInt(locationID + "_InfoRead", 1);
        PlayerPrefs.Save();

        nextButton.SetActive(true);
    }
}