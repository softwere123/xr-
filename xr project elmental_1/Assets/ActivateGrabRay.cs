using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class ActivateGrabRay : MonoBehaviour
{
    // 그랩 이미지와 기능을 불러온다
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
        //  그랩기능불러온걸 홀딩하면  이미지를 비활성화 시킨다
        leftGrabRay.SetActive(leftDirectGrab.interactablesHovered.Count == 0);
        rightGrabRay.SetActive(rightDirectGrab.interactablesHovered.Count == 0);
    }
}
