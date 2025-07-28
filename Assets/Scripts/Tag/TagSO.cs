using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewTag",menuName = "Tag")]
public class TagSO : ScriptableObject
{
    [SerializeField] public ConceptTag.TagID tagID;
    [SerializeField] private List<DomainTag.TagID>  alowedDomains;
    [SerializeField] private  List<ActionTag.TagID>  alowedActions;
    [SerializeField] private  List<ActionTag.TagID>  alowedToReciveActions;

    [SerializeField] private List<Mutator.MutatorBinding> mutators;

}
