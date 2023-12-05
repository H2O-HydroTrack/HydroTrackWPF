using System.IO.Ports;

try
{
    SerialPort port = new SerialPort();
    port.BaudRate = 9600;
    // Change to outgoing bluetooth port after connecting to ESP32
    port.PortName = "COM6";
    port.Open();

    try
    {
        port.Write("Hi, I am trying to talk to you.");
        Console.WriteLine(port.ReadLine());
        Console.WriteLine(port.ReadLine());

        port.Write("Why do you have to repeat what I say?");
        Console.WriteLine(port.ReadLine());
        Console.WriteLine(port.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine("Encountered error while writing to / or reading from serial port");
        Console.WriteLine(ex.ToString());
    }

}
catch (Exception ex)
{
    Console.WriteLine("Encountered error while opening serial port");
    Console.WriteLine(ex.ToString());
}
