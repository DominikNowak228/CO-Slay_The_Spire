using System.Collections.Generic;
using UnityEngine;

public class AllEnemiesTM : TargetMode
{
    public override List<CombatantView> GetTargets()
    {
        return new(EnemySystem.Instance.Enemies);
    }
}

public class RandomEnemiesTM : TargetMode
{
    public override List<CombatantView> GetTargets()
    {
        CombatantView target = EnemySystem.Instance.Enemies[Random.RandomRange(0, EnemySystem.Instance.Enemies.Count)];
        return new() { target };
    }
}

public class NoTM : TargetMode
{
    public override List<CombatantView> GetTargets()
    {
        return null;
    }
}
