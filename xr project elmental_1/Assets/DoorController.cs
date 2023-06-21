using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door; // 비활성화할 문 게임 오브젝트

    private void Update()
    {
        // 특정 몬스터들이 모두 사라졌을 때 문을 비활성화
        if (AreMonstersGone())
        {
            door.SetActive(false);
        }
    }

    private bool AreMonstersGone()
    {
        // 특정 몬스터들이 씬에 남아 있는지 검사
        GameObject[] monsters = GameObject.FindGameObjectsWithTag("Monster");

        foreach (GameObject monster in monsters)
        {
            // 몬스터가 아직 활성화된 상태인지 확인
            if (monster.activeSelf)
            {
                return false; // 하나라도 활성화된 몬스터가 있다면 문은 비활성화되지 않음
            }
        }

        return true; // 모든 몬스터들이 비활성화된 상태임을 의미
    }
}