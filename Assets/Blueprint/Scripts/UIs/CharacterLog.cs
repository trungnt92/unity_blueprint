using UnityEngine;
using System.Collections;
using TMPro;

public class CharacterLog : MonoBehaviour
{
	public CharacterController charController;
	public TMP_Text logText;

    private void Update()
    {
        logText.text = BuildCharLog();
    }

    string BuildCharLog()
    {
        if (charController != null && charController.character != null)
        {
            return string.Format("Hp:{0}" +
            "\nMp:{1}" +
            "\nAtk:{2}" +
            "\nArmor:{3}",
            charController.character.hp,
            charController.character.mp,
            charController.character.atk,
            charController.character.armor);
        }

        return string.Empty;
    }
}

