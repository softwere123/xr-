using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class asd : MonoBehaviour
{
    int sum;
    // Start is called before the first frame update
    void Start()
    {
        int[] arr = new int[2];



        string[] myArray = { "a", "b" };
        for (int i = 0; i > myArray.Length; i++)
        {
            do
            {


                Console.Write(myArray[i] + "�� ������ �Է��ϼ���: ");

            } while (!int.TryParse(Console.ReadLine(), out arr[i]));
        }
        int sum = arr[0] + arr[1];
        Console.Write("�μ��� ����" + sum + "�Դϴ�");

    }
}

    // Update is called once per frame
