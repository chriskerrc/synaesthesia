using UnityEngine;
using System.Collections;
using TMPro;

public class ColorChanger : MonoBehaviour
{
    public Color32 textColor32;

    public TextMeshPro m_TextMeshPro;

    public string label = "e";

    void Start()
    {
        InvokeRepeating("RandomizeTextColor", 0.0f, 1.0f);
    }

    void Awake()
    {
        m_TextMeshPro = gameObject.GetComponent<TextMeshPro>() ?? gameObject.AddComponent<TextMeshPro>();

        m_TextMeshPro.text = label;

    }

    void RandomizeTextColor()
    {
        // Randomly set each values of textColor32 by using Random.Range.
        // Call Random.Range and convert the random int value to byte.
        textColor32 = new Color32(
            (byte)Random.Range(0, 255),     // R
            (byte)Random.Range(0, 255),     // G
            (byte)Random.Range(0, 255),     // B
            (byte)Random.Range(0, 255));   // A

        // Set TMPro color to [textColor32]
        m_TextMeshPro.color = textColor32;
    }

}
