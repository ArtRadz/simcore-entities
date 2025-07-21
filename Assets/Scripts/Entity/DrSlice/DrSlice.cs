using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]                    
public class DrSlice            
{
    public TagDomain domain;    
    public TagRole role;        

    [Tooltip("Stats this slice seeds into the entity")]
    public List<VariableSpec> variables = new();

    [Tooltip("Context-specific interaction rules")]
    public List<InteractionRule> rules = new();
}
[Serializable] public struct VariableSpec
{
    public TagID stat;
    public float min;
    public float max;
    public float Default => UnityEngine.Random.Range(min, max);
}

[Serializable] public struct InteractionRule
{
    public TagSO   targetTag;   
    public Mutator mutator;     
    public float   amount; 
}
