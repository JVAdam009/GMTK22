using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Character", menuName = "Character")]
public class CharacterBase : ScriptableObject
{
    public string Name;

    public string Text;

    public Image Artwork;

    public string Type;

    public CharacterStatus Status;

    public CharacterAbility[] Abilities;
}

public enum CharacterStatus
{
    Exhaused = 0,
    Tired = 1,
    Full = 2
}