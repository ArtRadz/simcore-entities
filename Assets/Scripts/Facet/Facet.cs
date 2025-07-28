using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewFacet",menuName = "Facet")]

public class Facet : ScriptableObject
{
    private FacetData data = new FacetData();
    
    public DomainTag.TagID Domain;
    public List<ActionTag.TagID> Actions;
    public List<ActionTag.TagID> AlowedIncomingActions ;
    [SerializeField] private List<TagSO> tags;

    [HideInInspector] public List<ConceptTag.TagID> TagIDs = new List<ConceptTag.TagID>();

    [HideInInspector] public Dictionary<ConceptTag.TagID, Mutator> Mutators;

    public void Init()
    {
        List<Mutator> mutators = new List<Mutator>();
        foreach (TagSO tag in Tags)
        {
            TagIDs.Add(tag.tagID);
            foreach (Mutator mutator in tag.)
            {
                
            }
        }
    }
}
