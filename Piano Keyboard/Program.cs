internal class Program
{
    int[] type_of_octave = new int[12];
    static void Main()
    {
        Console.WriteLine("Выбор октавы, F2,F5,F6. \nZ,S,X,D,C,V,G,B,H,N,J,M"); //Z=C, S=C#, X=D, D=D#, C=E, V=F, G=F#, B=G, H=G#, N=A, J=A#, M=H
        bool exit = true;
        ConsoleKey chooser = ConsoleKey.F2;
        while (exit == true)
        {
            ConsoleKeyInfo note = Console.ReadKey(true);
            switch (note.Key)
            {
                case ConsoleKey.Z:
                    Beep(0, chooser);
                    break;
                case ConsoleKey.S:
                    Beep(1, chooser);
                    break;
                case ConsoleKey.X:
                    Beep(2, chooser);
                    break;
                case ConsoleKey.D:
                    Beep(3, chooser);
                    break;
                case ConsoleKey.C:
                    Beep(4, chooser);
                    break;
                case ConsoleKey.V:
                    Beep(5, chooser);
                    break;
                case ConsoleKey.G:
                    Beep(6, chooser);
                    break;
                case ConsoleKey.B:
                    Beep(7, chooser);
                    break;
                case ConsoleKey.H:
                    Beep(8, chooser);
                    break;
                case ConsoleKey.N:
                    Beep(9, chooser);
                    break;
                case ConsoleKey.J:
                    Beep(10, chooser);
                    break;
                case ConsoleKey.M:
                    Beep(11, chooser);
                    break;
                case ConsoleKey.Escape:
                    exit = false;
                    break;
                default:
                    chooser = note.Key;
                    break;

            }

        }

    }
    static void Beep(int a, ConsoleKey choise)
    {
        Console.Clear();
        int[] Play = Octave(choise);
        Console.Beep(Play[a], 200);
    }
    static int[] Octave(ConsoleKey oct = ConsoleKey.F2)
    {
        int[] octave = new int[12];
        switch (oct)
        {
            case ConsoleKey.F2:
                Console.WriteLine("Октава 2");
                octave = new int[] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
                break;
            case ConsoleKey.F5:
                Console.WriteLine("Октава 5");
                octave = new int[] { 523, 554, 587, 622, 659, 698, 739, 784, 830, 880, 932, 987 };
                break;
            case ConsoleKey.F6:
                Console.WriteLine("Октава 6");
                octave = new int[] { 1047, 1109, 1175, 1245, 1319, 1480, 1568, 1661, 1760, 1865, 1976 };
                break;
        }
        return octave;
    }
}
    


