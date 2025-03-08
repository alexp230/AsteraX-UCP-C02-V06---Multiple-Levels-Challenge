using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    [SerializeField] private Sprite PauseTexture;
    [SerializeField] private Sprite PlayTexture;
    [SerializeField] private Image CurrentTexture;

    public void OnPauseButton()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            CurrentTexture.sprite = PlayTexture;
        }
        else
        {
            Time.timeScale = 1;
            CurrentTexture.sprite = PauseTexture;
        }
    }
}
