using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.


public class EJ2 : MonoBehaviour
{
    public float precio1, precio2, precio3, monto,dinerodisponible;
    float suma, resta;
    // Start is called before the first frame update
    void Start()
    {

        suma = precio1 + precio2 + precio3;
        resta = monto - suma;
        if(suma < monto)
        {
            Debug.Log("El precio supera tu monto, te sobra "+ resta);
        } else if (suma > monto)
        {
            Debug.Log("No supera el monto, te falta "+ resta);
        }
            
       

    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
