
using UnityEngine;
using System.Collections;
using Unity.VisualScripting.FullSerializer;
using UnityEditor.Experimental.GraphView;

public class IfStatementts : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }



    void TemperatureTest()
    {
        // If the coffee's temperature is greater than the hottest drinking temperature
        if (coffeeTemperature > hotLimitTemperature)
        {
            //... do this
            print("Coffee is too hot.");
        }
        // if it isnt but the coffee tempature is less than the coldest drinking temperature
        else if (coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold.");
        }
        // if it is neither of those then
        else
        {
            //... do this.
            print("Coffee is just right.");
        }
    }
}