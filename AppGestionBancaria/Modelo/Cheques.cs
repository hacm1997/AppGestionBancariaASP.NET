using System;


namespace AppGestionBnacaria
{
    class Cheques : Cuentas
    {
        private string idTalonario;

        public string IdTalonario
        {
            get { return idTalonario; }
            set { idTalonario = value; }
        }
		
		public Cheques()
		{
			this.idTalonario = "XXXXX";
		}
		
		public Cheques(string idTalonario)
		{
			this.idTalonario = idTalonario;
		}
		
		public override string ToString()
		{
			return "\n===========================\n" +
			"Id. del Talonario: " + this.idTalonario;
		}
		
		public override bool Equals(object obj)
        {
            Cheques o = (Cheques)obj;
            bool result = false;

            if (this.idTalonario == o.idTalonario)
                result = true;

            return result;
        }

        public Cheques()
        {
            throw new System.NotImplementedException();
        }

    }
}
