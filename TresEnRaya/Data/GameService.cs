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
                Juego = new string[9],
                Jugador1Turno = true,
                Jugador2Turno = false,
                XGanador = false,
                OGanador = false,
                EmpateJuego = false,
                JuegoFinalizado = false,
                Linea = new bool[9]
            };

            for (var i = 0; i < objGameModel.Juego.Length; i++)
            {
                objGameModel.Juego[i] = string.Empty;
                objGameModel.Linea[i] = true;
            }
            return Task.FromResult(objGameModel);
        }
    }
}
