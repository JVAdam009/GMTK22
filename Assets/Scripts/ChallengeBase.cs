using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Challenge", menuName = "Challenge")]
public class ChallengeBase : ScriptableObject
{
    public ChallengeType Type;

    public string Text;

    public int SkillCheckThreshold;

    //public int SkillCheckMax;

    //public int SkillCheckMin;
}


