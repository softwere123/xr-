using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController10 : MonoBehaviour
{
    public GameObject fireEffectPrefab; // �� ����Ʈ ������
    public Transform rightControllerTransform; // ������ ��Ʈ�ѷ��� ��ġ�� ��Ÿ���� Transform
    public GameObject treeObject; // ���� ������Ʈ

    private GameObject fireEffect; // �� ����Ʈ ������Ʈ
    private bool isBurning = false; // ������ �¿�� ������ ����

    private float fireDuration = 1f; // �� ����Ʈ ���� �ð�
    private float fireTimer = 0f; // �� ����Ʈ Ÿ�̸�

    private void Update()
    {
        if (isBurning)
        {
            // �� ����Ʈ Ÿ�̸� ������Ʈ
            fireTimer += Time.deltaTime;

            // �� ����Ʈ�� ���� �ð��� ������ ��������� ó��
            if (fireTimer >= fireDuration)
            {
                StopBurning();
            }
        }
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
            fireTimer = 0f; // �� ����Ʈ Ÿ�̸� �ʱ�ȭ
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == treeObject)
        {
            // VR ������ ��Ʈ�ѷ��� ���� ���� �浹�� �����Ͽ� ��Ÿ�� ����Ʈ ȣ��
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
