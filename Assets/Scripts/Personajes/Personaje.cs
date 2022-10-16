using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// clase que contiene la base para crear las clases del personaje
/// bug posible  : cambiar la ui cuando cambien las stats 
/// </summary>
public abstract class Personaje : MonoBehaviour
{
    public string nombrePersonaje;
    public float vida=100,energia=100;
    public float h1c=3, h2c=7, h3c=16;
    public float tiempoInvulnerabilidad = 5;

    public virtual void CambiarCooldowns(float _h1c, float _h2c, float _h3c)
    {
        h1c = _h1c; h2c = _h2c; h3c = _h3c;
    }
    public virtual void habilidad1()
    {
        energia -= 10;
    }
    public virtual void habilidad2()
    {
        energia -= 20;

    }
    public virtual void habilidad3()
    {
        energia -= 30;

    }
    public virtual void Pasiva()
    {

    }
}
