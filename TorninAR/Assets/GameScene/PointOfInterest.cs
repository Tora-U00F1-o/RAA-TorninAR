using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///--------------------------------
///   Author: Victor Alvarez, Ph.D.
///   University of Oviedo, Spain
///--------------------------------

public class PointOfInterest : MonoBehaviour
{
    public double latitude = 43.354668f;
    public double longitude = -5.851981f;
    public string nameDestino = "Point of Interest name";
    public int nZona = 0;

    public PointOfInterest nextPoI;

    public double getLatitude()
    { 
        return latitude;
    }

    public double getLongitude()
    { 
        return longitude;
    }

    public string getNameDestino()
    { 
        return nameDestino;
    }

    public int getNZona()
    { 
        return nZona;
    }

}
