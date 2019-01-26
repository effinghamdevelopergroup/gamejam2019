using System;
using UnityEngine;

public class DarkenEvironment : MonoBehaviour
{
    public float score;

    Color color = new Color();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.ambientLight = scoreColor;
    }

    private Color scoreColor
    {
        get
        {
            if (score <= 25)
            {
                color.r = rgbNumber(97);
                color.g = rgbNumber(97);
                color.b = rgbNumber(97);
            }
            else if (score <= 50)
            {
                color.r = rgbNumber(164);
                color.g = rgbNumber(164);
                color.b = rgbNumber(164);
            }
            else
            {
                color.r = rgbNumber(255);
                color.g = rgbNumber(255);
                color.b = rgbNumber(255);
            }

            return color;
        }
    }

    private float rgbNumber(int num)
    {
        return (float)num / (float)255;
    }

}
