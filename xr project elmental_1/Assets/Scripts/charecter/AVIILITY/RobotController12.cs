using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class RobotController12 : MonoBehaviour
{
    public class VRInteractableObject : MonoBehaviour, IInteractable
    {
        // 인터페이스 메서드 구현
        public void OnHoverEnter(XRBaseInteractor interactor)
        {
            
        }

        public void OnHoverExit(XRBaseInteractor interactor)
        {
            // Hover 종료 시 수행할 동작
        }

        public void OnSelectEnter(XRBaseInteractor interactor)
        {
            // Select 진입 시 수행할 동작
        }

        public void OnSelectExit(XRBaseInteractor interactor)
        {
            // Select 종료 시 수행할 동작
        }

        // 기타 필요한 메서드 및 변수
    }
    public GameObject fireEffectPrefab; // 불 이펙트 프리팹
    public Transform rightControllerTransform; // 오른쪽 컨트롤러의 위치를 나타내는 Transform
    public GameObject[] treeObjects; // 나무 오브젝트들을 담는 배열

    private GameObject fireEffect; // 불 이펙트 오브젝트
    private bool[] isBurning; // 나무를 태우는 중인지 여부를 담는 배열

    private float fireDuration = 1f; // 불 이펙트 지속 시간
    private float[] fireTimers; // 불 이펙트 타이머를 담는 배열

    private void Start()
    {
        int treeCount = treeObjects.Length;
        isBurning = new bool[treeCount];
        fireTimers = new float[treeCount];
    }

        
    private void Update()
    {
        for (int i = 0; i < treeObjects.Length; i++)
        {
            if (isBurning[i])
            {
                // 불 이펙트 타이머 업데이트
                fireTimers[i] += Time.deltaTime;

                // 불 이펙트가 일정 시간이 지나면 사라지도록 처리
                if (fireTimers[i] >= fireDuration)
                {
                    StopBurning(i);
                }
            }
        }
    }

    // 원소 변경
    private void ChangeElement(ElementType element)
    {
        // 원소에 따라 로봇의 외형이 변경되도록 구현
        // ...

        if (element == ElementType.Fire)
        {
            // 불원소일 경우 불 이펙트 생성
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
    private void StartBurning(int index)
    {
        if (!isBurning[index])
        {
            fireEffect.SetActive(true);
            // 나무를 태우는 동작 및 로직 구현
            // ...

            isBurning[index] = true;
            fireTimers[index] = 0f; // 불 이펙트 타이머 초기화
        }
    }

    // 나무 태우기 중지
    private void StopBurning(int index)
    {
        if (isBurning[index])
        {
            fireEffect.SetActive(false);
            // 나무를 태우는 동작 및 로직 중지
            // ...

            isBurning[index] = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < treeObjects.Length; i++)
        {
            if (other.gameObject == treeObjects[i])
            {
                // VR 오른쪽 컨트롤러와 나무 간의 충돌을 감지하여 불타는 이펙트 호출
                ChangeElement(ElementType.Fire);
                StartBurning(i);
            }
        }
    }

}