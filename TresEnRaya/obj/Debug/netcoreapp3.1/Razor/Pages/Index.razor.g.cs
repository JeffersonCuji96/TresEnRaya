#pragma checksum "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc2fd0c7bbbde0bd8f05ed112ef097e1ab36457c"
// <auto-generated/>
#pragma warning disable 1591
namespace TresEnRaya.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\_Imports.razor"
using TresEnRaya;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\_Imports.razor"
using TresEnRaya.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
using Hubs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Tres en Raya</h3>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 17 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
         if (_game.Jugador1Turno)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.AddMarkupContent(8, "<div class=\"alert alert-light\" role=\"alert\">Turno del Jugador 1</div>\r\n");
#nullable restore
#line 20 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
         if (_game.Jugador2Turno)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "            ");
            __builder.AddMarkupContent(10, "<div class=\"alert alert-light\" role=\"alert\">Turno del Jugador 2</div>\r\n");
#nullable restore
#line 24 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row message-win");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 27 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
         if (_game.XGanador)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "            ");
            __builder.AddMarkupContent(17, "<div class=\"alert message-game\" role=\"alert\">Jugador 1 Ganador</div>\r\n");
#nullable restore
#line 30 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
         if (_game.OGanador)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "            ");
            __builder.AddMarkupContent(19, "<div class=\"alert message-game\" role=\"alert\">Jugador 2 Ganador</div>\r\n");
#nullable restore
#line 34 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
         if (_game.EmpateJuego)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "            ");
            __builder.AddMarkupContent(21, "<div class=\"alert message-game\" role=\"alert\">Empate</div>\r\n");
