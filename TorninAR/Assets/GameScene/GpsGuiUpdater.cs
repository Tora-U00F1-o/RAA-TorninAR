using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GpsGuiUpdater : MonoBehaviour
{

    
    public GameObject 
        latitudeTextObject1, latitudeTextObject2, latitudeTextObject3, 
        longitudeTextObject1, longitudeTextObject2, longitudeTextObject3,
        goalTextObject1, goalTextObject2, 
        nombreDestinoObject2, nombreDestinoObject3;

    
    private TextMeshPro latitudeTextMesh1, latitudeTextMesh2, latitudeTextMesh3, 
        longitudeTextMesh1, longitudeTextMesh2, longitudeTextMesh3,
        goalTextMesh1, goalTextMesh2, 
        nombreDestinoTextMesh2, nombreDestinoTextMesh3;


    // Start is called before the first frame update
    void Start()
    {
        latitudeTextMesh1 = latitudeTextObject1.GetComponent<TextMeshPro>();
        latitudeTextMesh2 = latitudeTextObject2.GetComponent<TextMeshPro>();
        latitudeTextMesh3 = latitudeTextObject3.GetComponent<TextMeshPro>();

        longitudeTextMesh1 = longitudeTextObject1.GetComponent<TextMeshPro>();
        longitudeTextMesh2 = longitudeTextObject2.GetComponent<TextMeshPro>();
        longitudeTextMesh3 = longitudeTextObject3.GetComponent<TextMeshPro>();

        goalTextMesh1 = goalTextObject1.GetComponent<TextMeshPro>();
        goalTextMesh2 = goalTextObject2.GetComponent<TextMeshPro>();

        nombreDestinoTextMesh2 = nombreDestinoObject2.GetComponent<TextMeshPro>();
        nombreDestinoTextMesh3 = nombreDestinoObject3.GetComponent<TextMeshPro>();
        
        updateLatitude("Err");
        updateLongitude("Err");
        updateGoal("Err");
        updateNombreDestino("Err");
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

    public void updateGoal(string goal) {
        if (goalTextMesh1 != null)
            goalTextMesh1.text = goal;
        if (goalTextMesh2 != null)  
            goalTextMesh2.text = goal;
    }

    public void updateNombreDestino(string nombreDestino){
        if (nombreDestinoTextMesh2 != null)
            nombreDestinoTextMesh2.text = nombreDestino;    
        if (nombreDestinoTextMesh3 != null) 
            nombreDestinoTextMesh3.text = nombreDestino;
    }
}
