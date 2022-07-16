using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeDisplay : MonoBehaviour
{
    public ChallengeBase challenge;
    public CharacterBase[] characters;


    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public Image backgroundImage;

    public TextMeshProUGUI skillCheckThreshold;
    public TextMeshProUGUI totalSkill;
    public TextMeshProUGUI players;
    public TextMeshProUGUI successDisplay;

    void Start()
    {
        ChaosManager chaos = new ChaosManager();
        var success = chaos.EvalutateOutcome(characters, challenge);

        nameText.text = challenge.Text;
        descriptionText.text = challenge.Description;
        backgroundImage.sprite = challenge.Type.Background;
        skillCheckThreshold.text = skillCheckThreshold.text.Replace("{}", challenge.SkillCheckThreshold.ToString());
        var characterNames = characters.Select(x => x.name);
        players.text = players.text.Replace("{}",string.Join(",", characterNames));
        
        totalSkill.text = totalSkill.text.Replace("{}",challenge.SkillCheckAttemptValue.ToString());
        successDisplay.text = successDisplay.text.Replace("{}",success.ToString());
    }
}
