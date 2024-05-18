// See https://aka.ms/new-console-template for more information
using ProyectoFinal.Zoologico;
using ProyectoFinal.Zoologico.Solucion;
using System.Reflection.PortableExecutable;

Cuidador cuidador = new Cuidador("Hector Valverde");
Entrenador entrenador = new Entrenador("Adam Ferris");
Veterinario veterinario = new Veterinario("Carla Hernandez");
Gorila gorila = new Gorila();
Mantarraya mantarraya = new Mantarraya();
Aguila aguila = new Aguila();
cuidador.AlimentarAnimal(mantarraya);
cuidador.LimpiarHabitat(aguila);
entrenador.EntrenarAnimal(gorila);
veterinario.AtencionMedica(mantarraya);
veterinario.AtencionMedica(aguila);
