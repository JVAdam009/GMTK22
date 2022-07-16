using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterAbility", menuName = "CharacterAbility")]
public class CharacterAbility : ScriptableObject
{
    public ChallengeType Type;

    public Dice[] Dice;
}
