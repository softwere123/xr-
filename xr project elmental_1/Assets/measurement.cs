using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class measurement : MonoBehaviour
{
    private Renderer objectRenderer;

    // Start �Լ����� �ʱ�ȭ
    private void Start()
    {
        // Renderer ������Ʈ ��������
        objectRenderer = GetComponent<Renderer>();

        // ũ�� ���� �Լ� ȣ��
        MeasureSize();
    }

    // ���� ������Ʈ�� ũ�⸦ �����ϴ� �Լ�
    private void MeasureSize()
    {
        // ���� ������Ʈ�� �ٿ�� �ڽ� ���� ��������
        Bounds bounds = objectRenderer.bounds;

        // �ٿ�� �ڽ��� ũ�� ���
        Debug.Log("���� ������Ʈ�� ũ��: " + bounds.size);
    }
}
