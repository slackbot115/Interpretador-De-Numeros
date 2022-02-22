using System;
using System.IO;

namespace InterpretadorDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numeros_registrados = new string[10];

            numeros_registrados[0] = " __ " + "|  |" + "|__|";
            numeros_registrados[1] = "    " + "  | " + "  | ";
            numeros_registrados[2] = " __ " + " __|" + "|__ ";
            numeros_registrados[3] = " __ " + " __|" + " __|";
            numeros_registrados[4] = "    " + "|__|" + "   |";
            numeros_registrados[5] = " __ " + "|__ " + " __|";
            numeros_registrados[6] = " __ " + "|__ " + "|__|";
            numeros_registrados[7] = " __ " + "   |" + "   |";
            numeros_registrados[8] = " __ " + "|__|" + "|__|";
            numeros_registrados[9] = " __ " + "|__|" + " __|";

            string numeros_identificados1 = "";
            string numeros_identificados2 = "";
            string numeros_identificados3 = "";
            string numeros_identificados4 = "";
            string numeros_identificados5 = "";
            string numeros_identificados6 = "";
            string numeros_identificados7 = "";
            string numeros_identificados8 = "";
            string numeros_identificados9 = "";

            Console.WriteLine("Interpretador de Números");

            string sequencia_numeros = @"
  __   __   __   __   __        __   __      
 |__  |__     | |__| |__|   |   __|  __| |__|
  __| |__|    | |__|  __|   |  |__   __|    |
