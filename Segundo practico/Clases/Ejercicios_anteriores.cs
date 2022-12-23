using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_practico.Clases
{
    internal class Ejercicios_anteriores
    {
        public void ejercicio1()
        {
            int valor = 0;
            do
            {
                Console.WriteLine("Ingrese un número: ");

                String cadena = Console.ReadLine();
                bool result = int.TryParse(cadena, out valor);

                if (result)
                {
                    if (valor >= 100)
                    {
                        Console.WriteLine("El valor ingresado es mayor a 100");
                    }
                }
                else
                {
                    Console.WriteLine("Los datos ingresado no corresponde a un valor numerico entero");
                }

            } while (valor < 0);

        }

        public void ejercicio2()
        {
            int valor;
            Console.WriteLine("Ingrese un valor numerico entero: ");
            string cadena = Console.ReadLine();
            bool result = int.TryParse(cadena, out valor);
            if (result)
            {
                if (valor % 2 == 0)
                {
                    Console.WriteLine("El numero ingresado es Par");
                }
                else
                {
                    Console.WriteLine("El numero ingresado es Impar");
                }
            }
            else
            {
                Console.WriteLine("La cedena ingresada no corresponde a un valor numerico entero");
            }
        }

        public void ejercicio3()
        {
            int valor;
            Console.WriteLine("Ingrese un valor numerico entero: ");
            string cadena = Console.ReadLine();
            bool result = int.TryParse(cadena, out valor);
            valor = valor / 2;

            if (result)
            {
                if (valor % 2 != 0)
                {
                    Console.WriteLine("El numero ingresado es el doble de un Impar");


                }
            }
            else
            {
                Console.WriteLine("La cedena ingresada no corresponde a un valor numerico entero");
            }
        }
        public void ejercicio4()
        {
            int valor;
            Console.WriteLine("Ingrese un valor numerico entero: ");
            string cadena = Console.ReadLine();
            bool result = int.TryParse(cadena, out valor);
            if (result)
            {
                int miles = valor / 1000;
                int resmiles = valor % 1000;
                int centenas = resmiles / 100;
                int rescen = resmiles % 100;
                int decenas = rescen / 10;
                int resdec = rescen % 10;
                int unidades = resdec / 1;




                string mil = "";
                string cen = "";
                string dec = "";
                string uni = "";

                for (int i = 0; i < miles; i++)
                {
                    mil += "M";
                }



                switch (centenas)
                {
                    case 1:
                        cen = "C";
                        break;
                    case 2:
                        cen = "CC";
                        break;
                    case 3:
                        cen = "CCC";
                        break;
                    case 4:
                        cen = "CD";
                        break;

                    case 5:
                        cen = "D";
                        break;

                    case 6:
                        cen = "DC";
                        break;
                    case 7:
                        cen = "DCC";
                        break;
                    case 8:
                        cen = "DCCC";
                        break;

                    case 9:
                        cen = "CM";
                        break;


                }


                switch (decenas)
                {
                    case 1:
                        dec = "X";
                        break;
                    case 2:
                        dec = "XX";
                        break;
                    case 3:
                        dec = "XX";
                        break;
                    case 4:
                        dec = "XL";
                        break;

                    case 5:
                        dec = "L";
                        break;

                    case 6:
                        dec = "LX";
                        break;
                    case 7:
                        dec = "LXX";
                        break;
                    case 8:
                        dec = "LXXX";
                        break;

                    case 9:
                        dec = "XC";
                        break;


                }



                switch (unidades)
                {
                    case 1:
                        uni = "I";
                        break;
                    case 2:
                        uni = "II";
                        break;
                    case 3:
                        uni = "III";
                        break;
                    case 4:
                        uni = "IV";
                        break;

                    case 5:
                        uni = "V";
                        break;

                    case 6:
                        uni = "VI";
                        break;
                    case 7:
                        uni = "VII";
                        break;
                    case 8:
                        uni = "VIII";
                        break;

                    case 9:
                        uni = "IX";
                        break;


                }

                Console.WriteLine(mil + cen + dec + uni);

            }
            else
            {
                Console.WriteLine("La cedena ingresada no corresponde a un valor numerico entero");
            }
        }

        public void ejercicio5()
        {
            string nombrePri, nombreSec;
            int edad1, edad2;
            Console.WriteLine("Ingrese el nombre de la primera persona: ");
            nombrePri = Console.ReadLine();
            bool result;
            do
            {
                Console.WriteLine("Ingrese la edad de la persona: ");
                result = int.TryParse(Console.ReadLine(), out edad1);
                if (result == false)
                {
                    Console.WriteLine("El dato ingresado no corresponde a una edad");
                }
            } while (result == false);


            //segunda persona
            Console.WriteLine("Ingrese el nombre de la segunda persona: ");
            nombreSec = Console.ReadLine();
            do
            {
                Console.WriteLine("Ingrese la edad de la persona: ");
                result = int.TryParse(Console.ReadLine(), out edad2);
                if (result == false)
                {
                    Console.WriteLine("El dato ingresado no corresponde a una edad");
                }
            } while (result == false);

            if (edad1 != edad2)
            {
                if (edad1 < edad2)
                {
                    Console.WriteLine("La persona con menor edad es: " + nombrePri);
                    Console.WriteLine("La diferencia de edad es: " + Convert.ToString(edad2 - edad1));
                }
                else
                {
                    Console.WriteLine("La persona con menor edad es: " + nombreSec);
                    Console.WriteLine("La diferencia de edad es: " + Convert.ToString(edad1 - edad2));
                }
            }
            else
            {
                Console.WriteLine("La dos personas tienen la misma edad!!!");
            }
        }

        public void ejercicio6()
        {
            decimal primero, segundo, tercero;
            Console.WriteLine("Debes ingresar la longitud de los tres lados del triangulo");
            bool result;
            do
            {
                Console.WriteLine("Primero: ");
                result = decimal.TryParse(Console.ReadLine(), out primero);
                if (primero <= 0)
                {
                    Console.WriteLine("Solo se permite valores decimales mayores a cero");
                }
            } while (result == false || primero <= 0);

            do
            {
                Console.WriteLine("Segundo: ");
                result = decimal.TryParse(Console.ReadLine(), out segundo);
                if (segundo <= 0)
                {
                    Console.WriteLine("Solo se permite valores decimales mayores a cero");
                }
            } while (result == false || segundo <= 0);

            do
            {
                Console.WriteLine("Tercero: ");
                result = decimal.TryParse(Console.ReadLine(), out tercero);
                if (tercero <= 0)
                {
                    Console.WriteLine("Solo se permite valores decimales mayores a cero");
                }
            } while (result == false || tercero <= 0);

            if (primero != segundo && primero != tercero && segundo != tercero)
            {
                Console.WriteLine("El tipo de triangulo ingresado es ESCALENO.");
            }
            else
            {
                if (primero == segundo && segundo == tercero)
                {
                    Console.WriteLine("El tipo de triangulo ingresado es EQUILÁTERO.");
                }
                else
                {
                    Console.WriteLine("El tipo de triangulo ingresado es ISÓCELES.");
                }
            }
            Console.WriteLine("El perimetro del triangulo es: " + Convert.ToString(calcularPerimetro(primero, segundo, tercero)));
            Console.WriteLine("El área del triangulo es: " + Convert.ToString(calcularArea(primero, segundo, tercero)));


            decimal calcularPerimetro(decimal p_1, decimal p_2, decimal p_3)
            {
                return p_1 + p_2 + p_3;
            }

            //La fórmula de Herón se utiliza para hallar el área de un triángulo conociendo sus tres lados.
            //A=raiz(p*(p-a)*(p-b)*(p-c))  p es el semiperimetro
            decimal calcularArea(decimal p_1, decimal p_2, decimal p_3)
            {
                decimal semiperimetro = calcularPerimetro(p_1, p_2, p_3) / 2;
                decimal bajoRaiz = semiperimetro * (semiperimetro - p_1) * (semiperimetro - p_2) * (semiperimetro - p_1);
                double area = Math.Sqrt(Convert.ToDouble(bajoRaiz));
                return Convert.ToDecimal(area);
            }
        }

        public void ejercicio7()
        {
            int valor;
            Console.WriteLine("Debes ingresar un numero natural mayor a 0: ");
            bool result;
            do
            {
                result = int.TryParse(Console.ReadLine(), out valor);
                if (valor <= 0)
                {
                    Console.WriteLine("Debes ingresar un numero natural mayor a 0");
                }
            } while (result == false || valor <= 0);

            int mil = valor / 1000;
            int res_mil = valor % 1000;
            int quinientos = res_mil / 500;
            int res_quinientos = res_mil % 500;
            int cien = res_quinientos / 100;
            int res_cien = res_quinientos % 100;
            int cincuenta = res_cien / 50;
            int res_cincuenta = res_cien % 50;
            int veinte = res_cincuenta / 20;
            int res_veinte = res_cincuenta % 20;
            int diez = res_veinte / 10;
            int res_diez = res_veinte % 10;
            int cinco = res_diez / 5;
            int res_cinco = res_diez % 5;
            int dos = res_cinco / 2;
            int res_dos = res_cinco % 2;
            int uno = res_dos / 1;

            string cadena = "";

            if (mil > 0)
            {
                cadena += mil + " billete de 1000, ";
            }
            if (quinientos > 0)
            {
                cadena += quinientos + " billetes de 500, ";
            }
            if (cien > 0)
            {
                cadena += cien + " billetes de 100, ";
            }
            if (cincuenta > 0)
            {
                cadena += cincuenta + " billetes de 50, ";
            }
            if (veinte > 0)
            {
                cadena += veinte + " billetes de 20, ";
            }
            if (diez > 0)
            {
                cadena += diez + " billete de 10, ";
            }
            if (cinco > 0)
            {
                cadena += cinco + " monedad de 5, ";
            }
            if (dos > 0)
            {
                cadena += dos + " moneda de 2, ";
            }
            if (uno > 0)
            {
                cadena += uno + " moneda de 1";
            }

            Console.WriteLine(cadena);
        }

        public void ejercicio8()
        {
            Console.WriteLine("Ingrese un numero natural mayor a cero: ");
            bool result;
            int valor;
            do
            {
                result = int.TryParse(Console.ReadLine(), out valor);
                if (valor <= 0)
                {
                    Console.WriteLine("Debes ingresar un numero natutal mayor a cero: ");
                }
            } while (valor <= 0);
            Console.WriteLine("Los números son: ");
            for (int i = 1; i <= valor; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void ejercicio9()
        {
            Console.WriteLine("Ingrese 15 numero natural mayor a cero: ");
            bool result;
            int[] valor = new int[15];
            int i = 0;

            while (i < 15)
            {
                result = int.TryParse(Console.ReadLine(), out valor[i]);
                if (valor[i] <= 0)
                {
                    Console.WriteLine("Debes ingresar un numero natutal mayor a cero: ");
                }
                else
                {
                    i++;
                }
            }
            int suma = 0;

            for (i = 0; i < valor.Length; i++)
            {
                suma += valor[i];
            }
            Console.WriteLine("La suma total es: " + suma);

        }

        public void ejercicio10() {
            Console.WriteLine("Debes ingresar 5 numeros enteros mayor a 0");
            bool result;
            int[] valor = new int[5];
            int i = 0;

            do
            {
                Console.WriteLine("Numero " + (i + 1) + ":");
                result = int.TryParse(Console.ReadLine(), out valor[i]);
                if (valor[i] > 0)
                {
                    i++;
                }
            } while (i < 5);

            string cadena = string.Join(", ", valor);

            Console.WriteLine("Los valores ingresados son: " + cadena);

            for (i = 0; i < 5; i++)
            {
                if (valor[i] % 3 == 0)
                {
                    Console.WriteLine("EL valor " + valor[i] + " es multiplo de 3");
                }
            }
        }
        public void ejercicio11()
        {
            string pass, res_pass;
            do
            {
                Console.WriteLine("Ingrese una contraseña: ");
                pass = Console.ReadLine();
                Console.WriteLine("Re ingrese la contraseña: ");
                res_pass = Console.ReadLine();
                if (pass != res_pass)
                {
                    Console.WriteLine("La contraseña ingresada y la repetida no coinciden!!!");
                }
            } while (pass != res_pass);
        }
        public void ejercicio12()
        {
            string pass, res_pass;
            int intentos = 1;
            do
            {
                Console.WriteLine("Ingrese una contraseña: ");
                pass = Console.ReadLine();
                Console.WriteLine("Re ingrese la contraseña: ");
                res_pass = Console.ReadLine();
                if (pass != res_pass)
                {
                    Console.WriteLine("La contraseña ingresada y la repetida no coinciden!!!");
                    Console.WriteLine("Te quedan " + (3 - intentos) + " intentos");
                    intentos++;
                }
            } while (pass != res_pass && intentos <= 3);
        }
        public void ejercicio13()
        {
            var randomNumber = new Random().Next(1, 100);
            int valor;
            bool result;
            string cadena;
            Console.WriteLine("Se eligio un numero aleatorio. ¿Quiere adivinarlo?.Presione s para salir");
            do
            {
                Console.WriteLine("Elija un numero entre 1 al 100:");
                cadena = Console.ReadLine();
                result = int.TryParse(cadena, out valor);
                if (valor == randomNumber)
                {
                    Console.WriteLine("Felicitaciones has logrado encontrar el numero aleatorio");
                }
                else
                {
                    Console.WriteLine("Numero incorrento!!!");
                }
            } while (cadena != "s" && valor != randomNumber);

            Console.WriteLine("El valor aleatorio elegido es: " + randomNumber);
        }
        public void ejercicio14()
        {
            var randomNumber = new Random().Next(1, 100);
            int valor;
            bool result;
            string cadena;
            Console.WriteLine("Se eligio un numero aleatorio. ¿Quiere adivinarlo?.Presione s para salir");
            do
            {
                Console.WriteLine("Elija un numero entre 1 al 100:");
                cadena = Console.ReadLine();
                result = int.TryParse(cadena, out valor);
                if (result)
                {
                    if (valor == randomNumber)
                    {
                        Console.WriteLine("Felicitaciones has logrado encontrar el numero aleatorio");
                    }
                    else
                    {
                        if (valor > randomNumber)
                        {
                            Console.WriteLine("Debes elejir un numero menor");
                        }
                        else
                        {
                            Console.WriteLine("Debes elejir un numero mayor");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Debes ingresar un numero entero mayor a 0!!!");
                }

            } while (cadena != "s" && valor != randomNumber);

            Console.WriteLine("El valor aleatorio elegido es: " + randomNumber);
        }
        public void ejercicio15()
        {
            // List<int> lista = new List<int>();
            int i = 1;
            bool result;
            string cadena;
            int valor;
            int suma = 0;
            Console.WriteLine("Sumar hasta el infinito. Si desea salir escriba 'fin'.");
            do
            {
                Console.WriteLine("Ingrese un numero :");
                cadena = Console.ReadLine();
                result = int.TryParse(cadena, out valor);
                if (result)
                {
                    suma += valor;
                    Console.WriteLine("La suma total es: " + suma);
                }
                else
                {
                    if (cadena != "fin")
                    {
                        Console.WriteLine("Ingreso no valido: ");
                    }
                }


            } while (cadena != "fin");
        }
    }
}
