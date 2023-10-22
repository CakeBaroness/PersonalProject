using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Inventory : MonoBehaviour
{
    public int NumberofPickups { get; private set; }
    public int maxPickups;
    public GameObject Objective1;
    public GameObject ObjectiveChangeText;


    public UnityEvent<Inventory> OnPickupCollected;
 

    private void Start()
    {
        NumberofPickups = 0;
        Objective1.SetActive(true);
        ObjectiveChangeText.SetActive(false);
    }

    public void PickupsCollected()
    {
        NumberofPickups++;
        OnPickupCollected.Invoke(this);

    if (NumberofPickups == maxPickups)
        {
            Objective1.SetActive(false);
            ObjectiveChangeText.SetActive(true);
        }
            

    }
}
