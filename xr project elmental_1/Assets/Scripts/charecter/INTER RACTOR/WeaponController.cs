using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using oculus;

public class WeaponController : MonoBehaviour
{
    private int elementIndex = 0; // ���� ���õ� ���� Ÿ���� �����ϴ� ����
    private string[] elements = { "Fire", "Earth", "Water" }; // ���� Ÿ�� ����Ʈ

    void Update()
    {
        // R��ư�� ������ ���� Ÿ���� �ٲ�ϴ�.
        //if (OVRInput.GetDown(OVRInput.Button.One))
        //{
        //    elementIndex = (elementIndex + 1) % elements.Length;
        //    Debug.Log(elements[elementIndex] + " attack selected.");
        //}

        // ���õ� ���� Ÿ�Կ� ���� ���� �ڵ� ����
        switch (elements[elementIndex])
        {
            case "Fire":
                // �� �Ӽ� ���� �ڵ� �ۼ�
                break;
            case "Earth":
                // ���� �Ӽ� ���� �ڵ� �ۼ�
                break;
            case "Water":
                // �� �Ӽ� ���� �ڵ� �ۼ�
                break;
            default:
                Debug.LogError("Invalid element selected.");
                break;
        }
    }
}
