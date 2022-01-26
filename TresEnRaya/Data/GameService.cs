using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TresEnRaya.Data
{
    public class GameService
    {
        public Task<Game> EstablecerTableroJuego()
        {
            var objGameModel = new Game()
            {
                TurnoJugador = 0,
                Juego = new string[9],
                Jugador1Turno = false,
                Jugador2Turno = false,
                XGanador=false,
                OGanador=false,
                EmpateJuego=false,
                JuegoFinalizado=false
            };

            for(var i = 0; i < objGameModel.Juego.Length; i++)
                objGameModel.Juego[i] = string.Empty;

            return Task.FromResult(objGameModel);
        }
    }
}
