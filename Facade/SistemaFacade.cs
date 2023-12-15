namespace Padroes;

public class SistemasFacade {
	
	private SistemaAudio Audio;
	private SistemaInput Input;
	private SistemaVideo Video;

	public SistemasFacade() {
		Video = new SistemaVideo();
		Video.ConfigurarCores();
		Video.ConfigurarResolucao();

		Input = new SistemaInput();
		Input.ConfigurarJoystick();
		Input.ConfigurarTeclado();

		Audio = new SistemaAudio();
		Audio.ConfigurarCanais();
		Audio.ConfigurarFrequencia();
		Audio.ConfigurarVolume();
	}

	public void ReproduzirAudio(string arquivo) {
		Audio.ReproduzirAudio(arquivo);
	}

	public void RenderizarImagem(string imagem) {
		Video.RenderizarImagem(imagem);
	}

	public void LerInput(string str) {
		Input.LerInput(str);
	}

}