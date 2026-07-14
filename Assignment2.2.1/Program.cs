//Assignment 2.2.1 +++++++++++++++++++++++++++++++++++++++++++++++

using Assignment2_2;

Computer computer = new Computer( "Dell", "Windows 11", 16 );
Workstation workstation = new Workstation( "HP", "Windows 11 Pro", 32, "NVIDIA RTX 4070" );
Mobile mobile = new Mobile( "Apple", "macOS", 16, 14.2 );
Embedded embedded = new Embedded( "Raspberry Pi", "Linux", 8, "Home automation" );

Console.WriteLine("Computer Information:");
computer.DisplayInfo();
Console.WriteLine("\nWorkstation Information:");
workstation.DisplayInfo();  
Console.WriteLine("\nMobile Information:");
mobile.DisplayInfo();
Console.WriteLine("\nEmbedded System Information:");
embedded.DisplayInfo();