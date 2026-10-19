using System;

class RetoVeterinaria
{
    static void Main()
    {
        string  Especie  = "perro";   // "perro", "gato", "conejo", "reptil"
        int edadMascota = 7;               // edad en años
        double peso = 28.5;                // peso en kilogramos
        bool tieneVacunasAlDia = false;
        bool esSocio = true;
        string motivoConsulta = "cirugia"; // "vacuna", "revision", "cirugia", "urgencia"

        Console.WriteLine("--- REPORTE DE ATENCIÓN VETERINARIA ---\n");

        // ==========================================
        // Parte 1: Clasificación por etapa de vida (Switch Expression C# 8+)
        // ==========================================
        // Nota: He completado la lógica de la regla mayor a 8 años.
        string etapaVida = edadMascota switch
        {
            < 1 => "Cachorro",
            >= 1 and <= 3 => "Joven",
            >= 4 and <= 8 => "Adulto",
            > 8 => "Senior"
        };
        Console.WriteLine($"1. Etapa de vida: {etapaVida}");

        
        string estadoVacunas = tieneVacunasAlDia 
            ? "Al día. No requiere aplicación." 
            : "Pendientes. Pasar a sala de vacunación tras consulta.";
        
        Console.WriteLine($"2. Estado de vacunas: {estadoVacunas}");

        string areaAsignada;
        switch (motivoConsulta)
        {
            case "vacuna":
                areaAsignada = "Consultorio 1 - Prevención";
                break;
            case "revision":
                areaAsignada = "Consultorio 2 - Medicina General";
                break;
            case "cirugia":
                areaAsignada = "Quirófano A - Preparación";
                break;
            case "urgencia":
                areaAsignada = "Sala de Triage - Atención Inmediata";
                break;
            default:
                areaAsignada = "Sala de Espera - Recepción";
                break;
        }
        Console.WriteLine($"3. Área asignada: {areaAsignada}");

        if (peso >= 20.0)
        {
            Console.WriteLine("4. Logística: Mascota de tamaño grande. Requiere camilla especial de traslado.");
        }
        else
        {
            Console.WriteLine("4. Logística: Mascota de tamaño estándar. Traslado normal.");
        }
        if (esSocio)
        {
            Console.WriteLine("5. Facturación: Aplica descuento de socio (15%).");
        }
        else
        {
            Console.WriteLine("5. Facturación: Tarifa estándar (0% descuento).");
        }
    }
}