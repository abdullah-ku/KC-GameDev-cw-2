using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private readonly int heropower;
    string heronaem = "Thamer";
    int heropwer = 100;

    string villainName = "ahmed";
    int villainpower = 200;
    float playerspeed = 5.2f;


    // Start is called before the first frame update
    void Start()
    {
        if (heropower > villainpower)
        {
            print("heropower stronger than villainpower");
        }
        else if(villainpower > heropower)
        {
            print("villaiapower stronger than heropower");
        }
        else
        {
            print("heropower equal villainpower");
        }
        print(playerspeed);
        Setsspeed(2.5f);
        print(playerspeed);

    // Update is called once per frame
    void Update()
    {
        
    }
        void Setsspeed(float speed)
        {
            playerspeed = speed;
        }
}
}
