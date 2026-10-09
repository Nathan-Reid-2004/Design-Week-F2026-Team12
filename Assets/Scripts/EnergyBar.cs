using UnityEngine;

public class EnergyBar : MonoBehaviour
{
    public bool EnergyEmpty = false;
    public float Energy = 0;

    public bool isOver1 = false;

    void Update()
    {
        if (isOver1 == true)
        {
            Energy += Time.deltaTime;

            if (Energy >= 60)
            {
                EnergyEmpty = true;

            }
        }
        else 
        {
            Energy = 0;
        }
    }
}
