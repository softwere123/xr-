using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRobot : MonoBehaviour
{
    public float detectionRange = 5f; // �÷��̾� ���� ����
    public float attackRange = 2f; // ���� ����
    public float moveSpeed = 3f; // �κ� �̵� �ӵ�

    private Transform player; // �÷��̾��� Transform ������Ʈ
    private bool isPlayerInRange = false; // �÷��̾ ���� ���� ���� �ִ��� ����

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // "Player" �±׸� ���� ������Ʈ�� Transform ������Ʈ�� ������
    }

    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // �÷��̾ ���� ���� ���� ���� ��
        if (distanceToPlayer <= detectionRange)
        {
            isPlayerInRange = true;

            // �÷��̾���� �Ÿ��� ���� �������� ���� �� �÷��̾ ����
            if (distanceToPlayer <= attackRange)
            {
                AttackPlayer();
            }
            else
            {
                // �÷��̾ ���� �̵�
                MoveTowardsPlayer();
            }
        }
        else
        {
            isPlayerInRange = false;
            // �κ��� �ٸ� ���� �� �̵� ���� ����
            // ...
        }
    }

    private void MoveTowardsPlayer()
    {
        // �÷��̾���� �Ÿ� ���
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // ���� �Ÿ����� ������ �̵����� ����
        if (distanceToPlayer > detectionRange - 1f)
        {
            return;
        }

        // �÷��̾��� �������� �̵�
        Vector3 direction = (player.position - transform.position).normalized;
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
    private void AttackPlayer()
    {
        // �÷��̾ �����ϴ� ���� ����
        // ...

        // ����: ���� �� �÷��̾�� �������� ������ �ڵ�
        PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(10); // 10�� �������� ����
        }
    }
}