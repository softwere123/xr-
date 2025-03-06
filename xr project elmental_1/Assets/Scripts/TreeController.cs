using UnityEngine;
using System.Collections;

public class TreeController : MonoBehaviour
{
    private bool collided = false;
    private float colliderDisableDelay = 1f; // 콜라이더를 비활성화할 딜레이 시간

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

            // 일정 시간 후 콜라이더 비활성화
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