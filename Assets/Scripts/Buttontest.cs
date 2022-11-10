using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Buttontest : MonoBehaviour
{
    public TMP_Text Mijntekst;
    public Slider MijnSlider;
    public void ChangeText()
    {
        Mijntekst.text = "You touched the button! "+MijnSlider.value;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
