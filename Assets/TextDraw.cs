using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDraw : MonoBehaviour
{
    private float alpha = 1;
    public string[] words;
    private int wordChoice;
    // Start is called before the first frame update
    void Start()
    {
        wordChoice = Random.Range(0, words.Length);
        gameObject.GetComponent<TextMesh>().text = words[wordChoice];
    }

    // Update is called once per frame
    void Update()
    {
        alpha -= Time.deltaTime*.6F;
        GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1, alpha);
    }
}
