using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
    public GameObject[] Skills;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < Globalvariable.SelectedSkills.Length; i++) 
        {
            if (Globalvariable.SelectedSkills[i] == -1)
            {
                Skills[i].GetComponent<SkillUseButton>().button = i == 0 ? KeyCode.Alpha1 : i == 1 ? KeyCode.Alpha2 : KeyCode.Alpha3;
                Skills[i].GetComponent<SkillUseButton>().value = i;
                Instantiate(Skills[i]);
            }
            else
            {
                Skills[Globalvariable.SelectedSkills[i]].GetComponent<SkillUseButton>().button = i == 0 ? KeyCode.Alpha1 : i == 1 ? KeyCode.Alpha2 : KeyCode.Alpha3;
                Skills[Globalvariable.SelectedSkills[i]].GetComponent<SkillUseButton>().value = i;
                Instantiate(Skills[Globalvariable.SelectedSkills[i]]);
            }
        }
    }

}
