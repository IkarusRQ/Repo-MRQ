using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameManager : MonoBehaviour
{
    public DataJSON misDatos;
    public Text textoTitulo;
    public Text textoPlayer;
    public Text textoEquipo;
    public Text textoNivel;
    public InputField textoJugador;
    public InputField textoTeam;

    public Slider volumen;

    public GameObject panelUI; 
    // Start is called before the first frame update
    void Start()
    {
        string filePat = Application.streamingAssetsPath + "/" + "data1.json";

        if (File.Exists(filePat))
        {
            string s = File.ReadAllText(filePat);
            misDatos = JsonUtility.FromJson<DataJSON>(s);
            Debug.Log(s);
            Debug.Log(misDatos);
            Debug.Log(misDatos.nombre_juego);
            s = JsonUtility.ToJson(misDatos, true);
            Debug.Log(s);
            File.WriteAllText(filePat, s);
        }
        cargaDatos();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape)){

            panelUI.SetActive(true);
        }
    }

    void cargaDatos(){
        GameObject.Find("t_titulo").GetComponent<Text>().text = misDatos.nombre_juego;
        textoTitulo.text = misDatos.nombre_juego;
        textoPlayer.text = misDatos.nombre_jugador;
        textoEquipo.text = misDatos.nombre_equipo;
        textoNivel.text = misDatos.nivel;
        volumen.value = misDatos.volumen;
        
    }
    public void guardaDatos(){
        misDatos.nombre_jugador = textoJugador.text;
        misDatos.nombre_equipo = textoTeam.text;
        misDatos.volumen = volumen.value;
        string filePat = Application.streamingAssetsPath + "/" + "data1.json";
        string s = JsonUtility.ToJson(misDatos, true);
        File.WriteAllText(filePat, s);
    }
}
