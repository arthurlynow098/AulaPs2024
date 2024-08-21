using System;

namespace FaForms
{
    public abstract class FormaGeometrica
    {
        public abstract double CalcularArea();

        public abstract double GetCalcularPerimetro();
    }

    public class CalcularPerimetro : FormaGeometrica
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public override double CalcularArea()
        {
            return Math.Pow(lado, 2);
        }

        public override double GetCalcularPerimetro()
        {
            return lado * 4;
        }
    }
}
