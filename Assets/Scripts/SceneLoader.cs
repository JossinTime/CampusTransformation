using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;
public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

    }

    [YarnCommand("loadScene")]
    public void LoadSceneByName(string sceneName)
    {
        if (Application.CanStreamedLevelBeLoaded(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogWarning($"Scene '{sceneName}' cannot be loaded. Make sure it's added to the Build Settings.");
        }
    }
}
