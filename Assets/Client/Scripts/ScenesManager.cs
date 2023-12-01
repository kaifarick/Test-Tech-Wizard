

using UnityEngine.SceneManagement;

public static class ScenesManager
{

    public static void LoadScene(ScenesName sceneName)
    {
        SceneManager.LoadScene(sceneName.ToString());
    }
    
    public static void UnloadScene(ScenesName sceneName)
    {
        SceneManager.UnloadSceneAsync(sceneName.ToString());
    }
    
    public enum ScenesName
    {
        ClientScene,
        ServerScene,
        StartHubScene
    }
}
