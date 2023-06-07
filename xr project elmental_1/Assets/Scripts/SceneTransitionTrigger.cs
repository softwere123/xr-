using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionTrigger : MonoBehaviour
{
    public string nextSceneName; // 다음으로 전환할 씬의 이름

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextSceneName); // 다음 씬으로 전환
        }
    }
}
