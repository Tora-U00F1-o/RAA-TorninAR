using UnityEngine;

public class GameModePersistence : MonoBehaviour
{

    public static bool practiceMode = false;

    // For Game Scene
    public static int zonaActual = -1; // zonas = -1, 0, 1, 2
    public static bool puedeSeguirSiguienteZona = true;

    public static bool llamadaRecibida = false;
}