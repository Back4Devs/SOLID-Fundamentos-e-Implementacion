// See https://aka.ms/new-console-template for more information
using ProyectoFinal.Zoologico;
using System.Reflection.PortableExecutable;

EmpleadoZoologico empleadoZoologico = new EmpleadoZoologico("Hector Valverde");
Gorila gorila = new Gorila();
Mantarraya mantarraya = new Mantarraya();
Aguila aguila = new Aguila();
empleadoZoologico.AlimentarAnimal(mantarraya);
empleadoZoologico.Entrenar(gorila);
empleadoZoologico.AtencionMedicaMantarraya(mantarraya);
empleadoZoologico.AtencionMedicaAguila(aguila);
