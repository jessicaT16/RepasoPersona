using sistem :

        Public void debitar
        {
            double monto = 500.45;
            double debito = 135.45;
            Pepito.Acreditar(monto);
            Pepito.Debitar(debito);

            Assert.Equal(monto - debito, Pepito.Efectivo, 2);
        }

        public void Debitar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");

            if (monto > Efectivo)
                throw new InvalidOperationException("El monto supera al efectivo.");
            Efectivo -= monto;
        }
        public void Acreditar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");
            Efectivo += monto;
        }
    }
}