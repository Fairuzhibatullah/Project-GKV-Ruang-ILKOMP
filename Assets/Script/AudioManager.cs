using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;

    public Image soundButtonImage;

    public Sprite soundOnSprite;
    public Sprite soundOffSprite;

    public void ToggleSound()
    {
        audioSource.mute = !audioSource.mute;

        if(audioSource.mute)
        {
            soundButtonImage.sprite = soundOffSprite;
        }
        else
        {
            soundButtonImage.sprite = soundOnSprite;
        }
    }
}