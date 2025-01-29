using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Interfaz : serie de metodos que se han de implementar
//en aquellos objetos que sean interactuables
public interface IInteractive 
{
    public void Interact(Transform interactor);
    
}
