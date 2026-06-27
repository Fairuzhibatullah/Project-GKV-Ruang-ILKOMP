using UnityEngine;

public class MapManager : MonoBehaviour
{
    [System.Serializable]
    public class LocationUI
    {
        public string locationID;

        public GameObject button;
        public GameObject lockIcon;
    }

    public LocationUI[] locations;

    void Start()
    {
        foreach(LocationUI loc in locations)
        {
            if(PlayerPrefs.HasKey(loc.locationID))
            {
                loc.button.SetActive(true);
                loc.lockIcon.SetActive(false);
            }
            else
            {
                loc.button.SetActive(false);
                loc.lockIcon.SetActive(true);
            }
        }
    }
}