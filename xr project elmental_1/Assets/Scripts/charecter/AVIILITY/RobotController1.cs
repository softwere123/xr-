using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    public GameObject fireEffectPrefab; // �� ����Ʈ ������
    public Transform rightControllerTransform; // ������ ��Ʈ�ѷ��� ��ġ�� ��Ÿ���� Transform

    private GameObject fireEffect; // �� ����Ʈ ������Ʈ
    private bool isBurning = false; // ������ �¿�� ������ ����

    private void Update()
    {
        // R ��ư�� ������ �� �ҿ��ҷ� ���� �� ���� �¿��
        //if (OVRInput.GetDown(OVRInput.Button.One))
        //{
        //    ChangeElement(ElementType.Fire);
        //    StartBurning();
        //}
    }

    // ���� ����
    private void ChangeElement(ElementType element)
    {
        // ���ҿ� ���� �κ��� ������ ����ǵ��� ����
        // ...

        // �ҿ����� ��� �� ����Ʈ ����
        if (element == ElementType.Fire)
        {
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
    private void StartBurning()
    {
        if (!isBurning)
        {
            fireEffect.SetActive(true);
            // ������ �¿�� ���� �� ���� ����
            // ...
            isBurning = true;
        }
    }

    // ���� �¿�� ����
    private void StopBurning()
    {
        if (isBurning)
        {
            fireEffect.SetActive(false);
            // ������ �¿�� ���� �� ���� ����
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