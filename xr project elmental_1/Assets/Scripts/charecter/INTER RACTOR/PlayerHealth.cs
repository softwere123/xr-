using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth = 100;
    public Text healthText;

    // 체력 값 변경시 호출될 메서드
    public void UpdateHealth()
    {
        healthText.text = "HP: " + currentHealth.ToString();
    }

    // 체력 감소 메서드 예시
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        UpdateHealth();
    }
}