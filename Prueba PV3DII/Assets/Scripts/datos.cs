using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

[System.Serializable]
public class DataJSON : System.Object
{

    [SerializeField]
    public string nombre_juego;
    [SerializeField]
    public string nombre_jugador;
    [SerializeField]
    public string nombre_equipo;
    [SerializeField]
    public string nivel;
    [SerializeField]
    public int experiencia;
    [SerializeField]
    public int salud;
    [SerializeField]
    public int stamina;
    [SerializeField]
    public string correo;
    [SerializeField]
    public float volumen;
    [SerializeField]



    public DataJSON()
    {
    }

}