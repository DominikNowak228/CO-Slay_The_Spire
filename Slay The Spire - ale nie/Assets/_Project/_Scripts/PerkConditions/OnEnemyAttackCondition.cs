using System;
using UnityEngine;

public class OnEnemyAttackCondition : PerkCondition
{
    public override bool SubConditionIsMet(GameAction gameAction)
    {
        // if attacker is above x health
        return true;
    }

    public override void SubscribeContition(Action<GameAction> reaction)
    {
        ActionSystem.SubscribeReaction<AttackHeroGA>(reaction, reactionTiming);
    }

    public override void UnsubscribeContition(Action<GameAction> reaction)
    {
        ActionSystem.UnsubscribeReaction<AttackHeroGA>(reaction, reactionTiming);
    }
}
