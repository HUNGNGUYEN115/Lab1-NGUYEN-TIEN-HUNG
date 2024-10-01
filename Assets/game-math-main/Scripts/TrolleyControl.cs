using UnityEngine;
using UnityEngine.UI;

public class TrolleyMovement : MonoBehaviour
{
    public Transform trolley;
    public Transform nearLimit;        
    public Transform farLimit;        
    public Slider trolleySlider;    
    


    private void Start()
    {
        // Initialize the slider with values between 0 and 1
        trolleySlider.minValue = 0;
        trolleySlider.maxValue = 1;

  
       
    }

    private void Update()
    {
      
        Vector3 newPosition = Vector3.Lerp(nearLimit.localPosition, farLimit.localPosition, trolleySlider.value);
        trolley.transform.localPosition = newPosition;
    }

    private float InverseLerp(Vector3 a, Vector3 b, Vector3 v)
    {
        Vector3 AB = b - a;
        Vector3 AV = v - a;

        return Mathf.Clamp01(Vector3.Dot(AV, AB) / Vector3.Dot(AB, AB));
    }
}
