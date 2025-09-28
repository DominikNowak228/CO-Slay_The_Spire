using System.Collections.Generic;
using UnityEngine;

public class DealDamageEffect : Effect
{
    [SerializeField] private int damageAmount;
    public override GameAction GetGameAciton(List<CombatantView> targets,CombatantView caster)
    {
        DealDamageGA dealDamageGA = new(damageAmount, targets, caster);
        return dealDamageGA;
    }
}