#nullable restore
#line 38 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "box");
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "win1" + " " + (
#nullable restore
#line 41 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                           _game.Linea[0]? "d-none" : "d-show"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "<input class=\"line\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "win2" + " " + (
#nullable restore
#line 42 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                           _game.Linea[1]? "d-none" : "d-show"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "<input class=\"line\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "win3" + " " + (
#nullable restore
#line 43 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                           _game.Linea[2]? "d-none" : "d-show"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "<input class=\"line\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "win4" + " " + (
#nullable restore
#line 44 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                           _game.Linea[3]? "d-none" : "d-show"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(41, "<input class=\"line\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "win5" + " " + (
#nullable restore
#line 45 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                           _game.Linea[4]? "d-none" : "d-show"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(45, "<input class=\"line\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "win6" + " " + (
#nullable restore
#line 46 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                           _game.Linea[5]? "d-none" : "d-show"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(49, "<input class=\"line\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "win7" + " " + (
#nullable restore
#line 47 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                           _game.Linea[6]? "d-none" : "d-show"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "<input class=\"line\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "win8" + " " + (
#nullable restore
#line 48 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                           _game.Linea[7]? "d-none" : "d-show"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(57, "<input class=\"line\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "row first-row");
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "btn btn-outline-warning btn-size btn-font");
            __builder.AddAttribute(64, "disabled", 
#nullable restore
#line 50 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                 _isDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                        (() => JuegoClick(0))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(66, 
#nullable restore
#line 50 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                                                _game.Juego[0]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "class", "btn btn-outline-warning btn-size btn-font");
            __builder.AddAttribute(70, "disabled", 
#nullable restore
#line 51 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                 _isDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                        (() => JuegoClick(1))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(72, 
#nullable restore
#line 51 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                                                _game.Juego[1]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenElement(74, "button");
            __builder.AddAttribute(75, "class", "btn btn-outline-warning btn-size btn-font");
            __builder.AddAttribute(76, "disabled", 
#nullable restore
#line 52 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                 _isDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                        (() => JuegoClick(2))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, 
#nullable restore
#line 52 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                                                _game.Juego[2]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "row");
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.OpenElement(84, "button");
            __builder.AddAttribute(85, "class", "btn btn-outline-warning btn-size btn-font");
            __builder.AddAttribute(86, "disabled", 
#nullable restore
#line 55 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                 _isDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                        (() => JuegoClick(3))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(88, 
#nullable restore
#line 55 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                                                _game.Juego[3]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.OpenElement(90, "button");
            __builder.AddAttribute(91, "class", "btn btn-outline-warning btn-size btn-font");
            __builder.AddAttribute(92, "disabled", 
#nullable restore
#line 56 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                 _isDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                        (() => JuegoClick(4))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(94, 
#nullable restore
#line 56 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                                                _game.Juego[4]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.OpenElement(96, "button");
            __builder.AddAttribute(97, "class", "btn btn-outline-warning btn-size btn-font");
            __builder.AddAttribute(98, "disabled", 
#nullable restore
#line 57 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                 _isDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                        (() => JuegoClick(5))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(100, 
#nullable restore
#line 57 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                                                _game.Juego[5]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n        ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "row");
            __builder.AddMarkupContent(105, "\r\n            ");
            __builder.OpenElement(106, "button");
            __builder.AddAttribute(107, "class", "btn btn-outline-warning btn-size btn-font");
            __builder.AddAttribute(108, "disabled", 
#nullable restore
#line 60 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                 _isDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(109, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                        (() => JuegoClick(6))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(110, 
#nullable restore
#line 60 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                                                _game.Juego[6]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n            ");
            __builder.OpenElement(112, "button");
            __builder.AddAttribute(113, "class", "btn btn-outline-warning btn-size btn-font");
            __builder.AddAttribute(114, "disabled", 
#nullable restore
#line 61 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                 _isDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(115, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                        (() => JuegoClick(7))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(116, 
#nullable restore
#line 61 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                                                _game.Juego[7]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n            ");
            __builder.OpenElement(118, "button");
            __builder.AddAttribute(119, "class", "btn btn-outline-warning btn-size btn-font");
            __builder.AddAttribute(120, "disabled", 
#nullable restore
#line 62 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                 _isDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(121, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                        (() => JuegoClick(8))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(122, 
#nullable restore
#line 62 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                                                                                                _game.Juego[8]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n    ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "row centered");
            __builder.AddMarkupContent(128, "\r\n        ");
            __builder.OpenElement(129, "button");
            __builder.AddAttribute(130, "class", "btn btn-info m-1");
            __builder.AddAttribute(131, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
                                                   NuevoJuego

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(132, "Nuevo juego");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\renem\source\repos\TresEnRaya\TresEnRaya\Pages\Index.razor"
       

    private HubConnection _hubConnection;
    private Game _game;
    private bool _isDisabled;

    protected override async Task OnInitializedAsync()
    {

        _hubConnection = new HubConnectionBuilder().WithUrl(NavigationManager.ToAbsoluteUri("/gameHub")).Build();
        _game = await GameService.EstablecerTableroJuego();

        _hubConnection.On<Game>(HubMessages.RecibeMensaje, (game) =>
        {
            _game = game;
            StateHasChanged();
        });

        _hubConnection.On<bool>(HubMessages.DeshabilitarTablero, (disabled) =>
        {
            _isDisabled = disabled;
            StateHasChanged();
        });

        _hubConnection.On<Game>(HubMessages.TurnoFinalizado, (game) =>
        {
            if (!game.JuegoFinalizado)
            {
                _game = game;
                StateHasChanged();
            }
        });

        _hubConnection.On<Game>(HubMessages.NuevoJuego, (game) =>
        {
            _game = game;
            StateHasChanged();
        });

        _hubConnection.On<Game>(HubMessages.JuegoFinalizado, (game) =>
        {
            _game = game;
            StateHasChanged();
        });

        await _hubConnection.StartAsync();
    }

    public async Task JuegoClick(int i)
    {
        if (!_game.JuegoFinalizado && string.IsNullOrEmpty(_game.Juego[i]))
        {
            await TomarTurnoJugador(i);
        }
    }

    Task NuevoJuego() => _hubConnection.SendAsync(HubMessages.NuevoJuego, _game);
    Task TomarTurnoJugador(int i) => _hubConnection.SendAsync(HubMessages.TomarTurnoJugador, i, _game);

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GameHub GameHub { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GameService GameService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
