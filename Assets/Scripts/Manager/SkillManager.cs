using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour
{
    public GameObject[] SkillImages;
    public Sprite[] SkillSprite;
    public GameObject play;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Globalvariable.SkillSprite = SkillSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetSkill(int skill)
    {
        for (int i = 0; i < 3; i++) 
        {
            if (Globalvariable.SelectedSkills[i] == -1)
            {
                Globalvariable.SelectedSkills[i] = skill;
                SkillImages[i].GetComponent<Image>().sprite = SkillSprite[skill];
                Debug.Log(SkillImages[i].GetComponent<Image>().sprite);
                break;
            }
            if(Globalvariable.SelectedSkills[i] == skill)
            {
                Globalvariable.SelectedSkills[i] = -1;
                SkillImages[i].GetComponent<Image>().sprite = null;
                break;
            }
        }
        if (Globalvariable.SelectedSkills[2] != -1)
        {
            play.GetComponent<Button>().interactable = true;
        }
        else
        {
            play.GetComponent<Button>().interactable = false;
        }
    }
}
