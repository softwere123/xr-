using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRobot : MonoBehaviour
{
    public float detectionRange = 5f; // 플레이어 감지 범위
    public float attackRange = 2f; // 공격 범위
    public float moveSpeed = 3f; // 로봇 이동 속도

    private Transform player; // 플레이어의 Transform 컴포넌트
    private bool isPlayerInRange = false; // 플레이어가 감지 범위 내에 있는지 여부

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // "Player" 태그를 가진 오브젝트의 Transform 컴포넌트를 가져옴
    }

    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // 플레이어가 감지 범위 내에 있을 때
        if (distanceToPlayer <= detectionRange)
        {
            isPlayerInRange = true;

            // 플레이어와의 거리가 공격 범위보다 작을 때 플레이어를 공격
            if (distanceToPlayer <= attackRange)
            {
                AttackPlayer();
            }
            else
            {
                // 플레이어를 향해 이동
                MoveTowardsPlayer();
            }
        }
        else
        {
            isPlayerInRange = false;
            // 로봇의 다른 동작 및 이동 로직 구현
            // ...
        }
    }

    private void MoveTowardsPlayer()
    {
        // 플레이어와의 거리 계산
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // 일정 거리보다 가까우면 이동하지 않음
        if (distanceToPlayer > detectionRange - 1f)
        {
            return;
        }

        // 플레이어의 방향으로 이동
        Vector3 direction = (player.position - transform.position).normalized;
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
    private void AttackPlayer()
    {
        // 플레이어를 공격하는 로직 구현
        // ...

        // 예시: 공격 시 플레이어에게 데미지를 입히는 코드
        PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(10); // 10의 데미지를 입힘
        }
    }
}