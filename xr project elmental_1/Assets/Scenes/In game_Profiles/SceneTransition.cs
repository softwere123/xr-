using UnityEngine;

public class SceneTransition : MonoBehaviour
{
    public GameObject uiElement; // 비활성화할 UI 요소를 가리키는 변수
    public float disableDelay = 10f; // UI 비활성화를 위한 대기 시간 (초)

    private float elapsedTime = 0f; // 경과한 시간을 저장하는 변수

    private void Update()
    {
        elapsedTime += Time.deltaTime; // 경과 시간을 누적합니다.

        // 경과 시간이 일정 시간을 초과하면 UI를 비활성화합니다.
        if (elapsedTime >= disableDelay)
        {
            uiElement.SetActive(false);
        }
    }
}