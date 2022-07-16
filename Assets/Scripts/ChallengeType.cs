using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChallengeType", menuName = "ChallengeType")]
public class ChallengeType : ScriptableObject
{
    public string Type;

    public Sprite TypeIcon;

    public Sprite Background;

    public ChallengeType(
        string type)
    {
        this.Type = type;
    }

    public ChallengeType(
        string type,
        Sprite typeIcon,
        Sprite background)
    {
        this.Type = type;
        this.TypeIcon = typeIcon;
        this.Background = background;
    }
}
