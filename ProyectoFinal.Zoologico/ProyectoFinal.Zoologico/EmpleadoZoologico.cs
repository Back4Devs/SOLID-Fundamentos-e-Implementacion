namespace ProyectoFinal.Zoologico
{
    public class EmpleadoZoologico
    {
        public string Nombre { get; set; }
        public EmpleadoZoologico(string nombre) 
        {
            this.Nombre = nombre;
        }
        public void AlimentarAnimal(Animal animal)
        {
            Console.WriteLine($"La dieta del animal {animal.Nombre} es: {animal.TipoComida}");
            Console.WriteLine($"Alimentar al animal {animal.Nombre} con: {animal.Dieta}");
            IAnimal animalAlimentado = (IAnimal)animal;
            animalAlimentado.Comer();
        }
        public void Entrenar(IAnimal animal)
        {            
            switch (animal)
            {
                case Gorila:
                    Console.WriteLine($"Entrenar gorila");
                    animal.Correr();
                    break;
                case Mantarraya:
                    Console.WriteLine($"Entrenar mantarraya");
                    animal.Nadar();
                    break;
                default:
                    Console.WriteLine($"Entrenar aguila");
                    animal.Volar();
                    break;
            }
        }
        public void LimpiarHabitat(Animal animal)
        {
            Console.WriteLine($"Limpieza de habitat: {animal.Habitat.ToString()}");
        }
        public void AtencionMedicaGorila(Gorila gorila)
        {
            Console.WriteLine($"El gorila es atendido");
            gorila.EstadoSalud = "Saludable";
            gorila.Dormir();
            Console.WriteLine($"El gorila fue curado");
        }

        public void AtencionMedicaMantarraya(Mantarraya mantarraya)
        {
            Console.WriteLine($"La mantarraya es atendida");
            mantarraya.EstadoSalud = "Saludable";
            mantarraya.Dormir();
            Console.WriteLine($"La mantarraya fue curada");
        }

        public void AtencionMedicaAguila(Aguila aguila)
        {
            Console.WriteLine($"El aguila es atendida");
            aguila.EstadoSalud = "Saludable";
            aguila.Dormir();
            Console.WriteLine($"El aguila fue curada");
        }
    }
}
