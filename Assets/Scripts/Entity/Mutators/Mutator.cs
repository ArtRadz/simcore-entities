using System;
using UnityEngine;

public class Mutator 
{
    [Serializable]
    public struct MutatorBinding
    {
        [SerializeField] public ActionTag.TagID action;
        [SerializeField] public DomainTag.TagID domain;
        [SerializeField] public ConceptTag.TagID target;
        [SerializeField] public ConceptTag.TagID instigator;
        [SerializeField] public float mutatorValue;
    }
}
