using UnityEngine;
using System.Collections.Generic;

public class TestCaseScript : MonoBehaviour
{
    // List of facets
    public List<Facet> facets = new List<Facet>();
    
    // Reference to the timer script
    private NewMonoBehaviourScript timerScript;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the timer script in the scene
        timerScript = FindObjectOfType<NewMonoBehaviourScript>();
        
        if (timerScript != null)
        {
            // Subscribe to the OnTick event
            timerScript.OnTick += HandleTick;
        }
        else
        {
            Debug.LogWarning("No NewMonoBehaviourScript found in the scene!");
        }
    }
    
    // Handle tick event - call getMSG on all facets
    private void HandleTick()
    {
        foreach (var facet in facets)
        {
            if (facet != null)
            {
                facet.getMSG();
            }
        }
    }
    
    // Clean up event subscription when destroyed
    void OnDestroy()
    {
        if (timerScript != null)
        {
            timerScript.OnTick -= HandleTick;
        }
    }
}

// Facet class with getMSG method
public class Facet
{
    public virtual void getMSG()
    {
        Debug.Log("Facet getMSG called");
    }
}
