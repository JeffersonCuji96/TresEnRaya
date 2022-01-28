﻿namespace TresEnRaya.Data
{
    public class Game
    {
        public string[] Juego { get; set; }
        public bool Jugador1Turno { get; set; }
        public bool Jugador2Turno { get; set; }
        public bool XGanador { get; set; }
        public bool OGanador { get; set; }
        public bool EmpateJuego { get; set; }
        public bool JuegoFinalizado { get; set; }
        public bool[] Linea { get; set; }
    }
}
