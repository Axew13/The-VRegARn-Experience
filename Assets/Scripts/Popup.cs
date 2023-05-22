using UnityEngine;

public class Popup : MonoBehaviour
{
    public void ClosePopup ()
    {
        this.gameObject.SetActive(false);
    }

    public void OpenUrl (string url)
    {
        Application.OpenURL(url);
    }
}
