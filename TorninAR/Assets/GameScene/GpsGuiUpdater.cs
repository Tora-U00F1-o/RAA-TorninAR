using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GpsGuiUpdater : MonoBehaviour
{

    
    public GameObject 
        latitudeTextObject1, latitudeTextObject2, latitudeTextObject3, 
        longitudeTextObject1, longitudeTextObject2, longitudeTextObject3,
        DistanciaDestinoTextObject1, DistanciaDestinoTextObject2, 
        nombreDestinoObject1 , nombreDestinoObject2, nombreDestinoObject3;

    
    private TextMeshPro latitudeTextMesh1, latitudeTextMesh2, latitudeTextMesh3, 
        longitudeTextMesh1, longitudeTextMesh2, longitudeTextMesh3,
        DistanciaDestinoTextMesh1, DistanciaDestinoTextMesh2, 
        nombreDestinoTextMesh1, nombreDestinoTextMesh2, nombreDestinoTextMesh3;


    // Start is called before the first frame update
    void Start()
    {
        latitudeTextMesh1 = latitudeTextObject1.GetComponent<TextMeshPro>();
        latitudeTextMesh2 = latitudeTextObject2.GetComponent<TextMeshPro>();
        latitudeTextMesh3 = latitudeTextObject3.GetComponent<TextMeshPro>();

        longitudeTextMesh1 = longitudeTextObject1.GetComponent<TextMeshPro>();
        longitudeTextMesh2 = longitudeTextObject2.GetComponent<TextMeshPro>();
        longitudeTextMesh3 = longitudeTextObject3.GetComponent<TextMeshPro>();

        DistanciaDestinoTextMesh1 = DistanciaDestinoTextObject1.GetComponent<TextMeshPro>();
        DistanciaDestinoTextMesh2 = DistanciaDestinoTextObject2.GetComponent<TextMeshPro>();

        nombreDestinoTextMesh1 = nombreDestinoObject1.GetComponent<TextMeshPro>();
        nombreDestinoTextMesh2 = nombreDestinoObject2.GetComponent<TextMeshPro>();
        nombreDestinoTextMesh3 = nombreDestinoObject3.GetComponent<TextMeshPro>();
        
        updateLatitude("Searching...");
        updateLongitude("Searching...");
        updateDistanciaDestino("Searching...");
        updateNombreDestino("Searching...");
    }

    

    public void updateLatitude(string latitude) {
    if (latitudeTextMesh1 != null)
        latitudeTextMesh1.text = latitude;
    if (latitudeTextMesh2 != null)
        latitudeTextMesh2.text = latitude;
    if (latitudeTextMesh3 != null)
        latitudeTextMesh3.text = latitude;
}

    public void updateLongitude(string longitude) {
        if (longitudeTextMesh1 != null)
            longitudeTextMesh1.text = longitude;
        if (longitudeTextMesh2 != null)
            longitudeTextMesh2.text = longitude;
        if (longitudeTextMesh3 != null)
            longitudeTextMesh3.text = longitude;
    }

    public void updateDistanciaDestino(string DistanciaDestino) {
        if (DistanciaDestinoTextMesh1 != null)
            DistanciaDestinoTextMesh1.text = DistanciaDestino;
        if (DistanciaDestinoTextMesh2 != null)  
            DistanciaDestinoTextMesh2.text = DistanciaDestino;
    }

    public void updateNombreDestino(string nombreDestino){
        if (nombreDestinoTextMesh1 != null)
            nombreDestinoTextMesh1.text = nombreDestino;
        if (nombreDestinoTextMesh2 != null)
            nombreDestinoTextMesh2.text = nombreDestino;    
        if (nombreDestinoTextMesh3 != null) 
            nombreDestinoTextMesh3.text = nombreDestino;
    }
}
