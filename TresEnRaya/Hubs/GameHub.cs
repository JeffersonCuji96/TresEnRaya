using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TresEnRaya.Data;
using TresEnRaya.Extensions;

namespace TresEnRaya.Hubs
{
    public class GameHub:Hub
    {
        readonly GameService _service = new GameService();
        const string X = "X";
        const string O = "O";

        public async Task NuevoJuego(Game game)
        {
            game = await _service.EstablecerTableroJuego();
            await Clients.All.SendAsync(HubMessages.DeshabilitarTablero, false);
            await Clients.All.SendAsync(HubMessages.NuevoJuego, game);
        }
        public async Task EnvioMensaje(Game game)
        {
            await Clients.All.SendAsync(HubMessages.RecibeMensaje,game);
        }
        public async Task GestionarJuegoFinalizado(Game game)
        {
            if (game.Juego.GanadorX().Item1)
            {
                game.Linea[game.Juego.GanadorX().Item2] = false;
                game.XGanador = true;
                game.JuegoFinalizado = true;
            }else if (game.Juego.GanadorO().Item1)
            {
                game.Linea[game.Juego.GanadorO().Item2] = false;
                game.OGanador = true;
                game.JuegoFinalizado = true;
            }else if (game.Juego.Empatado())
            {
                game.EmpateJuego = true;
                game.JuegoFinalizado = true;
            }
            if (game.JuegoFinalizado)
            {
                game.Jugador1Turno = false;
                game.Jugador2Turno = false;
                await Clients.All.SendAsync(HubMessages.DeshabilitarTablero, false);
                await Clients.All.SendAsync(HubMessages.JuegoFinalizado, game);
            }
        }

        public async Task FinalizarTurnoJugador(Game game)
        {
            await GestionarJuegoFinalizado(game);
            if (!game.JuegoFinalizado)
            {
                game.Jugador1Turno = !game.Jugador1Turno;
                game.Jugador2Turno = !game.Jugador2Turno;
                await Clients.All.SendAsync(HubMessages.TurnoFinalizado, game);
            }
        }
        public async Task TomarTurnoJugador(int i, Game game)
        {
            if (game.Jugador1Turno)
            {
                game.Juego[i] = X;
                await Clients.Caller.SendAsync(HubMessages.DeshabilitarTablero, true);
                await Clients.Others.SendAsync(HubMessages.DeshabilitarTablero, false);
            }
            else if(game.Jugador2Turno)
            {
                game.Juego[i] = O;
                await Clients.Caller.SendAsync(HubMessages.DeshabilitarTablero, true);
                await Clients.Others.SendAsync(HubMessages.DeshabilitarTablero, false);
            }
            await FinalizarTurnoJugador(game);
        }
    }
}
