namespace TP02.Models;

public class sugeridorReceta{
    public string nombreCocinero {get;set;}
    public DateTime fNacimiento {get;set;}
    public string tipoComida {get;set;}
    public int presupuesto {get;set;}
    public int cantidad {get;set;}

    public int calcularEdad(){
        DateTime fHoy = DateTime.Today;
        int edad = fHoy.Year - fNacimiento.Year;
        return edad;
    }

    public string determinarPlato(){
        string platoRecomendado ="";
        if (tipoComida == "caliente"){
            if (presupuesto < 3000){
                platoRecomendado = "Fideos con manteca";
            }
            else if (presupuesto >= 3000 && presupuesto < 7000){
                platoRecomendado = "Arroz con verduras salteadas";
            }
            else if (presupuesto >= 7000){
                platoRecomendado = "Pollo al horno con guarnicion";
            }
        }
        else if (tipoComida == "fria"){
            if (presupuesto < 3000){
                platoRecomendado = "Ensalada simple";
            }
            else if (presupuesto >= 3000 && presupuesto < 7000){
                platoRecomendado = "Ensalada completa con proteina";
            }
            else if (presupuesto >= 7000){
                platoRecomendado = "Tabla de fiambres y quesos";
            }
        }
        return platoRecomendado;
    }
    
    public int calcularTiempo(){
        int minutos = 0;
        if (tipoComida == "caliente"){
            if (cantidad >= 1 && cantidad <= 3){
                minutos = 20;
            }
            else if (cantidad >= 4 && cantidad <= 7){
                minutos = 40;
            }
            else if (cantidad >= 8){
                minutos = 80;
            }
        }
        else if (tipoComida == "fria"){
            if (cantidad >= 1 && cantidad <= 3){
                minutos = 10;
            }
            else if (cantidad >= 4 && cantidad <= 7){
                minutos = 20;
            }
            else if (cantidad >= 8){
                minutos = 40;
            }
        }
        return minutos;
    }

    public string determinarDificultad(){
        string dificultad = "";
        if (presupuesto < 3000){
            if (cantidad >= 1 && cantidad <= 3){
                dificultad = "Principiante";
            }
            else if (cantidad >= 4 && cantidad <= 7){
                dificultad = "Intermedio";
            }
        }
        else if (presupuesto >= 3000 && presupuesto <= 7000){
            if (cantidad >= 1 && cantidad <= 7){
                dificultad = "Intermedio";
            }
        }
        else if (presupuesto > 7000){
            if (cantidad >= 1 && cantidad <= 7){
                dificultad = "Intermedio";
            }
            else if (cantidad >= 8){
                dificultad = "Avanzado";
            }
        }
        return dificultad;
    }

    public string generarSaludo(){
        string saludo = "";
        if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour <= 11){
            saludo = "¡Buenos Dias!";
        }
        else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour <= 18){
            saludo = "¡Buenas Tardes!";
        }
        else if (DateTime.Now.Hour >= 19 && DateTime.Now.Hour <= 5){
            saludo = "¡Buenas Noches!";
        }
        return saludo;
    }

    public string generarTip(){
        string tip = "";
        int edad = calcularEdad();
        if (edad < 18){
            tip = "Cuidado al cocinar que se utilizan elementos peligrosos.";
        }
        else if (edad >= 18 && edad < 60){
            tip = "¡Vos podes!";
        }
        else if (edad >= 60){
            tip = "Las mejores recetas, en Recetify";
        }
        return tip;
    }
}