using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Enumerados
    {
        public enum TiposTelefono { ADisco, ConTeclado }

        public enum Programas { office, messenger, icq, ares }

        public enum Perifericos { camara, auriculares, microfono }

        public enum Juegos { CounterStrike, DiabloII, MuOnline, LineageII, WarcraftII, AgeOfEmpiresII }

        public enum  EstadoPuesto { Libre, EnUso }

        public enum EstadoCliente { esperandoCabina, esperandoComputadora, ubicadoTelefono, ubicadoComputadora, fuera }

        public enum TipoDeLlamada { Local, LargaDistancia, Internacional, NoAsignado }

        public enum CaracteristicasComputadora { procesador, ram, placaDeVideo }

        public enum TiposDeSesion { conexion , llamada }

    }
}
