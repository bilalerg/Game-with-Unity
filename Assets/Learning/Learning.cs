using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        UzayGemisi gemi1 = new UzayGemisi(Random.Range(80, 100));
        UzayGemisi gemi2 = new UzayGemisi(Random.Range(80, 100), "Gri");

        gemi1.Yavaslatici();
        gemi2.Yavaslatici();


        if (gemi1.MaksimumHiz > gemi2.MaksimumHiz)
        {
            Debug.Log("Kazanan Gemi1");
        }
        else if (gemi2.MaksimumHiz > gemi1.MaksimumHiz)
        {
            Debug.Log("Kazanan Gemi2");
        }
        else
        {
            Debug.Log("Berabere");
        }

        //int saldiranDusman = 10;
        //bool saldiriDevam = true;


        //while(saldiriDevam)
        //{
        //    saldiranDusman--;
        //    if(saldiranDusman < 3)
        //    {
        //        saldiriDevam = false;
        //    }
        //    Debug.Log("Saldýrý altýndayýz. Düþman sayýsý: " + saldiranDusman);
        //}

        //do
        //{
        //    saldiranDusman--;
        //    if (saldiranDusman < 3)
        //    {
        //        saldiriDevam = false;
        //    }
        //    Debug.Log("Saldýrý altýndayýz. Düþman sayýsý: " + saldiranDusman);
        //} while (saldiriDevam);

        //int yokEdilenAsteroid = 5;
        //int oyuncuHp = 50;

        //Debug.Log(yokEdilenAsteroid <= 5 && oyuncuHp > 50);

        //if(yokEdilenAsteroid >= 10 || oyuncuHp >= 80)
        //{
        //    //Debug.Log("Çok güzel");
        //}

        //if (yokEdilenAsteroid == 20)
        //{
        //    Debug.Log("Tebrikler oyunu kazandýnýz!");
        //} else if(yokEdilenAsteroid == 25)
        //{
        //    Debug.Log("Tebrikler birinci oldunuz");
        //} else
        //{
        //    Debug.Log("Maalesef oyunu kaybettiniz :(");
        //}

        //switch(yokEdilenAsteroid)
        //{
        //    case 1:
        //        Debug.Log("Güzel baþlangýç");
        //        break;
        //    case 10:
        //        Debug.Log("Bu iþte çok iyisin");
        //        break;
        //    default:
        //        Debug.Log("Maalesef oyunu kaybettiniz");
        //        break;
        //}

    }

    // Update is called once per frame
    void Update()
    {

    }
}
