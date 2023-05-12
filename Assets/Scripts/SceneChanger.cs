using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
/*    public short buttonType;

    public void press ()
    {
        switch(buttonType)
        {
            case 1:
                // aaa
                break;

            case 2:
                // bbb
                break;

            default:
                // ccc
                break;
        }
    }*/
    
    public void changeScene (int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }
}
