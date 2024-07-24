namespace EspacioCalculadora
{
    public class EspacioCalculadora
    {
        double Dato;
        public double Resultado {get=> Dato; } 
        public void Sumar(double valor)
        {
            Dato = Dato + valor;
        }
        public void Restar(double valor)
        {
            Dato = Dato - valor;
        }
        public void Multiplicar(double valor)
        {
            Dato = Dato * valor;
        }
        public void Dividir(double valor)
        {
            if (valor !=0)
            {

            Dato = Dato / valor;
            } else
            {
                Console.WriteLine("No se puede dividir sobre 0");
            }

        }
        public void Limpiar()
        {
            Dato = 0;
        }
    }

}