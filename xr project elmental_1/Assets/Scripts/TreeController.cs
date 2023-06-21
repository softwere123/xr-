using UnityEngine;
using System.Collections;

public class TreeController : MonoBehaviour
{
    private bool collided = false;
    private float colliderDisableDelay = 1f; // �ݶ��̴��� ��Ȱ��ȭ�� ������ �ð�

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball") && !collided)
        {
            collided = true;
            Rigidbody treeRigidbody = GetComponent<Rigidbody>();
            if (treeRigidbody != null)
            {
                Vector3 force = new Vector3(0f, 0f, 1f);
                float torque = 500f;
                treeRigidbody.AddForce(force * torque);
            }

            // ���� �ð� �� �ݶ��̴� ��Ȱ��ȭ
            StartCoroutine(DisableCollider());
        }
    }

    private IEnumerator DisableCollider()
    {
        yield return new WaitForSeconds(colliderDisableDelay);

        Collider treeCollider = GetComponent<Collider>();
        if (treeCollider != null)
        {
            treeCollider.enabled = false;
        }
    }
}