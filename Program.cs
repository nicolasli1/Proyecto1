using System;
using System.Threading;
using System.IO;            // Libreria Necesaria para escribir y leer 

//declaracion de clase para manejar los hilos threading  
public class ThreadExample
{
    public static int N1 = 0;           //Variable para imprimir la informacion en el archivo 
    public static int N2 = 0;           //Variable para imprimir la informacion en el archivo
    public static int N3 = 0;           //Variable para imprimir la informacion en el archivo
    public static int N4 = 0;           //Variable para imprimir la informacion en el archivo

    public static void Tarea1() //Declaracion del primer hilo
    {
        String line;            //Declaracion de un string line para almacenar el texto
        int Numero_n = 0;       //Declaracion de una variabel int para incremetar en funcion a la cantidad de palabras que terminen en 'n'
        StreamReader sr = new StreamReader("/Users/nicolas/Projects/Proyecto_1_NLP/Proyecto_1_NLP/prueba.txt"); //sentencia que nos permite leer un documento en .txt ubicado en el compuntador en este caso un MacBook
        //Lectura de la primera linea de texto
        line = sr.ReadLine();
        
        while (line != null)    //Este codigo nos permite continuar leyendo mas lineas del texto "un enter"
        {
            try
            {
                   
                for(int i = 0 ; i < line.Length ; i++) //Recorrido con del vector line 
                {
                 
                    if (line[i] == 'n')                 // evaludo de la condicion en el array encontrar una 'n'
                    {
                        if (line[i+1] == ' ')           //una vez se tenga una 'n' para determinar si es la ultima letra se usa pregunta si el siguiente caracter en el array es un espacio ' '
                        {
                            Numero_n = Numero_n+1;      //Se incremente la variable creada anteriormente 
                         
                        }
                        if (line[i+1] == '.')           // una vez se tenga una 'n' para determinar si es la ultima letra se usa pregunta si el siguiente caracter en el array es un espacio '.'
                        {
                            Numero_n = Numero_n + 1;
                        }

                    }

                }
            }
            catch
            {

            }

            line = sr.ReadLine();       // se reliza la lectura del siguente parrafo hasta qeu se cumpla la condicion de while.

        }

        N1 = Numero_n;
        Console.WriteLine("El numero de palabras encontradas con n es " + Numero_n); //Resultado del hilo Tarea 1

        //    //close the file
        //    sr.Close();
        //    Console.ReadLine();
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine("Exception: " + e.Message);
        //}
        //finally
        //{
        //    Console.WriteLine("Executing finally block.");
        //}

        //for (int i = 6; i > 0; i= i-1 )              VALIDACIONES DE LOS HILOS
        //{
        //    Console.WriteLine("El valor es : {0}", i);
        //        Console.WriteLine(line);
        //    Thread.Sleep(100);
        //}
    }

    public static void Tarea2() //Declaracion del segundo hilo
    {
        String line1;           //declaracion del sting para alamacenar la informacion 
        int espacios = 0;       //Esta variable nos permitira contar la cantidad de espacios para determinar el nuermo de parlabras dentro de un parrafo
        int quinpala = 0;       //Esta variable nos permitira contar la contidad de parrafos que tiene ams de 15 Palabras
        StreamReader sr = new StreamReader("/Users/nicolas/Projects/Proyecto_1_NLP/Proyecto_1_NLP/prueba.txt"); //Codigo para obtener le texto
        line1 = sr.ReadLine();  //llenamos el vector con la informacion del texto 

        while(line1 != null)
        {
            try
            {
                
                //Console.WriteLine(line1);
                // cuenta = line1.Length;
                //Console.WriteLine(cuenta);

                for (int i = 0; i < line1.Length; i++)  //Se Relaiza el recorrido de Vector para evaluar las condiciones
                {
                    if (line1[i] == ' ')        //se evalua en que parte del vector tenemos un espacio "i"
                    {

                        espacios = espacios + 1;//COntamos la cantidad de espacios para evaluar la condicion deseada
    
                        if (espacios == 15)     //Condicion para determinar si tenemos mas de 15 palabras por cada parrado o punto seguido 
                        {
                            quinpala = quinpala + 1;
                            
                        }

                    }
                    if (line1[i] == '.')        // si se detecta un punto seguido se reinicia con 0 la variable espacios.
                    {
                        espacios = 0;
                    }
                }
                
            }
            catch
            {

            }

            line1 = sr.ReadLine();              // lectura del siguite parrafo
            espacios = 0;                       //  se refresca la variable espacios para inciar el conteo nuevamente 


        }
        N2 = quinpala;
        Console.WriteLine("Mas de 15 palabras cuantas veces " + quinpala);//Dato de salida 
    }

    public static void Tarea3() //Declaracion del Tercer hilo
    {
        string line3;           //variable string para lamacenar la infromacion 
        int parrafos = 0;       //Variable para determinar la cantidad de parrafos
        
        StreamReader sr = new StreamReader("/Users/nicolas/Projects/Proyecto_1_NLP/Proyecto_1_NLP/prueba.txt"); //adquisicion de los datos del mismo archivo 
        line3 = sr.ReadLine();  //primer parrafo 
        while (line3 != null)   //condicion para determinar en que momento terminan los parrafos 
        {
            try
            {

            }
            catch
            {

            }
            line3 = sr.ReadLine();      // lectura del siguinte parrafo 
            parrafos = parrafos + 1;    // una vez se ejecute el codigo se incremnta la variable para determinar la cantidad de parrafos     
            

        }
        N3 = parrafos;
        Console.WriteLine("El numero de parrafos es " + parrafos);
    }

