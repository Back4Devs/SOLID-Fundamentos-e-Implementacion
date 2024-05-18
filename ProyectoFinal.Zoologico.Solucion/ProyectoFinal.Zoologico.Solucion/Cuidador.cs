namespace ProyectoFinal.Zoologico.Solucion
{
    public class Cuidador : EmpleadoZoologico, ICuidador
    {
        public Cuidador(string nombre) 
        {
            this.Nombre = nombre;
        }
        public void AlimentarAnimal(Animal animal)
        {
            Console.WriteLine($"La dieta del animal {animal.Nombre} es: {animal.TipoComida}");
            Console.WriteLine($"Alimentar al animal {animal.Nombre} con: {animal.Dieta}");
            animal.Comer();
        }

        public void LimpiarHabitat(Animal animal)
        {
            Console.WriteLine($"Tipo de habitat: {animal.Habitat}");
            Console.WriteLine($"Limpiar habitat de {animal.Nombre}");
        }
    }
}
