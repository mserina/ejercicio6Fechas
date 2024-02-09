namespace ejercicio6Fechas
{
    /// <summary>
    /// Clase principal del programa
    /// msm - 090224
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo que contiene el procedimiento del programa
        /// msm - 090224
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine("Inserte un dia especifico");
            string dia = Console.ReadLine();
            DateTime fecha = new DateTime();
            Console.WriteLine("INSERTE MES Y AÑO CON ESTE FORMATO: MM / AAAA");
            //Se pasa el mes y año a tipo DateTime
            fecha = Convert.ToDateTime(Console.ReadLine());

            for (int i = 1; i < 31; i++)
            {
                //Aqui se contruye la fecha, ya con el dia el cual se ira sumando, sacando todo los dias del mes
                DateTime fechaSuma = Convert.ToDateTime(i + "-" + fecha.Month + "-" + fecha.Year);

                if (fechaSuma.ToString("dddd").Equals(dia))
                {
                    Console.WriteLine(fechaSuma.ToString("dd " + " MM " + " yyyy "));
                }
            }


        }
    }
}