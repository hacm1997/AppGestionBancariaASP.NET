using System;


namespace AppGestionBnacaria
{
    public class Cuentas
    {
        //Variables//
        private string identificacion;
        private string balance;
        private string idcliente;

        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        public string Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }

        public Cuentas()
        {
            this.identificacion = "name";
            this.balance = "balance";
            this.idcliente = "cliente_1";
        }

        public Cuentas(string identificacion, string balance, string idcliente)
        {
            this.identificacion = identificacion;
            this.balance = balance;
            this.idcliente = idcliente;
        }
		
		public override string ToString()
		{
			return "\n=================================\n" +
			"Identificación: " + this.identificacion + "\n" +
			"Id. Cliente: " + this.idcliente + "\n" +
			"Balance: " + this.balance;
		}
		
		public override bool Equals(object obj)
        {
            Cuentas o = (Cuentas)obj;
            bool result = false;

            if ((this.identificacion == o.identificacion) &&
                (this.idcliente == o.idcliente) && (this.balance == o.balance))
                result = true;

            return result;
        }
		
		public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
		
    }
}
