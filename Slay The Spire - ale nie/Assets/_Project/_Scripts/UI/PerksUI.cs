using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PerksUI : MonoBehaviour
{
    [SerializeField] private PerkUI perkUIPrefab;
    private readonly List<PerkUI> perksUIs = new();

    public void AddPerkUI(Perk perk)
    {
        PerkUI perkUI = Instantiate(perkUIPrefab, transform);
        perkUI.Setup(perk);
        perksUIs.Add(perkUI);
    }
    public void RemovePerkUI(Perk perk)
    {
        PerkUI perkUI = perksUIs.Where(p => p.Perk == perk).FirstOrDefault();
        if(perkUI != null)
        {
            perksUIs.Remove(perkUI);
            Destroy(perkUI.gameObject);
        }
    }
}
