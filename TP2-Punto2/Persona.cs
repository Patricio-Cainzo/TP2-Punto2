using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Punto2
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad {get; set; }
        public int Dni {  get; set; }
        public char Sexo {  get; set; }
        public double Peso { get; set; }
        public double Altura {  get; set; }

        //contructores 
        public Persona(string nombre, int edad, int dni, char sexo, double peso, double altura)
        {
            Nombre = nombre;
            Edad = edad;
            Dni = dni;
            Sexo = sexo;
            Peso = peso;
            Altura = altura;

        }
        public Persona() { }
        public Persona(string nombre,int edad,char sexo) 
        {
            Nombre= nombre;
            Edad= edad;
            Sexo = sexo;
        }
        // Metodo para sacar el IMC
        public int IMC()
        {
            double Alturaenmetros = Altura / 100.0; // Convertir altura de cm a metros
            double Pesoideal = Peso / (Alturaenmetros * Alturaenmetros);

            if (Pesoideal < 20)
            {
                // Por debajo de su peso
                return -1;
            }
            else if (Pesoideal >= 20 && Pesoideal <= 25)
            {
                // Peso ideal
                return 0;
            }
            else
            {
                // Sobrepeso
                return 1;
            }
        }

        //Metodo para comprobar la mayoria de edad
        public bool MayordeEdad() 
        {
            int mayoria = Edad;

            if (mayoria > 18)
            {
                
                return true;
            }
            else 
            {
                return false;
            }
        }
        //Metodo para comprobar el sexo , en caso de que no este bien definido lo pone automaticamente en H
        public char Validarsexo()
        {
            char sexoValidado = Sexo; // Convertir a mayúsculas

            if (sexoValidado=='H' || sexoValidado=='M'|| sexoValidado=='N' )
            {
                return Sexo;
            }
            else
            {
                Sexo = 'H';

                return Sexo;

            }

        }
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}, DNI: {Dni}, Sexo: {Sexo}, Peso: {Peso}, Altura: {Altura}";
        }
    }
}
