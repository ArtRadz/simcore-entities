using System;

public class TagDomain
{
    
    /// <summary>
    /// Flags describing where a Tag can legally appear.
    /// Each value is a single bit so we can OR them.
    /// Uses powers of two so combinations don’t overlap.
    /// </summary>
    [Flags]
    public enum TagDomains { None = 0, Role = 1<<1, Aspect = 1<<2, Need = 1<<3 }
}
