using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth = 100;
    public Text healthText;

    // ü�� �� ����� ȣ��� �޼���
    public void UpdateHealth()
    {
        healthText.text = "HP: " + currentHealth.ToString();
    }

    // ü�� ���� �޼��� ����
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        UpdateHealth();
    }
}