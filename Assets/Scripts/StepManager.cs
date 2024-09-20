using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class StepManager : MonoBehaviour
{
    public bool room;

    public float possibility;

    public List<int> vecinos;

    public bool isRoom () {

        return this.room;

    }

    public float getPossiblity () {

        return this.possibility;

    }

    public List<int> getVecinos () {

        return this.vecinos;

    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

}
