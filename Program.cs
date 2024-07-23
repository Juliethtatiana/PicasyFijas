

class MainClass
{
    private Level? level;
    private int[] numIntento;

    private static int NUMDIGITOS=4;
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        Console.WriteLine("Bienvenido al juego de Picas y Fijas");
       
        MainClass main = new MainClass();
        main.inicializarNivel();
        main.jugar();
    }
    private void inicializarNivel(){
        level = new Level(NUMDIGITOS,4);
        numIntento= new int[NUMDIGITOS];
        level.generarNumero();
    } 
    private void jugar(){
        int intentos=1;
        int picas=0;
        int fijas=0;
        string numero="";
        do{
        Console.WriteLine("Intento "+ intentos + ":");
        
        do{
            Console.WriteLine("Ingresa número de "+ level.getCantDigitos() + " digitos:");
            numero=Console.ReadLine();
            if(numero.Length != level.getCantDigitos() || !int.TryParse(numero, out _)){
                Console.WriteLine("---Formato invalido intenta nuevamente--");
            }
        }while(numero.Length != level.getCantDigitos() || !int.TryParse(numero, out _));
        
        
        numIntento = parseArray(numero, NUMDIGITOS);
        fijas=level.calcularFijas(numIntento);
        picas=level.calcularPicas(numIntento);
        Console.WriteLine("cantidad de fijas: " + fijas);
        Console.WriteLine("cantidad de picas: " + picas);
        if(fijas== level.getCantDigitos()){
            Console.WriteLine("FELICITACIONES!! HAS ADIVINADO EL NUMERO");
            level.setVidas(0);
            intentos=0;
        }else{
            level.setVidas(level.getVidas() -1);
            intentos++;
        }
        fijas=0;
        picas=0;
        }while(level.getVidas() > 0);
        Console.WriteLine("El juego ha terminado tu puntaje es:"+ level.getPuntaje());
         

    }

    private int[] parseArray(string numero, int longitud){ 
        int[] array=new int[longitud];
          for (int i = 0; i < numero.Length; i++)
        {
            array[i] = int.Parse(numero[i].ToString());
            
        }
        return array;
    }
}

