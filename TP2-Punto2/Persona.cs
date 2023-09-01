using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Punto2
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad {get; set; }
        public int Dni {  get; set; }
        public char Sexo {  get; set; }
        public decimal Peso { get; set; }
        public decimal Altura {  get; set; }

     
        public Persona() { }
        public Persona(string nombre,int edad,char sexo) 
        {
            Nombre= nombre;
            Edad= edad;
            Sexo = sexo;
        }
        public Persona(string nombre, int edad, int dni, char sexo, decimal peso, decimal altura)
        {
            Nombre = nombre;
            Edad = edad;
            Dni = dni;
            Sexo = sexo;
            Peso = peso;
            Altura = altura;

        }
        public int IMC(decimal peso,decimal altura)
        {
            decimal Alturaenmetros = altura / 100;
            decimal Pesoideal = peso / Alturaenmetros * Alturaenmetros;

            if (Pesoideal < 20)
            {
                return -1;
            }
            else if (Pesoideal >= 20 && Pesoideal <= 25)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        
        }
        public bool MayordeEdad(int edad) 
        {
            int mayoria = edad;

            if (mayoria > 18)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public void validarsexo(char sexo)
        {
            char sexoValidado = char.ToUpper(sexo); // Convertir a mayúsculas

            if (sexoValidado != 'H' && sexoValidado != 'M')
            {
                sexoValidado = 'H'; // Establecer como "H" si no es "H" ni "M"
            }

            return sexoValidado;
        }

        
    }
}
