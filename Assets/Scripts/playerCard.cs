using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Characterrr")]
public class playerCard : ScriptableObject
{
    public new string playerName;
    public string playerBio;

    public Sprite art;

    public int currAGL;
    public int currINT;
    public int currSTR;
    public int energy;
}