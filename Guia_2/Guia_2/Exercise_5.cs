﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guia_2 {
    class Exercise_5
    {
        string repetir;
        int nErrors = 0;
        double tempMax= 0, tempMin= 0, med=0, max=0, min=0;
        public void Ejecutar() {
           do
            {
                Console.Clear();
                Console.WriteLine("Programa 5, Calculos estación climática ");
                int nDias = Utils.readInt("Ingrese la cantidad de días que vas a registrar las termperaturas: ");
                double[][] temps = new double[nDias][];
                for (int i = 0; i < nDias; i++)
                {
                    temps[i] = new double[2];
                    Console.WriteLine("\nTemperatura del día {0}", i+1);
                    tempMax = Utils.readDouble("Temperatura máxima: ");
                    if (tempMax == 9)
                    {
                        tempMax = Utils.readDouble("Temperatura invalida, ingrese una temperatura máxima: ");
                        nErrors++;
                    }
                    tempMin = Utils.readDouble("Temperatura minima: ");
                    if (tempMin == 9) {
                        tempMin = Utils.readDouble("Temperatura invalida, ingrese una temperatura minima: ");
                        nErrors++;
                    } else if (tempMin > tempMax)
                    {
                        nErrors++;
                        tempMin = Utils.readDouble("La temperatura debe ser menor a la máxima, ingrese una temperatura minima: ");
                    }
                    temps[i][0] = tempMax;
                    temps[i][1] = tempMin;
                }

                
                Console.WriteLine("\nTemperatura máxima | Temperatura minima");
                for (int ii = 0; ii < nDias; ii++)
                {
                    Console.WriteLine("{0} {1}", temps[ii][0], temps[ii][1]);
                    med += temps[ii][0]+ temps[ii][1];
                    max = Math.MaxMagnitude(Math.MaxMagnitude(temps[ii][0] , temps[ii][1]), max);
                    min = Math.MinMagnitude(Math.MinMagnitude(temps[ii][0], temps[ii][1]), min);
                }
                Console.WriteLine("\nTemperatura media: {0:0.0}", med/(nDias*2));
                Console.WriteLine("Temperatura máxima {0}", max);
                Console.WriteLine("Temperatura minima {0}", min);
                Console.WriteLine("Cantidad de errores: {0}", nErrors);

                Console.WriteLine("\n Presiona enter para repetir, escriba NO para volver al menú");
                repetir = Console.ReadLine().ToLower();
            } while (repetir != "no");

        }

    

    }
}
