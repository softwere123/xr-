using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;

public class ElementButtonManager : MonoBehaviour
{
    public GameObject[] elementButtons; // ���� ��ư���� �迭
    public Material[] elementMaterials; // ���ҿ� �����ϴ� �������� �迭

    private int currentElementIndex = 0; // ���� ���õ� ������ �ε���
    public Button[] Buttons;


    private void Start()
    {
        // �ʱ� ���� ����
        SetCurrentElement(currentElementIndex);
    }

    private void Update()
    {
        // Oculus Rift ��Ʈ�ѷ��� R ��ư�� ������ �� ���� ���� ó��
        if (Input.GetKeyDown(KeyCode.JoystickButton5) || Input.GetKeyDown(KeyCode.JoystickButton4))
        {
            ChangeElement();
        }
    }

    private void ChangeElement()
    {
        // ���� ���� �ε����� ����
        currentElementIndex++;
        if (currentElementIndex >= elementButtons.Length)
        {
            currentElementIndex = 0;
        }

        // ���� ���õ� ���� ����
        SetCurrentElement(currentElementIndex);
    }

    private void SetCurrentElement(int index)
    {
        // ��� ���� ��ư ��Ȱ��ȭ
        foreach (GameObject button in elementButtons)
        {
            button.SetActive(false);
        }

        // ���� ���õ� ���� ��ư Ȱ��ȭ
        elementButtons[index].SetActive(true);

        // ���ҿ� �����ϴ� ������ ����
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