using System;

namespace AppGestionBnacaria
{
    class Corrientes : Cuentas
    {
        private string liCredito;
        private string tidEfectivo;
        private string tidBalance;

        public string LiCredito
        {
            get { return liCredito; }
            set { liCredito = value; }
        }

        public string TidEfectivo
        {
            get { return tidEfectivo; }
            set { tidEfectivo = value; }
        }

        public string TidBalance
        {
            get { return tidBalance; }
            set { tidBalance = value; }
        }
		
		public Corrientes()
		{
			this.liCredito = "9702548-8";
			this.tidEfectivo = "1000000";
			this.tidBalance = "55555";
		}
		
		public Corrientes(string liCredito, string tidEfectivo, string tidBalance)
		{
			this.liCredito = liCredito;
			this.tidEfectivo = tidEfectivo;
			this.tidBalance = tidBalance;
		}
		
		public override string ToString()
		{
			return "\n=================================\n" +
			"Linea de Crédito: " + this.liCredito + "\n" +
			"Tid. Efectivo: " + this.tidEfectivo + "\n" +
			"Tid. Balance: " + this.tidBalance;
		}
		
		public override bool Equals(object obj)
        {
            Cuentas o = (Cuentas)obj;
            bool result = false;

            if ((this.liCredito == o.liCredito) &&
                (this.tidEfectivo == o.tidEfectivo) && (this.tidBalance == o.tidBalance))
                result = true;

            return result;
        }

        public Corrientes()
        {
            throw new System.NotImplementedException();
        }
    }
}
