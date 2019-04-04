using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesYEscaleras
{
    class Jugador:Dado 
    {
        protected int _numero;
        protected int _posicion;
        //Pone el numero del j en 0 y declara _numero como numero
        public Jugador(int numero)
        {
            _numero = numero;
            _posicion = 0;
        }
        public int Avanzar(int avanzar)
        {
            _posicion = _posicion + avanzar;
            if (_posicion == 4)
                _posicion += 10;
            else if (_posicion == 1)
                _posicion += 35;
            else if (_posicion == 16)
                _posicion -= 10;
            else if (_posicion == 9)
                _posicion += 22;
            else if (_posicion == 21)
                _posicion += 21;
            else if (_posicion == 28)
                _posicion += 56;
            else if (_posicion == 36)
                _posicion += 8;
            else if (_posicion == 47)
                _posicion -= 27;
            else if (_posicion == 49)
                _posicion -= 38;
            else if (_posicion == 51)
                _posicion += 16;
            else if (_posicion == 56)
                _posicion -= 3;
            else if (_posicion == 62)
                _posicion -= 43;
            else if (_posicion == 71)
                _posicion += 20;
            else if (_posicion == 80)
                _posicion += 20 ;
            else if (_posicion == 87)
                _posicion -= 63;
            else if (_posicion == 93)
                _posicion -= 22;
            else if (_posicion == 95)
                _posicion -= 20;
            else if (_posicion == 98)
                _posicion -= 20;

            return _posicion;
        }
    }
}
