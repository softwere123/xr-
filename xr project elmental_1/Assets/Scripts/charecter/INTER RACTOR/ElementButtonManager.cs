using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;

public class ElementButtonManager : MonoBehaviour
{
    public GameObject[] elementButtons; // 원소 버튼들의 배열
    public Material[] elementMaterials; // 원소에 대응하는 재질들의 배열

    private int currentElementIndex = 0; // 현재 선택된 원소의 인덱스
    public Button[] Buttons;


    private void Start()
    {
        // 초기 원소 설정
        SetCurrentElement(currentElementIndex);
    }

    private void Update()
    {
        // Oculus Rift 컨트롤러의 R 버튼이 눌렸을 때 원소 변경 처리
        if (Input.GetKeyDown(KeyCode.JoystickButton5) || Input.GetKeyDown(KeyCode.JoystickButton4))
        {
            ChangeElement();
        }
    }

    private void ChangeElement()
    {
        // 다음 원소 인덱스로 변경
        currentElementIndex++;
        if (currentElementIndex >= elementButtons.Length)
        {
            currentElementIndex = 0;
        }

        // 현재 선택된 원소 설정
        SetCurrentElement(currentElementIndex);
    }

    private void SetCurrentElement(int index)
    {
        // 모든 원소 버튼 비활성화
        foreach (GameObject button in elementButtons)
        {
            button.SetActive(false);
        }

        // 현재 선택된 원소 버튼 활성화
        elementButtons[index].SetActive(true);

        // 원소에 대응하는 재질을 적용
        //Renderer playerRenderer = GetComponent<Renderer>();
        //playerRenderer.material = elementMaterials[index];


    }

    private void UpdateButtonsVisibility()
    {
        foreach (Button button in Buttons)
        {
            button.gameObject.SetActive(true);
        }
    }
}