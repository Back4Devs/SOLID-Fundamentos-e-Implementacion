// See https://aka.ms/new-console-template for more information
using InterfaceSegregation.Transporte;

AutomovilParticular autoDeportivo = new AutomovilParticular(5);
AutomovilTransportePublico bus = new AutomovilTransportePublico(20);
Avion avionAA = new Avion(50);

string origen = "Miami";
string destino = "Orlando";

Console.WriteLine("Viajar en auto deportivo");
autoDeportivo.Abordar();
autoDeportivo.Transportar(origen, destino);
autoDeportivo.Estacionar();

Console.WriteLine("Viajar en bus");
bus.Abordar();
bus.Transportar(origen, destino);
bus.Estacionar();

Console.WriteLine("Viajar en avion");
avionAA.Abordar();
avionAA.Despegar();
avionAA.Transportar(origen,destino);
avionAA.Aterrizar();