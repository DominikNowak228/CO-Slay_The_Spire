using TMPro;
using UnityEngine;

public class ManaUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI manaText;
    
    public void UpdataManaText(int currentMana)
    {
        manaText.text = currentMana.ToString();
    }
}
