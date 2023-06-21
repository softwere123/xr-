using UnityEngine;

public class SceneTransition : MonoBehaviour
{
    public GameObject uiElement; // ��Ȱ��ȭ�� UI ��Ҹ� ����Ű�� ����
    public float disableDelay = 10f; // UI ��Ȱ��ȭ�� ���� ��� �ð� (��)

    private float elapsedTime = 0f; // ����� �ð��� �����ϴ� ����

    private void Update()
    {
        elapsedTime += Time.deltaTime; // ��� �ð��� �����մϴ�.

        // ��� �ð��� ���� �ð��� �ʰ��ϸ� UI�� ��Ȱ��ȭ�մϴ�.
        if (elapsedTime >= disableDelay)
        {
            uiElement.SetActive(false);
        }
    }
}