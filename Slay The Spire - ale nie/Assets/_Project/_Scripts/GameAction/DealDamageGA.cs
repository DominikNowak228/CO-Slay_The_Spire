using System.Collections.Generic;
using UnityEngine;

public class DealDamageGA : GameAction, IHaveCaster
{
    public int Amount { get; set; }
    public List<CombatantView> Targests { get; set; }

    public CombatantView Caster { get; private set; }

    public DealDamageGA(int amount, List<CombatantView> targests, CombatantView caster)
    {
        Amount = amount;
        Targests = targests;
        Caster = caster;
    }
}
