using TMPro;
using UnityEngine;

public class EnemyView : CombatantView
{
    [SerializeField] protected TextMeshPro attackText;
    public int AttackPower { get; set; }
    public void Setup(EnemyData enemyData)
    {
        AttackPower = enemyData.AttackPower;
        UpdateAttackText();
        SetupBase(enemyData.Health,enemyData.Image);
    }
    protected void UpdateAttackText()
    {
        attackText.text = $"ATK: {AttackPower}";
    }
}
