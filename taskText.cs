using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class taskText : MonoBehaviour
{
    public TextMeshProUGUI textt;
    private int i = 0;
    string[] listoftasks = {
        "Perform a 5-minute stretching routine to improve flexibility", 
        "Engage in a 1-minute deep breathing exercise", 
        "Drink a glass of water to stay hydrated", 
        "Complete a set of 5 sit-ups to improve core stability",
        "Rest your eyes for a few minutes by focusing on an object in the distance",
        "Enjoy a nutritious snack, such as a piece of fruit or nuts, to maintain energy levels",
        "Stand up and stretch to improve circulation",
        "Take a moment to assess and correct your posture to prevent discomfort"
    };
    // Start is called before the first frame update
    void Start()
    {
        // textt = GetComponent<Text>();
        i = Random.Range(0, 8);
        textt.text = listoftasks[i];
    }
}
