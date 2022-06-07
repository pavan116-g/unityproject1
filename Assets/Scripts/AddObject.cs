using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddObject : MonoBehaviour
{
    public GameObject cube,sphere,capsule;
    [SerializeField]
    private GameObject _cubetoggle,_spheretoggle,_capsuletoggle;

    [SerializeField]
    private Toggle cubetogglehigi;
    [SerializeField]
    private Toggle spherehigi;
    [SerializeField]
    private Toggle capuhigi;

    private Renderer cubeRenderer;
    private Renderer sphereRenderer;
    private Renderer capsuleRenderer;
    
    private Color cubecolor;
    private Color spherecolor;
    private Color capsulecolor;

    private void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
        sphereRenderer = sphere.GetComponent<Renderer>();
        capsuleRenderer = capsule.GetComponent<Renderer>();
    }

    public void SpawnCube()
    {
        Vector3 tps = new Vector3(Random.Range(-2.35f, 6.03f), Random.Range(-3.33f,7.62f), 0);
        Instantiate(cube, tps, Quaternion.identity);
        cubehighlight();
    }
    public void SpawnSphere()
    {
        Vector3 sph= new Vector3(Random.Range(-2.35f, 6.03f), Random.Range(-3.33f, 7.62f), 0);
        Instantiate(sphere, sph, Quaternion.identity);
        spherehighlight();
    }
    public void SpawnCapsule()
    {
        Vector3 sph = new Vector3(Random.Range(-2.35f, 6.03f), Random.Range(-3.33f, 7.62f), 0);
        Instantiate(capsule, sph, Quaternion.identity);
        capuslehighlight();
    }

    public void cubehighlight()
    {
        _cubetoggle.SetActive(true);

    }

    public void capuslehighlight()
    {
        _capsuletoggle.SetActive(true);
    }

    public void spherehighlight()
    {
        _spheretoggle.SetActive(true);
    }

    public void cubetoggleon()
    {
        if(cubetogglehigi.isOn)
        {
            cubecolor = Color.black;
            cubeRenderer.sharedMaterial.SetColor("_Color", cubecolor);
        }
        else
        {
            cubecolor = Color.white;
            cubeRenderer.sharedMaterial.SetColor("_Color", cubecolor);
        }
    }

    public void spheretoggleon()
    {
        if(spherehigi.isOn)
        {
            spherecolor = Color.black;
            sphereRenderer.sharedMaterial.SetColor("_Color", spherecolor);
        }
        else
        {
            spherecolor = Color.white;
            sphereRenderer.sharedMaterial.SetColor("_Color", spherecolor);
        }
    }

    public void capsuletoggleon()
    {
        if (capuhigi.isOn)
        {
            capsulecolor= Color.black;
            capsuleRenderer.sharedMaterial.SetColor("_Color", capsulecolor);
        }
        else
        {
            capsulecolor= Color.white;
            capsuleRenderer.sharedMaterial.SetColor("_Color", capsulecolor);
        }
    }
}