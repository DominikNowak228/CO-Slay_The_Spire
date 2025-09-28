using System.Collections.Generic;
using UnityEngine;

public class MatchSetupSystem : MonoBehaviour
{
    [SerializeField] private HeroData heroData;
    [SerializeField] private PerkData perkData;
    [SerializeField] private List<EnemyData> enemyData;
    private void Start()
    {
        HeroSystem.Instance.Setup(heroData);
        CardSystem.Instance.Setup(heroData.Deck);
        EnemySystem.Instance.Setup(enemyData);
        PerkSystem.Instance.AddPerk(new Perk(perkData));
        DrawCardsGA drawCardsGA = new DrawCardsGA(5);
        ActionSystem.Instance.Perform(drawCardsGA);
    }
}
