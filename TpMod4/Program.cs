// See https://aka.ms/new-console-template for more information
using System;
using TpMod4;

namespace TpMod4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Kelurahan dan Kode Pos");
            Console.WriteLine("Batununggal = " + KodePos.getKodePos(KodePos.kodePos.Batununggal));
            Console.WriteLine("Kujangsari =	" + KodePos.getKodePos(KodePos.kodePos.Kujangsari));
            Console.WriteLine("Mengger = " + KodePos.getKodePos(KodePos.kodePos.Mengger));
            Console.WriteLine("Wates = " + KodePos.getKodePos(KodePos.kodePos.Wates));
            Console.WriteLine("Cijaura = " + KodePos.getKodePos(KodePos.kodePos.Cijaura));
            Console.WriteLine("Jatisari = " + KodePos.getKodePos(KodePos.kodePos.Jatisari));
            Console.WriteLine("Margasari = " + KodePos.getKodePos(KodePos.kodePos.Margasari));
            Console.WriteLine("Sekejati = " + KodePos.getKodePos(KodePos.kodePos.Sekejati));
            Console.WriteLine("Kebonwaru = " + KodePos.getKodePos(KodePos.kodePos.Kebonwaru));
            Console.WriteLine("Maleer = " + KodePos.getKodePos(KodePos.kodePos.Maleer));
            Console.WriteLine("Samoja = " + KodePos.getKodePos(KodePos.kodePos.Samoja));
            Console.WriteLine();

            DoorMachine door = new DoorMachine();
            door.currentState = DoorMachine.pintu.Terkunci; 
            Console.WriteLine("Pintu terkunci");

            while (true)
            {
                Console.Write("Masukkan state: ");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "buka":
                        door.activateTrigger(DoorMachine.Trigger.bukaPintu);
                        if (door.currentState == DoorMachine.pintu.Terbuka)
                            Console.WriteLine("Pintu tidak terkunci");
                        break;

                    case "kunci":
                        door.activateTrigger(DoorMachine.Trigger.KunciPintu);
                        if (door.currentState == DoorMachine.pintu.Terkunci)
                            Console.WriteLine("Pintu terkunci");
                        break;

                    case "keluar":
                        Console.WriteLine("Program selesai.");
                        return;

                    default:
                        Console.WriteLine("Perintah tidak valid.");
                        break;
                }
            }
        }
    }
}

