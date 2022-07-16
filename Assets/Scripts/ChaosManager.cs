using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ChaosManager
{
    public int MinimumChallengeAllowed = 1;
    public int MaximumChallengeAllowed = 20;

    private List<ChallengeType> challengeTypes = new List<ChallengeType>
    {
        new ChallengeType("Strength"),
        new ChallengeType("Intelligence"),
        new ChallengeType("Agility")
    };

    public ChallengeBase GenerateChallenge (
        int levelsCompleted)
    {
        var challenge = new ChallengeBase();
        var chaosDice = new Dice(challengeTypes.Count);
        chaosDice.Roll();
        var type = this.challengeTypes[chaosDice.rollResult];

        if (ReferenceEquals(type, null))
        {
            return challenge;
        }

        challenge.Type = type;
        challenge.SkillCheckThreshold = GetChallengeValue(chaosDice);

        return challenge;
    }

    private int GetChallengeValue (
        Dice dice)
    {
        dice.Roll();
        while (dice.rollResult > this.MaximumChallengeAllowed && dice.rollResult < this.MinimumChallengeAllowed)
        {
            dice.Roll();
        }

        return dice.rollResult;
    }


    public bool EvalutateOutcome (
        IEnumerable<CharacterBase> characters,
        ChallengeBase challenge)
    {
        var totalValue = 0;
        //TODO refactor
        var abilityList = new List<CharacterAbility>();
        foreach (var character in characters)
        {
            foreach (var ability in character.Abilities)
            {
                if (ability.Type.Name == challenge.Type.Name)
                {
                    foreach (var dice in ability.Dice)
                    {
                        dice.Roll();
                        totalValue += dice.rollResult;
                    }

                    abilityList.Add(ability);
                }
            }
        }

        return challenge.SkillCheckThreshold <= totalValue;
    }

}