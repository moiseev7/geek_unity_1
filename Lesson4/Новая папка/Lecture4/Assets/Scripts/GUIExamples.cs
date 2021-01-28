using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIExamples : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUILayout.Button("Start Invoke"))
        {
            //Поиск методоа по имени это дорого
            Invoke("MyInvokeFunction", 1.0f);
        }
        if (GUILayout.Button("Start InvokeRepeating"))
        {
            InvokeRepeating("MyInvokeRepeatingFunction", 1.0f, 2.0f);
        }
        if (GUILayout.Button("Cancel Invoke"))
        {
            CancelInvoke(); // Останавливает все запущенные через Invoke функции. Можно указать конкретную функцию, которую необходимо остановить
        }
    }
    private void MyInvokeFunction()
    {
        print("Invoke");
    }
    private void MyInvokeRepeatingFunction()
    {
        print("RepeatingInvoke "+Time.time);
    }

}