    public static void Tarea4() //Declaracion del cuarto hilo 
    {
        string line4;           //Variable para almacenar el Array 
        int x = 0;              //Variable entera para almacenar la longitud del vector dependiendo del parrafo 
        int dato = 0;           //Variable para contar la cantidad de esepciones requeridas
        int sumatoria = 0;      //Variable que almacenara para imprimir el resultado
        StreamReader sr = new StreamReader("/Users/nicolas/Projects/Proyecto_1_NLP/Proyecto_1_NLP/prueba.txt");   //Codigo para obtener los datos
        line4 = sr.ReadLine();  //lectura del primer parrafo
        while (line4 != null)
        {
            try
            {
                for (int i = 0; i < line4.Length; i++) //Recorrido por todo el vector para evaluar las condiciones
                {
                    if (line4[i] == ' ')                //Pregunta si existe un espacio vacio en el vector
                    {
                        dato = dato + 1;                 //Aumenta la variable en +1    

                    }
                     else if (line4[i] == '.')          //Pregunta si existe un punto vacio en el vector
                    {
                        dato = dato + 1;                //Aumenta la variable en +1  

                    }
                    else if (line4[i] == ',')           //Pregunta si existe una coma en el vector
                    {
                        dato = dato + 1;                //Aumenta la variable en +1  

                    }
                    else if (line4[i] == '?')           //Pregunta si existe un signo de pregunta en el vector
                    {
                        dato = dato + 1;                //Aumenta la variable en +1  

                    }
                    else if (line4[i] == '¿')           //Pregunta si existe un signo de pregunta en el vector
                    {
                        dato = dato + 1;                //Aumenta la variable en +1  

                    }
                    else if (line4[i] == '!')           //Pregunta si existe un signo de exclamacion en el vector
                    {
                        dato = dato + 1;                //Aumenta la variable en +1  

                    }
                    else if (line4[i] == 'n')           //Pregunta si existe una n  en el vector
                    {
                        dato = dato + 1;                //Aumenta la variable en +1  

                    }
                    else if (line4[i] == 'N')           //Pregunta si existe una N  en el vector
                    {
                        dato = dato + 1;                //Aumenta la variable en +1  

                    }                                   //De esta misma manera se pueden agregr mas condiciones 
                }
                
                x = line4.Length;

            }
            catch
            {
        
            }
            line4 = sr.ReadLine();              //lectura del siguiente parrafo 
            sumatoria = sumatoria + x;          // sumatoria de los caracteres encontrados por cada parrafo
        }
        
        sumatoria = sumatoria - dato;           //Operacion argmetica para dar con el resultado 
        N4 = sumatoria;
        Console.WriteLine("El numero de caracteres con las excepciones es: " + sumatoria);      //Presentacion de los datos 
    }

    public static void Main()
    {
        
        // The constructor for the Thread class requires a ThreadStart
        // delegate that represents the method to be executed on the
        // thread.  C# simplifies the creation of this delegate.
       
        Thread at = new Thread(new ThreadStart(Tarea1));
        Thread aat = new Thread(new ThreadStart(Tarea2));
        Thread aaat = new Thread(new ThreadStart(Tarea3));
        Thread aaaat = new Thread(new ThreadStart(Tarea4));

        // Start ThreadProc.  Note that on a uniprocessor, the new
        // thread does not get any processor time until the main thread
        // is preempted or yields.  Uncomment the Thread.Sleep that
        // follows t.Start() to see the difference.
        
        at.Start();             //Inicio del hilo tarea1
        aat.Start();            //Inicio del hilo tarea2
        aaat.Start();           //Inicio del hilo tarea3
        aaaat.Start();          //Inicio del hilo tarea4
        //Thread.Sleep(0);

        //for (int i = 0; i < 4; i++)
        //{
        //    Console.WriteLine("Main thread: Do some work.");
        //    Thread.Sleep(100);
        //}

        //Console.WriteLine("Main thread: Call Join(), to wait until ThreadProc ends.");
        //at.Join();
      //  Console.WriteLine("Main thread: ThreadProc.Join has returned.  Press Enter to end program.");
      //  Console.ReadLine();

        Thread.Sleep(5000);         //detenemos el hilo por 5000 ms para que termienen todos los porcesos y podamos impormirlos 
        try
        {
            //Pass the filepath and filename to the StreamWriter Constructor
            StreamWriter sw = new StreamWriter("/Users/nicolas/Projects/Proyecto_1_NLP/Proyecto_1_NLP/salida.txt");
            //Write a line of text
            sw.WriteLine("El numero de palabras encontradas con n es: " + N1);      //guradamos en el archivo la tarea 1
            //Write a line of text
            sw.WriteLine("Mas de 15 palabras cuantas veces:  " + N2);               //guradamos en el archivo la tarea 2
            //Write a line of text
            sw.WriteLine("El numero de parrafos es: " + N3);                        //guradamos en el archivo la tarea 3
            //Write a line of text
            sw.WriteLine("El numero de caracteres con las excepciones es: " + N4);  //guradamos en el archivo la tarea 4
            sw.Close();
        }
        catch
        {
           
        }
        finally
        {
            
        }


    }

}