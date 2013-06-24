using UnityEngine;
using System.Collections;

public class BGMaterialControl : MonoBehaviour
{
    public Material[] PlaneMaterial;

    Material ColorTemp;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < PlaneMaterial.Length; i++)
        {
            int j = Random.Range(0, PlaneMaterial.Length);
            ColorTemp = PlaneMaterial[i];
            PlaneMaterial[i] = PlaneMaterial[j];
            PlaneMaterial[j] = ColorTemp;
        }
        for (int M_conter = 0; M_conter < PlaneMaterial.Length; M_conter++)
        {
            foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Color" + M_conter))
            {
                obj.renderer.material = PlaneMaterial[M_conter];
            }
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
