using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    private Collider ballCollider;
    private float colliderDisableDelay = 1f; // �ݶ��̴��� ��Ȱ��ȭ�� ������ �ð�

    private void Start()
    {
        ballCollider = GetComponent<Collider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tree"))
        {
            // ���� �ð� �� �ݶ��̴� ��Ȱ��ȭ
            StartCoroutine(DisableCollider());
        }
    }

    private IEnumerator DisableCollider()
    {
        yield return new WaitForSeconds(colliderDisableDelay);

        if (ballCollider != null)
        {
            ballCollider.enabled = false;
        }
    }
}