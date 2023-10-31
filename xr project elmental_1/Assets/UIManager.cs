using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image uiImage; // UI 이미지를 Inspector에서 할당합니다.

    // UI 버튼 클릭 시 실행될 함수
    public void ChangeImageOnClick()
    {
        // UI 이미지의 스프라이트를 원하는 이미지로 변경합니다.
        // uiImage.sprite = yourNewSprite; // 'yourNewSprite'를 실제 이미지로 변경하세요.
    }
}