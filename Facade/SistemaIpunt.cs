namespace Padroes;

public class SistemaInput {
	
	public void ConfigurarTeclado() {
		Console.WriteLine("Teclado configurado");
	}

	public void ConfigurarJoystick() {
		Console.WriteLine("Joystick configurado");
	}

	public void LerInput(string str) {
		Console.WriteLine($"Botão {str} pressionado");
	}

}