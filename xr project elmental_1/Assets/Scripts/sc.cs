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
        int length = text.Length; // 문자열의 길이를 반환
        string subtext = text.Substring(10, 6); // 문자열에서 일부분을 추출
        int index = text.IndexOf("sample"); // "sample"이라는 문자열의 위치를 찾음

        Debug.Log(length); // 길이를 출력
        Debug.Log(subtext); // 일부분을 출력
        Debug.Log(index);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
