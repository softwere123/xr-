using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController10 : MonoBehaviour
{
    public GameObject fireEffectPrefab; // 불 이펙트 프리팹
    public Transform rightControllerTransform; // 오른쪽 컨트롤러의 위치를 나타내는 Transform
    public GameObject treeObject; // 나무 오브젝트

    private GameObject fireEffect; // 불 이펙트 오브젝트
    private bool isBurning = false; // 나무를 태우는 중인지 여부

    private float fireDuration = 1f; // 불 이펙트 지속 시간
    private float fireTimer = 0f; // 불 이펙트 타이머

    private void Update()
    {
        if (isBurning)
        {
            // 불 이펙트 타이머 업데이트
            fireTimer += Time.deltaTime;

            // 불 이펙트가 일정 시간이 지나면 사라지도록 처리
            if (fireTimer >= fireDuration)
            {
                StopBurning();
            }
        }
    }

    // 원소 변경
    private void ChangeElement(ElementType element)
    {
        // 원소에 따라 로봇의 외형이 변경되도록 구현
        // ...

        // 불원소일 경우 불 이펙트 생성
        if (element == ElementType.Fire)
        {
            fireEffect = Instantiate(fireEffectPrefab, rightControllerTransform);
            fireEffect.transform.localPosition = Vector3.zero;
            fireEffect.SetActive(false);
        }
        else
        {
            // 불 이펙트가 존재하면 제거
            if (fireEffect != null)
            {
                Destroy(fireEffect);
            }
        }
    }

    // 나무 태우기 시작
    private void StartBurning()
    {
        if (!isBurning)
        {
            fireEffect.SetActive(true);
            // 나무를 태우는 동작 및 로직 구현
            // ...

            isBurning = true;
            fireTimer = 0f; // 불 이펙트 타이머 초기화
        }
    }

    // 나무 태우기 중지
    private void StopBurning()
    {
        if (isBurning)
        {

            fireEffect.SetActive(false);
            // 나무를 태우는 동작 및 로직 중지
            // ...

            isBurning = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == treeObject)
        {
            // VR 오른쪽 컨트롤러와 나무 간의 충돌을 감지하여 불타는 이펙트 호출
            ChangeElement(ElementType.Fire);
            StartBurning();
        }
    }


}

public enum ElementTyped
{
    Earth,
    Fire,
    Water,
}
