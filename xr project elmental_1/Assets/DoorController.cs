using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door; // ��Ȱ��ȭ�� �� ���� ������Ʈ

    private void Update()
    {
        // Ư�� ���͵��� ��� ������� �� ���� ��Ȱ��ȭ
        if (AreMonstersGone())
        {
            door.SetActive(false);
        }
    }

    private bool AreMonstersGone()
    {
        // Ư�� ���͵��� ���� ���� �ִ��� �˻�
        GameObject[] monsters = GameObject.FindGameObjectsWithTag("Monster");

        foreach (GameObject monster in monsters)
        {
            // ���Ͱ� ���� Ȱ��ȭ�� �������� Ȯ��
            if (monster.activeSelf)
            {
                return false; // �ϳ��� Ȱ��ȭ�� ���Ͱ� �ִٸ� ���� ��Ȱ��ȭ���� ����
            }
        }

        return true; // ��� ���͵��� ��Ȱ��ȭ�� �������� �ǹ�
    }
}