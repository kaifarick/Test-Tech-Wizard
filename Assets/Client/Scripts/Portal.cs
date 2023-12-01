using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Player>(out Player player))
        {
            ScenesManager.LoadScene(ScenesManager.ScenesName.ClientScene);
            ScenesManager.UnloadScene(ScenesManager.ScenesName.StartHubScene);
        }
    }
}
