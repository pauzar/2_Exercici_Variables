using system; 
{
    public class Program
    {
        public static void Main()
        {
            
    //FASE 1
    //Crea tres variables string e inicialitzales amb les dades pertinents (nom, cognom1, cognom2).
        string nom = "Paula";
        string cognom1 = "Zaragoza";
        string cognom2 = "Gomez";
    //Crea tres variables int e inicialitzales amb les dades pertinents (dia, mes, any).
        int dia = 28;
        int mes = 11;
        double any = 1988.00;
        //Mostra per pantalla les variables string concatenant-les en aquest ordre (cognom1 + cognom2, + nom).
        Console.WriteLine("El nom es " + cognom1 +" "+ cognom2 +" "+ nom);
        //Mostra per pantalla les variables int concatenant-les amb “/” entre cada una d’elles.
        Console.WriteLine("La data del meu aniversari es " + dia +"/"+ mes +"/"+ any);


    //FASE 2
        //Sabent que l’any 1948 es un any de traspàs:
        //Creeu una constant amb el valor de l’any (1948).
        double any_t = 1948.00;
        //Creeu una variable que guardi cada quan hi ha un any de traspàs.
        double t = 4.00;
        //Calculeu quants anys de traspàs hi ha entre 1948 i el vostre any de naixement i emmagatzemeu el valor resultant en una variable.
        double num = (any-any_t)/t;
        //Mostreu per pantalla el resultat del càlcul.
        Console.WriteLine("Hi han " + num + " anys de traspas entre " + any + " y " + any_t+ " sense contar cap dels do anteriors");
        
        //FASE 3
        //Partint de l’any 1948 heu de fer un bucle for i mostrar els anys de traspàs fins arriba al vostre any de naixement. (0,75 punts)
        //ATENCIO! Haureu de canviar el tipus de variable de l’any 1948 per poder modificar-la.
        for ( var i = 0; i < num; i++) 
        {
            double anysdetrasp = any_t + t;
            Console.WriteLine("L'any de traspas " + anysdetrasp);
            any_t = any_t + t;
        }   
        //● Creeu una variable bool que sera certa si l’any de naixement és de traspàs o falsa si no ho és.(0,75 punts)
            double resto =  any / t;
            double dec = Math.Round(resto)-resto;
            bool condition = true;
            if (dec > 0) 
            {
                Console.WriteLine ("Holi va a ser que no es un any de traspas " );
            condition = false;
            
            }
            else 
            {
                Console.WriteLine ("Holi!! Si es un any de traspas " );
            
            }
    //******* booleanos...
            
    
            if (condition) 
            {
                
                Console.WriteLine ("La variable es certa " );
            }
            else 
            {
                Console.WriteLine ("La variable no es certa" );
            }

        //●  En cas de que la variable bool sigui certa, heu de mostrar per consola una frase on ho digui, en cas de ser falsa mostrareu la frase pertinent. Creeu dues variables string per guardar les frases. (1,5 punts)

        }
    }    
}