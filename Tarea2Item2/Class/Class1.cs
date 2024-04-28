
namespace Tarea2Item2.Class
{
    public class Calculo
    {
        public void  SegundoItem()
        {

            int PrimeraNota = 0;
            int SegundaNota = 0;
            int TerceraNota = 0;

            try
            {

                Console.WriteLine("Inserte la primera nota:");
                PrimeraNota = Convert.ToInt32(Console.ReadLine());
               

                if (PrimeraNota >= 7)

                {
                    Console.WriteLine("promocionado");

                }

                else
                {
                    Console.WriteLine("No promocionado");
                }



                Console.WriteLine("Inserte la seguda nota");
                SegundaNota = Convert.ToInt32(Console.ReadLine());
                

                if (SegundaNota >= 7)
                {
                    Console.WriteLine("promocionado");


                }
                else
                {
                    Console.WriteLine("No promocionado");

                }



                Console.WriteLine("Inserte la tercera nota");
                TerceraNota = Convert.ToInt32(Console.ReadLine());
                

           
                if (TerceraNota >= 7)
                {
                            Console.WriteLine("promocionado");

                }

                else 
                    {
                    Console.WriteLine("No promocionado");


                }

            
            
            }
            catch (Exception ex) { 
                Console.WriteLine($"Ocurrio un error al ingresar los datos {ex}");
            
            }


        
        }

    }
}
