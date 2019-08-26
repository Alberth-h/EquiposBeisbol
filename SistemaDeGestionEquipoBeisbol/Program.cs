using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionEquipoBeisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo mayos = new Equipo("Mayos");
            Equipo yaquis = new Equipo("Yaquis");

            equipos.Add(mayos);
            equipos.Add(yaquis);

            //Estos son de los mayos
            Jugador Alberto = new Jugador("Alberto", "66642069");
            Jugador Pablo = new Jugador("Pablo", "642145890");
            Jugador Roberto = new Jugador("Roberto", "839321368");
            Jugador Mario = new Jugador("Mario", "892623435834");
            Jugador Jose = new Jugador("Jose", "736832537");
            Jugador Miguel = new Jugador("Miguel", "0928379812");
            Jugador Jesus = new Jugador("Jesus", "67387467287");
            Jugador Cleyton = new Jugador("Cleyton", "903737826732");
            Jugador Omar = new Jugador("Omar", "78435483643");
            //Estos son de los yaquis
            Jugador Alex = new Jugador("Alex", "66642069");
            Jugador Jebus = new Jugador("Jebus", "642145890");
            Jugador Carlos = new Jugador("Carlos", "839321368");
            Jugador Ruben = new Jugador("Ruben", "892623435834");
            Jugador Mora = new Jugador("Mora", "736832537");
            Jugador Gerardo = new Jugador("Gerardo", "0928379812");
            Jugador Emilio = new Jugador("Emilio", "67387467287");
            Jugador Jonh = new Jugador("Jonh Cena", "903737826732");
            Jugador vlad = new Jugador("Vlad", "78435483643");

            mayos.jugadores.Add(Alberto);
            mayos.jugadores.Add(Pablo);
            mayos.jugadores.Add(Roberto);
            mayos.jugadores.Add(Mario);
            mayos.jugadores.Add(Jose);
            mayos.jugadores.Add(Miguel);
            mayos.jugadores.Add(Jesus);
            mayos.jugadores.Add(Cleyton);
            mayos.jugadores.Add(Omar);

            yaquis.jugadores.Add(Alex);
            yaquis.jugadores.Add(Jebus);
            yaquis.jugadores.Add(Carlos);
            yaquis.jugadores.Add(Ruben);
            yaquis.jugadores.Add(Gerardo);
            yaquis.jugadores.Add(Emilio);
            yaquis.jugadores.Add(Mora);
            yaquis.jugadores.Add(Jonh);
            yaquis.jugadores.Add(vlad);

            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("Equipo: " + equipo.Nombre);
                Console.WriteLine("Lista de jugadores:");

                foreach (Jugador jugador in equipo.jugadores)
                {
                    Console.WriteLine("Nombre: " + jugador.Nombre);
                    Console.WriteLine("Numero: " + jugador.Numero);
                }
            }

            Console.ReadLine();


        }
    }
}
