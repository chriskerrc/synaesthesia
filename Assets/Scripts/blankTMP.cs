using UnityEngine;
using System.Collections;
using TMPro;

public class blankTMP : MonoBehaviour
{
    public Color32 textColor32;

    public TextMeshPro m_TextMeshPro;

    public string label = "i";

    void Awake()
    {
        m_TextMeshPro = gameObject.GetComponent<TextMeshPro>() ?? gameObject.AddComponent<TextMeshPro>();

        m_TextMeshPro.text = label;

    }

}
