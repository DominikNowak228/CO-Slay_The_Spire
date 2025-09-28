using System.Collections.Generic;

[System.Serializable]
public abstract class Effect 
{
    public abstract GameAction GetGameAciton(List<CombatantView>targets, CombatantView caster);
}
