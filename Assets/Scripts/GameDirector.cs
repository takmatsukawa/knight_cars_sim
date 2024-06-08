using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    private GameObject speedText;
    // Start is called before the first frame update
    void Start()
    {
        speedText = GameObject.Find("Speed");
    }

    // Update is called once per frame
    void Update()
    {
        speedText.GetComponent<TextMeshProUGUI>().text = "hoge";
    }
}
