using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class sc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string text = "This is a sample text.";
        int length = text.Length; // ���ڿ��� ���̸� ��ȯ
        string subtext = text.Substring(10, 6); // ���ڿ����� �Ϻκ��� ����
        int index = text.IndexOf("sample"); // "sample"�̶�� ���ڿ��� ��ġ�� ã��

        Debug.Log(length); // ���̸� ���
        Debug.Log(subtext); // �Ϻκ��� ���
        Debug.Log(index);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
