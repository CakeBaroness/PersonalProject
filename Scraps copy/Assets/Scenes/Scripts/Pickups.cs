using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Pickup : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Inventory storage = other.GetComponent<Inventory>();

        if (storage != null)
        {
            storage.PickupsCollected();
            gameObject.SetActive(false);
        }
    }

}
