using UnityEngine;



public class FlashlightToggle : MonoBehaviour
{
    private Light flashlight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flashlight = GetComponent<Light>();
        if (flashlight == null)
            Debug.LogError("No Light component found on " + gameObject.name);

        flashlight.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashlight.enabled = !flashlight.enabled;
        }
        
    }
}
