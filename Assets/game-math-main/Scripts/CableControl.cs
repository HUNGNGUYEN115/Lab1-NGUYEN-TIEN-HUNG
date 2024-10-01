using UnityEngine;
using UnityEngine.UI;

public class CableControl : MonoBehaviour
{
    public Transform trolley;           
    public Transform ground;            
    public Slider cableSlider;         

    private void Update()
    {
        float newYScale = Mathf.Lerp(0f, 2.5f, cableSlider.value);
        transform.localScale = new Vector3(transform.localScale.x, newYScale, transform.localScale.z);
    }

   
}
