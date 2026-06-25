using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI boxText;
    public int totalBoxes = 4;

    public void UpdateBoxText(int count)
    {
        boxText.text = "»óÀÚ : " + count + " / " + totalBoxes;
    }
}