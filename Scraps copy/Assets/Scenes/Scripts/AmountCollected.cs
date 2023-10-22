using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmountCollected : MonoBehaviour
{
    private TextMeshProUGUI AmountText;
    void Start()
    {
       AmountText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateAmountText1(Inventory storage)
    {
        AmountText.text = storage.NumberofPickups.ToString();
    }
}
