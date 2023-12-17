using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public bool isOn;
    public Light light;
    public AudioSource source;
    public float timer = 0;

    public int battery1 = 10;

    void Update()
    {
        if (isOn)
        {
            timer += Time.deltaTime;
        }


        if (timer < battery1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Switch();
            }
            if (timer >= battery1)
            {
                light.intensity -= 1f;
                timer = 0;
            }
        }

        void Switch()
        {
            isOn = !isOn;
            source.Play();
        }        
        light.enabled = isOn;
    }
}