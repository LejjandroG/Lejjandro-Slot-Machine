using UnityEngine;

public class reelSpin : MonoBehaviour
{
    public static reelSpin main;
    public bool isSpinning;
    public int spinCounter;
    public int spinMaxCounter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        main = this;

        // Set a random maximum spin count between 30 and 70
        // Ställ in ett slumpmässigt maximalt antal snurr mellan 30 och 70
        spinMaxCounter = Random.Range(30, 70);
    }

    // Update is called once per frame
    void Update()
    {
        if(spinCounter >= spinMaxCounter)
        {
            isSpinning = false;
        }
        else
        {
            isSpinning = true;
        }

    }
}
