using System;


namespace AppGestionBnacaria
{
    public class Ahorros : Cuentas
    {
        private string tasaInteres;

        public string TasaInteres
        {
            get { return tasaInteres; }
            set { tasaInteres = value; }
        }
		
		public Ahorros()
		{
			this.tasaInteres = "123456";
		}
		
		public Ahorros(string tasaInteres)
		{
			this.tasaInteres = tasaInteres;
		}
		
		public override string ToString()
		{
			return "\n===========================\n" +
			"Tasa de Interes: " + this.tasaInteres;
		}
		
		public override bool Equals(object obj)
        {
            Ahorros o = (Ahorros)obj;
            bool result = false;

            if (this.tasaInteres == o.tasaInteres)
                result = true;

            return result;
        }

        public Ahorros()
        {
            throw new System.NotImplementedException();
        }
		//hola mundo//
        
	}
}
