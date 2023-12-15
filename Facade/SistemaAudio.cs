namespace Padroes;

public class SistemaAudio {
	 
    public void ConfigurarFrequencia() {
        Console.WriteLine("Frequencia configurada");
    }
 
    public void ConfigurarVolume() {
        Console.WriteLine("Volume configurado");
    }
 
    public void ConfigurarCanais() {
        Console.WriteLine("Canais configurados");
    }
 
    public void ReproduzirAudio(string arquivo) {
        Console.WriteLine("Reproduzindo: " + arquivo);
    }
}