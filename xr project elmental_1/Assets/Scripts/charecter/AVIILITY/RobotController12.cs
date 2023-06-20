using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class RobotController12 : MonoBehaviour
{
    public class VRInteractableObject : MonoBehaviour, IInteractable
    {
        // �������̽� �޼��� ����
        public void OnHoverEnter(XRBaseInteractor interactor)
        {
            
        }

        public void OnHoverExit(XRBaseInteractor interactor)
        {
            // Hover ���� �� ������ ����
        }

        public void OnSelectEnter(XRBaseInteractor interactor)
        {
            // Select ���� �� ������ ����
        }

        public void OnSelectExit(XRBaseInteractor interactor)
        {
            // Select ���� �� ������ ����
        }

        // ��Ÿ �ʿ��� �޼��� �� ����
    }
    public GameObject fireEffectPrefab; // �� ����Ʈ ������
    public Transform rightControllerTransform; // ������ ��Ʈ�ѷ��� ��ġ�� ��Ÿ���� Transform
    public GameObject[] treeObjects; // ���� ������Ʈ���� ��� �迭

    private GameObject fireEffect; // �� ����Ʈ ������Ʈ
    private bool[] isBurning; // ������ �¿�� ������ ���θ� ��� �迭

    private float fireDuration = 1f; // �� ����Ʈ ���� �ð�
    private float[] fireTimers; // �� ����Ʈ Ÿ�̸Ӹ� ��� �迭

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
                // �� ����Ʈ Ÿ�̸� ������Ʈ
                fireTimers[i] += Time.deltaTime;

                // �� ����Ʈ�� ���� �ð��� ������ ��������� ó��
                if (fireTimers[i] >= fireDuration)
                {
                    StopBurning(i);
                }
            }
        }
    }

    // ���� ����
    private void ChangeElement(ElementType element)
    {
        // ���ҿ� ���� �κ��� ������ ����ǵ��� ����
        // ...

        if (element == ElementType.Fire)
        {
            // �ҿ����� ��� �� ����Ʈ ����
            fireEffect = Instantiate(fireEffectPrefab, rightControllerTransform);
            fireEffect.transform.localPosition = Vector3.zero;
            fireEffect.SetActive(false);
        }
        else
        {
            // �� ����Ʈ�� �����ϸ� ����
            if (fireEffect != null)
            {
                Destroy(fireEffect);
            }
        }
    }

    // ���� �¿�� ����
    private void StartBurning(int index)
    {
        if (!isBurning[index])
        {
            fireEffect.SetActive(true);
            // ������ �¿�� ���� �� ���� ����
            // ...

            isBurning[index] = true;
            fireTimers[index] = 0f; // �� ����Ʈ Ÿ�̸� �ʱ�ȭ
        }
    }

    // ���� �¿�� ����
    private void StopBurning(int index)
    {
        if (isBurning[index])
        {
            fireEffect.SetActive(false);
            // ������ �¿�� ���� �� ���� ����
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
                // VR ������ ��Ʈ�ѷ��� ���� ���� �浹�� �����Ͽ� ��Ÿ�� ����Ʈ ȣ��
                ChangeElement(ElementType.Fire);
                StartBurning(i);
            }
        }
    }

}