using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    public GameObject fireEffectPrefab; // 불 이펙트 프리팹
    public Transform rightControllerTransform; // 오른쪽 컨트롤러의 위치를 나타내는 Transform

    private GameObject fireEffect; // 불 이펙트 오브젝트
    private bool isBurning = false; // 나무를 태우는 중인지 여부

    private void Update()
    {
        // R 버튼을 눌렀을 때 불원소로 변경 및 나무 태우기
        //if (OVRInput.GetDown(OVRInput.Button.One))
        //{
        //    ChangeElement(ElementType.Fire);
        //    StartBurning();
        //}
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
}

public enum ElementType
{
    Earth,
    Fire,
    Water,
}