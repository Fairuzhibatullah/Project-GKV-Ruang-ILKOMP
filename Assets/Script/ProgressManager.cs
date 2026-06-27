using UnityEngine;
using System.Collections;

public class ProgressManager : MonoBehaviour
{
    public GameObject progressPopup;

    public string locationID;

    void Start()
    {
        if (!PlayerPrefs.HasKey(locationID))
        {
            StartCoroutine(ShowPopup());

            PlayerPrefs.SetInt(locationID, 1);
            PlayerPrefs.Save();
        }
    }

    IEnumerator ShowPopup()
    {
        progressPopup.SetActive(true);

        yield return new WaitForSeconds(2f);

        progressPopup.SetActive(false);
    }
}