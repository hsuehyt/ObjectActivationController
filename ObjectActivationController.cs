using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActivationController : MonoBehaviour
{
    [System.Serializable]
    public class ActivationSlot
    {
        public GameObject gameObject;
        public float activationDuration = 10f; // Default activation time
    }

    public List<ActivationSlot> activationSlots = new List<ActivationSlot>(); // List of objects
    private int currentIndex = 0;

    void Start()
    {
        if (activationSlots.Count > 0)
        {
            StartCoroutine(ActivationCycle());
        }
    }

    IEnumerator ActivationCycle()
    {
        while (true) // Infinite loop to keep cycling
        {
            if (activationSlots.Count == 0)
                yield break;

            // Deactivate all objects first
            DeactivateAllObjects();

            // Get the current slot
            ActivationSlot currentSlot = activationSlots[currentIndex];

            if (currentSlot.gameObject != null)
            {
                currentSlot.gameObject.SetActive(true);
                yield return new WaitForSeconds(currentSlot.activationDuration);
                currentSlot.gameObject.SetActive(false);
            }

            // Move to the next object in the list
            currentIndex = (currentIndex + 1) % activationSlots.Count;
        }
    }

    void DeactivateAllObjects()
    {
        foreach (var slot in activationSlots)
        {
            if (slot.gameObject != null)
            {
                slot.gameObject.SetActive(false);
            }
        }
    }
}
