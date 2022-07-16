using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Character")]
public class CharacterBase : ScriptableObject
{
    public string Name;

    public string Text;

    public Sprite Artwork;

    public string Type;

    public CharacterStatus Status;

    public IEnumerable<CharacterAbility> Abilities;
}

[CreateAssetMenu(fileName = "CharacterStat", menuName = "CharacterStat")]
public class CharacterAbility : ScriptableObject
{
    public ChallengeType Type;

    public IEnumerable<Dice> Dice;
}

public enum CharacterStatus
{
    Exhaused = 0,
    Tired = 1,
    Full = 2
}