using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    private Collider ballCollider;
    private float colliderDisableDelay = 1f; // 콜라이더를 비활성화할 딜레이 시간

    private void Start()
    {
        ballCollider = GetComponent<Collider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tree"))
        {
            // 일정 시간 후 콜라이더 비활성화
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