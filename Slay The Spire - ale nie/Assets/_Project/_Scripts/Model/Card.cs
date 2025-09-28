using System.Collections.Generic;
using UnityEngine;

public class Card 
{
    public string Title => data.name;
    public string Description => data.Description;
    public Sprite Image => data.Image;
    public int Mana { get; private set; }
    public Effect ManualTargetEffects => data.ManualTargetEffect;
    public List<AutoTargetEffect> OtherEffects => data.OtherEffects;

    private readonly CardData data;

    public Card(CardData cardData)
    {
        this.data = cardData;
        Mana = cardData.Mana;
    }
}
