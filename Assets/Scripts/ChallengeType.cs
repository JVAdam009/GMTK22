using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChallengeType", menuName = "ChallengeType")]
public class ChallengeType : ScriptableObject
{
    public string Name;

    public Sprite TypeIcon;

    public Sprite Background;

    public ChallengeType(
        string type)
    {
        this.Name = type;
    }

    public ChallengeType(
        string type,
        Sprite typeIcon,
        Sprite background)
    {
        this.Name = type;
        this.TypeIcon = typeIcon;
        this.Background = background;
    }
}
