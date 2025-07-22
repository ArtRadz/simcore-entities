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

    [Tooltip("Context-specific interaction rules used on another TAG of another entity")]
    public List<InteractionRule> rules = new();
    [Tooltip("Context-specific interaction rules used on another TAG of same entity")]
    public List<SeedRule> seedRules;
}
[Serializable] public struct VariableSpec
{
    public TagID influensedTag;
    public float min;
    public float max;
    public float Default => UnityEngine.Random.Range(min, max);
}

[Serializable] public struct InteractionRule
{
    public List<TagSO>   targetTags;   
    public TagSO actionTag;     
    public float   amount; 
}
[Serializable] public struct SeedRule
{
    public List<TagSO>   targetTags;   
    public TagSO actionTag;     
    public float   amount; 
}
