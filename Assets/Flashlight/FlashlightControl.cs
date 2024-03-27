using UnityEngine;

public class FlashlightControl : MonoBehaviour
{
    private Light flashlight;

    private void Start()
    {
        // Encuentra el componente Light en el objeto hijo llamado "WhiteLight"
        flashlight = transform.Find("WhiteLight").GetComponent<Light>();
        if (flashlight == null)
        {
            Debug.LogError("No Light component found on the flashlight object!");
        }
    }

    private void Update()
    {
        // Activa o desactiva la linterna cuando se presiona el botón derecho del ratón
        if (Input.GetMouseButtonDown(1))
        {
            if (flashlight != null)
            {
                flashlight.enabled = !flashlight.enabled;
            }
        }
    }
}
