using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class measurement : MonoBehaviour
{
    private Renderer objectRenderer;

    // Start 함수에서 초기화
    private void Start()
    {
        // Renderer 컴포넌트 가져오기
        objectRenderer = GetComponent<Renderer>();

        // 크기 측정 함수 호출
        MeasureSize();
    }

    // 게임 오브젝트의 크기를 측정하는 함수
    private void MeasureSize()
    {
        // 게임 오브젝트의 바운딩 박스 정보 가져오기
        Bounds bounds = objectRenderer.bounds;

        // 바운딩 박스의 크기 출력
        Debug.Log("게임 오브젝트의 크기: " + bounds.size);
    }
}
