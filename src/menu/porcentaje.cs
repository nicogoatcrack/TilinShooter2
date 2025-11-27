using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderPercentage : MonoBehaviour
{
    public Slider slider;
    public TMP_Text percentageText;

    void Start()
    {
        UpdateText(slider.value);

        slider.onValueChanged.AddListener(UpdateText);
    }

    void UpdateText(float value)
    {
        int porcentaje = Mathf.RoundToInt(value);
        percentageText.text = porcentaje + "%";
    }
}
