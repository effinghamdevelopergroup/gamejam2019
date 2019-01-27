using System;
using System.Collections;
using UnityEngine;

public class DarkenEvironment : MonoBehaviour
{
    public float score;

    private static bool fading = false;
    private GameController Global;
    static Color color = new Color();
    // Start is called before the first frame update
    void Start()
    {
        Global = gameObject.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        score = Global.Score;
        RenderSettings.ambientLight = scoreColor;
    }

    private Color scoreColor
    {
        get
        {
            Debug.Log(fading);
            if (score < 25 && !fading)
            {
                StartCoroutine(FadeOut(97, 1, false));
            }
            else if (score < 50 && !fading)
            {
                if (score > 25)
                {
                    StartCoroutine(FadeOut(150, 1, true));
                }
                StartCoroutine(FadeOut(150, 1, false));
            }
            else if(!fading)
            {
                StartCoroutine(FadeOut(255, 1, true));
            }

            return color;
        }
    }

    private static float rgbNumber(int num)
    {
        return (float)num / (float)255;
    }

    public static IEnumerator FadeOut(int target,int FadeTime, bool colorValueUp)
    {
        Debug.Log("INHERE");
        int currentValue = (int)(color.r * 255);
        fading = true;
        if (colorValueUp == false)
        {
            while (currentValue > target)
            {
                currentValue -= FadeTime;
                color.r = rgbNumber(currentValue);
                color.g = rgbNumber(currentValue);
                color.b = rgbNumber(currentValue);
                yield return null;
            }
        }
        else
        {
            Debug.Log("hmm");
            while (currentValue < target)
            {
                Debug.Log(currentValue);
                currentValue += FadeTime;
                color.r = rgbNumber(currentValue);
                color.g = rgbNumber(currentValue);
                color.b = rgbNumber(currentValue);
                yield return null;
            }
        }

        fading = false;
      
    }


}
