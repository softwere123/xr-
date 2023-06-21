using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class ActivateGrabRay : MonoBehaviour
{
    // �׷� �̹����� ����� �ҷ��´�
    public GameObject leftGrabRay;
    public GameObject rightGrabRay;

    public XRDirectInteractor leftDirectGrab;
    public XRDirectInteractor rightDirectGrab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //  �׷���ɺҷ��°� Ȧ���ϸ�  �̹����� ��Ȱ��ȭ ��Ų��
        leftGrabRay.SetActive(leftDirectGrab.interactablesHovered.Count == 0);
        rightGrabRay.SetActive(rightDirectGrab.interactablesHovered.Count == 0);
    }
}