";

            StringReader leitorString = new StringReader(sequencia_numeros);
            string linhaNula = leitorString.ReadLine();
            string primeiraLinha = leitorString.ReadLine();
            string segundaLinha = leitorString.ReadLine();
            string terceiraLinha = leitorString.ReadLine();

            string numeros_retornados = "";

            for (int i = 0; i < primeiraLinha.Length; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    Console.Write(primeiraLinha[i]);
                    continue;
                }
                else if (i < 5 && i != 0)
                {
                    Console.Write(primeiraLinha[i]);
                    numeros_identificados1 += primeiraLinha[i];
                }
                else if (i < 10 && i != 0)
                {
                    Console.Write(primeiraLinha[i]);
                    numeros_identificados2 += primeiraLinha[i];
                }
                else if (i < 15 && i != 0)
                {
                    Console.Write(primeiraLinha[i]);
                    numeros_identificados3 += primeiraLinha[i];
                }
                else if (i < 20 && i != 0)
                {
                    Console.Write(primeiraLinha[i]);
                    numeros_identificados4 += primeiraLinha[i];
                }
                else if (i < 25 && i != 0)
                {
                    Console.Write(primeiraLinha[i]);
                    numeros_identificados5 += primeiraLinha[i];
                }
                else if (i < 30 && i != 0)
                {
                    Console.Write(primeiraLinha[i]);
                    numeros_identificados6 += primeiraLinha[i];
                }
                else if (i < 35 && i != 0)
                {
                    Console.Write(primeiraLinha[i]);
                    numeros_identificados7 += primeiraLinha[i];
                }
                else if (i < 40 && i != 0)
                {
                    Console.Write(primeiraLinha[i]);
                    numeros_identificados8 += primeiraLinha[i];
                }
                else if (i < 45 && i != 0)
                {
                    Console.Write(primeiraLinha[i]);
                    numeros_identificados9 += primeiraLinha[i];
                }
            }
            Console.WriteLine();
            for (int j = 0; j < segundaLinha.Length; j++)
            {
                if (j % 5 == 0 && j != 0)
                {
                    Console.Write(segundaLinha[j]);
                    continue;
                }
                else if (j < 5 && j != 0)
                {
                    Console.Write(segundaLinha[j]);
                    numeros_identificados1 += segundaLinha[j];
                }
                else if (j < 10 && j != 0)
                {
                    Console.Write(segundaLinha[j]);
                    numeros_identificados2 += segundaLinha[j];
                }
                else if (j < 15 && j != 0)
                {
                    Console.Write(segundaLinha[j]);
                    numeros_identificados3 += segundaLinha[j];
                }
                else if (j < 20 && j != 0)
                {
                    Console.Write(segundaLinha[j]);
                    numeros_identificados4 += segundaLinha[j];
                }
                else if (j < 25 && j != 0)
                {
                    Console.Write(segundaLinha[j]);
                    numeros_identificados5 += segundaLinha[j];
                }
                else if (j < 30 && j != 0)
                {
                    Console.Write(segundaLinha[j]);
                    numeros_identificados6 += segundaLinha[j];
                }
                else if (j < 35 && j != 0)
                {
                    Console.Write(segundaLinha[j]);
                    numeros_identificados7 += segundaLinha[j];
                }
                else if (j < 40 && j != 0)
                {
                    Console.Write(segundaLinha[j]);
                    numeros_identificados8 += segundaLinha[j];
                }
                else if (j < 45 && j != 0)
                {
                    Console.Write(segundaLinha[j]);
                    numeros_identificados9 += segundaLinha[j];
                }
            }
            Console.WriteLine();
            for (int k = 0; k < terceiraLinha.Length; k++)
            {
                if (k % 5 == 0 && k != 0)
                {
                    Console.Write(terceiraLinha[k]);
                    continue;
                }
                else if (k < 5 && k != 0)
                {
                    Console.Write(terceiraLinha[k]);
                    numeros_identificados1 += terceiraLinha[k];
                    if(k == 4)
                    {
                        numeros_retornados += IdentificarNumeros(numeros_registrados, numeros_identificados1);
                    }
                }
                else if (k < 10 && k != 0)
                {
                    Console.Write(terceiraLinha[k]);
                    numeros_identificados2 += terceiraLinha[k];
                    if(k == 9)
                    {
                        numeros_retornados += IdentificarNumeros(numeros_registrados, numeros_identificados2);
                    }
                }
                else if (k < 15 && k != 0)
                {
                    Console.Write(terceiraLinha[k]);
                    numeros_identificados3 += terceiraLinha[k];
                    if(k == 14)
                    {
                        numeros_retornados += IdentificarNumeros(numeros_registrados, numeros_identificados3);
                    }
                }
                else if (k < 20 && k != 0)
                {
                    Console.Write(terceiraLinha[k]);
                    numeros_identificados4 += terceiraLinha[k];
                    if (k == 19)
                    {
                        numeros_retornados += IdentificarNumeros(numeros_registrados, numeros_identificados4);
                    }
                }
                else if (k < 25 && k != 0)
                {
                    Console.Write(terceiraLinha[k]);
                    numeros_identificados5 += terceiraLinha[k];
                    if(k == 24)
                    {
                        numeros_retornados += IdentificarNumeros(numeros_registrados, numeros_identificados5);
                    }
                }
                else if (k < 30 && k != 0)
                {
                    Console.Write(terceiraLinha[k]);
                    numeros_identificados6 += terceiraLinha[k];
                    if (k == 29)
                    {
                        numeros_retornados += IdentificarNumeros(numeros_registrados, numeros_identificados6);
                    }
                }
                else if (k < 35 && k != 0)
                {
                    Console.Write(terceiraLinha[k]);
                    numeros_identificados7 += terceiraLinha[k];
                    if (k == 34)
                    {
                        numeros_retornados += IdentificarNumeros(numeros_registrados, numeros_identificados7);
                    }
                }
                else if (k < 40 && k != 0)
                {
                    Console.Write(terceiraLinha[k]);
                    numeros_identificados8 += terceiraLinha[k];
                    if (k == 39)
                    {
                        numeros_retornados += IdentificarNumeros(numeros_registrados, numeros_identificados8);
                    }
                }
                else if (k < 45 && k != 0)
                {
                    Console.Write(terceiraLinha[k]);
                    numeros_identificados9 += terceiraLinha[k];
                    if (k == 44)
                    {
                        numeros_retornados += IdentificarNumeros(numeros_registrados, numeros_identificados9);
                    }
                }
            }
            Console.WriteLine("\n\nNumeros identificados: " + numeros_retornados);
        }

        static int IdentificarNumeros(string[] numeros_registrados, string numero_identificado)
        {
            int i;
            for (i = 0; i < numeros_registrados.Length; i++)
            {
                if(numeros_registrados[i] == numero_identificado)
                {
                    break;
                }
            }
            return i;
        }

    }
}
