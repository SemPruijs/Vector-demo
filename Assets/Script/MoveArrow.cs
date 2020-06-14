using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveArrow : MonoBehaviour
{
    // public GameObject directionPoint;
    public GameObject arrow;
    
    public Vector3 arrowPosition;
    public Vector3 centerPosition;
    
    public Slider xPositionSlider;
    public Slider yPositionSlider;

    public Slider xSlider;
    public Slider ySlider;

    public Slider scaler;


    void Update()
    {
        Vector3 scale = new Vector3(arrow.transform.localScale.x, scaler.value, arrow.transform.localScale.y);
        arrowPosition.x = centerPosition.x + xPositionSlider.value;
        arrowPosition.y = centerPosition.y + yPositionSlider.value;
        
        arrow.transform.position = arrowPosition;
        arrow.transform.localScale = scale;
    }
}
