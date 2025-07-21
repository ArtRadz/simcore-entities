# ContextSystem – Entity System

\*\*ContextSystem \*\*is a modular simulation architecture for Unity that enables emergent interactions between tags, entities, and systems through extensible logic components. This document focuses on the **Entity System**, which forms the foundation for future systems like the **Network System** (relationships, hierarchies, influence) and **Memory System** (episodic recall, attitude shifts).

It is designed for character-centric simulations with strong support for overlapping group dynamics, cultural logic, and environmental interactions.

---

## 🧠 Core Concepts

### 1. Entity

Anything within the simulation (e.g., a table, NPC, idea).

- An Entity is  a **ScriptableObject blueprint** that carries its facets plus a mutable-data container and exposes a simple `Init()` method.
- Designers can attach this asset wherever they like, and each instance initializes itself from the stored ranges.



### 2. Facet

A ScriptableObject modular component attached to an Entity.

- A Facet defines exactly **one Dominion and one Role**.
- It holds references to multiple Tags interpreted under that Dominion + Role context.

### 3. Tag

The base unit of identity and behavior. Tags describe what something is (e.g., `Wood`, `Sociable`).

- A TagAsset can define **multiple Dominions and Roles**, each with its own set of Mutators.
- A Facet activates only one combination of those per use.

### 4. Dominion

Represents a **world-facing dimension** of the Tag.

- Examples: Physical, Social, Cultural, Natural, Manufactured, Supernatural
- The Tag defines which Dominions it supports; the Facet selects one.

### 5. Role

Represents an **entity-facing function** of the Tag.

- Examples: Need, Fear, Desire, Fascination, Aversion, Taboo, Material, Function
- The Tag defines which Roles it supports; the Facet selects one.

### 6. Mutators

Define logic and interaction rules.

- **RoleMutator** – Affects the entity the tag is attached to (e.g., `Hunger → Morale down`)
- **DominionMutator** – Describes how this tag affects other tags (e.g., `Fire → extra damage to Wood`)
- **GlobalMutator** – World-level effects (e.g., weather, seasons)

---

## 📘 Glossary

### Dominion ("world aspect")

*Represents the aspect of reality the tag operates within.*

Examples:

- **Physical** – tangible, material, physics‑bound
- **Social** – status, norms, relationships
- **Cultural** – beliefs, ideologies
- **Natural** – flora, fauna, ecosystems
- **Manufactured** – artificial, crafted
- **Supernatural** – divine, magical

> *Each Facet has exactly one Dominion and one Role, and can hold multiple Tags. A Tag can appear in multiple Facets of the same Entity under different combinations.*

Example:

- Facet 1: Physical + Material → Tags: Wood, Metal
- Facet 2: Physical + Manufactured → Tags: Wood, Metal
- Facet 3: Mental + Environment → Tags: Pretty, Wood

---

### Role ("entity aspect")

*Represents how the tag behaves within the owning entity.*

Examples:

- **Need** – depletes over time; drives behavior
- **Fear** – avoidance trigger
- **Desire** – approach trigger
- **Fascination** – optional attraction
- **Aversion** – passive repulsion
- **Taboo** – prohibition logic
- **Material** – affects physics/health
- **Function** – enables interaction (e.g., container)

---

### Mutator Scopes

WIP

| Scope               | Operates On  | Typical use                     | Priority |
| ------------------- | ------------ | ------------------------------- | -------- |
| **RoleMutator**     | Tag ↔ Entity | Hunger reduces Morale each tick | 1        |
| **DominionMutator** | Tag ↔ Tag    | Fire deals +50% HP to Wood      | 2        |
|                     |              |                                 |          |

> Mutators are executed in priority order. Each type applies a different level of influence.

---

### ✨ Mutator Primitives (MVP)

ContextSystem ships with **three** generic mutator types. All higher‑level effects are built on top of these primitives:

| Primitive        | Signature                                                      | Typical Uses                                                             |
| ---------------- | -------------------------------------------------------------- | ------------------------------------------------------------------------ |
| **ModifyStat**   | `void Apply(Entity src, Entity dst, TagID stat, float delta)`  | Damage (`HP −10`), healing (`HP +5`), morale boosts, temperature changes |
| **TransferStat** | `void Apply(Entity src, Entity dst, TagID stat, float amount)` | Eating (Food → Hunger), battery drain, siphoning fuel                    |
| **ToggleTag**    | `void Apply(Entity src, Entity dst, TagID tag, bool activate)` | Fear On/Off, Ignited flag, Stunned state                                 |

**Toggle vs. Add/Remove**\
Tags are **always present** on their Facet, but may be *inactive*.\
`ToggleTag` flips an `IsActive` flag; systems ignore inactive tags except for activation checks. This prevents null‑references, keeps save‑data stable, and lets designers preview all potential states in the Inspector.

If an edge‑case truly requires adding a brand‑new tag at runtime (e.g., mutation into *Werewolf*), use a specialised `AddFacetTag` utility mutator that first validates Dominion/Role support.

Naming convention: use verb‑based SOs like `ModifyDurability`, `TransferEnergy`, `ToggleFearActive`.

---

### ♻ Interaction Direction

- **Only the source tag defines interaction logic.**
- A tag (e.g., `Fire`) defines how it affects others (e.g., `Wood`) through its mutators.
- Target tags are passive.

This simplifies logic, supports cultural/emergent simulations (e.g., `DruidBeliefs` loves `Wood`, hates `Steel`), and avoids redundant config.

---

### 🧪 Working Rule

```
TagAsset = TagID + [Dominions] + [Roles] + [Mutators]
Entity = [Facet1, Facet2, ...]
Facet = (TagAsset, Dominion, Role)
```

---

### (🧠 Future Consideration)

> Roles and Dominions could be paired as structured opposites or complements (e.g., `Desire` ↔ `Taboo`) to support social conflict, emotional tension, or faction logic. Not part of MVP.

> This document covers only the **Entity System**. The **Network System** (entity–entity relationships, organizational structure, influence dynamics) and **Memory System** (perceived past, social weighting, decay) will be detailed separately.

---

## 🧹 Example Entity: `Beautiful Wooden Crate`

- **Facet 1** → `Wood`, Physical + Material

  - Mutators: `Burnable`, `AddsWeight`, `Durability`

- **Facet 2** → `Wood`, Social + Fascination

  - Mutators: `AffectsMorale`, `SymbolicValue`

- **Facet 3** → `Container`, Physical + Function

  - Mutators: `CanStoreItems`, `HasCapacity`

---

## 🚀 Getting Started (Coming Soon)

- How to define your own Tags
- How to write a Mutator
- Sample prefab + asset layout

---

> ContextSystem is ideal for AI-driven, simulation-heavy games that need rich systemic interaction without hardcoded rules. Whether you’re building a society sim, cultural sandbox, or emergent narrative engine—ContextSystem is your scaffolding.

---

