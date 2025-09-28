using System;
using UnityEngine;

public abstract class PerkCondition
{
    [SerializeField] protected ReactionTiming reactionTiming;
    public abstract void SubscribeContition(Action<GameAction> reaction);
    public abstract void UnsubscribeContition(Action<GameAction> reaction);
    public abstract bool SubConditionIsMet(GameAction gameAction);
}
