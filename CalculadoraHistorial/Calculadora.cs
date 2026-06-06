namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;

        public double Dato { get => dato;}

        private List<Operacion> operaciones;

        public Calculadora()
        {
            dato = 0;
            operaciones = new List<Operacion>();

        }

        public void Sumar(double num)
        {
            operaciones.Add(new Operacion {ResultadoAnterior = dato,
                            NuevoValor = num,
                            OperacionRealizar = TipoOperacion.Suma,
                            });
            dato = operaciones.Last().Resultado;
        }

        public void Restar(double num)
        {
            operaciones.Add(new Operacion {ResultadoAnterior = dato,
                            NuevoValor = num,
                            OperacionRealizar = TipoOperacion.Resta});
            dato = operaciones.Last().Resultado;
        }

        public void Multiplicar(double num)
        {
            operaciones.Add(new Operacion {ResultadoAnterior = dato,
                            NuevoValor = num,
                            OperacionRealizar = TipoOperacion.Multiplicacion});
            dato = operaciones.Last().Resultado;
        }

        public void Dividir(double num)
        {
            operaciones.Add(new Operacion {ResultadoAnterior = dato,
                            NuevoValor = num,
                            OperacionRealizar = TipoOperacion.Division});
            dato = operaciones.Last().Resultado;
        }

        public void Limpiar()
        {
            operaciones.Add(new Operacion {ResultadoAnterior = dato,
                            NuevoValor = 0,
                            OperacionRealizar = TipoOperacion.Limpiar});
            dato = operaciones.Last().Resultado;
        }

    }

    public class Operacion
    {
        private double resultadoAnterior;
        private double nuevoValor;

        private TipoOperacion operacionRealizar;

        public double ResultadoAnterior { get => resultadoAnterior; set => resultadoAnterior = value; }
        public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }
        public TipoOperacion OperacionRealizar { get => operacionRealizar; set => operacionRealizar = value; }
        public double Resultado
        {
            get
            {
                switch (OperacionRealizar)
                {
                    case TipoOperacion.Suma:
                        return resultadoAnterior + nuevoValor;
                    case TipoOperacion.Resta:
                        return resultadoAnterior - nuevoValor;
                    case TipoOperacion.Multiplicacion:
                        return resultadoAnterior * nuevoValor;
                    case TipoOperacion.Division:
                        return resultadoAnterior / nuevoValor;
                    case TipoOperacion.Limpiar:
                        return 0;
                    default:
                        return resultadoAnterior;
                }
            }
        }

    }

    public enum TipoOperacion
        {
            Suma,
            Resta,
            Multiplicacion,
            Division,
            Limpiar // Representa la acción de borrar el resultado actual o el historial
        }
}