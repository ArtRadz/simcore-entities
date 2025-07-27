using System;
using UnityEngine;

public class Mutator 
{
    public enum MutatorID {Decrease, Increase,Transform,Consume}
    [Serializable]
    public struct MutatorBinding
    {
        [SerializeField] public MutatorID mutator;
        [SerializeField] public TagID.TagId targetTags;
        [SerializeField] public float mutatorValue;
    }
}
