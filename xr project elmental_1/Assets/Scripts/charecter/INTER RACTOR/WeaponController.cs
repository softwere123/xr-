using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using oculus;

public class WeaponController : MonoBehaviour
{
    private int elementIndex = 0; // 현재 선택된 공격 타입을 저장하는 변수
    private string[] elements = { "Fire", "Earth", "Water" }; // 공격 타입 리스트

    void Update()
    {
        // R버튼을 누르면 공격 타입이 바뀝니다.
        //if (OVRInput.GetDown(OVRInput.Button.One))
        //{
        //    elementIndex = (elementIndex + 1) % elements.Length;
        //    Debug.Log(elements[elementIndex] + " attack selected.");
        //}

        // 선택된 공격 타입에 따라 공격 코드 실행
        switch (elements[elementIndex])
        {
            case "Fire":
                // 불 속성 공격 코드 작성
                break;
            case "Earth":
                // 대지 속성 공격 코드 작성
                break;
            case "Water":
                // 물 속성 공격 코드 작성
                break;
            default:
                Debug.LogError("Invalid element selected.");
                break;
        }
    }
}
