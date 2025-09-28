using DG.Tweening;
using TMPro;
using UnityEngine;

public class CombatantView: MonoBehaviour
{
    [SerializeField] private TextMeshPro healthText;
    [SerializeField] private SpriteRenderer spriteRenderer;

    public int MaxHealth { get; private set; }
    public int CurrentHealth { get; private set; }

    protected void SetupBase(int health, Sprite Image)
    {
        MaxHealth = CurrentHealth = health;
        spriteRenderer.sprite = Image;
        UpdateHealthText();
    }

    protected void UpdateHealthText()
    {
        healthText.text = $"HP: {CurrentHealth}";
    }
    public void Damage (int dmgAmount)
    {
        CurrentHealth -= dmgAmount;
        if(CurrentHealth < 0)
        {
            CurrentHealth = 0;
        }
        transform.DOShakePosition(0.2f, 0.5f);
        UpdateHealthText();
    }
}
