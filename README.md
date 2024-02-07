<h1 align="center">Batalha Naval</h1>
<p align="center">
  <img width="50%" src="https://github.com/deboradrf/batalha-naval/assets/130398684/4e3137a0-3344-44b1-b0dd-a8bf8e1e0088)">
  <img width="50%" src="https://github.com/deboradrf/batalha-naval/assets/130398684/4f25528f-9b0f-472f-8dc3-e626ab830654)">
</p>

> ### 📚 Descrição
<p align="justify">Esse projeto consiste no desenvolvimento de uma versão simplificada do jogo 'Batalha Naval'. Este jogo é jogado contra o computador (jogadorComputador), em um tabuleiro com 10 linhas e 10 colunas. Cada posição desse tabuleiro é um quadrado que pode conter água ou parte de um navio. Um jogador informa ao outro a posição (linha, coluna) do quadrado alvo do disparo. O jogo termina quando um dos jogadores afunda todas as embarcações do seu oponente.</p>

Desenvolvido em C# para matéria de Algoritmos e Técnicas de Programação.

> ### ⚙️ Funcionalidades do jogo
<p align="justify">
1- O programa lê de um arquivo (frotaComputador.txt) a posição das embarcações e cria um tabuleiro para o jogadorComputador. <br>
2- O jogadorHumano informa seu nome completo e o programa cria um nickname, que será usado em todas as mensagens dirigidas à ele. <br>
3- O programa cria um tabuleiro para o jogadorHumano após o mesmo escolher (via teclado) as posições para suas embarcações, assim como se deseja colocá-las na horizontal ou vertical. Caso seja informada uma posição inválida, o programa solicita uma nova posição. <br>
4- O jogo inicia mostrando o tabuleiro atualizado dos jogadores e, em cada rodada, cada jogador faz um disparo (se acertar, continua jogando). Se o tiro acertar a água, o tabuleiro mostra a letra 'X'. Se acertar parte de uma embarcação, mostra a letra 'T'. <br>
5- Cada jogador ganhará um ponto para cada tiro que acertar. <br>
6- O jogo termina quando um jogador atingir a pontuação máxima do jogo. O programa informa qual jogador venceu. <br>
7- O programa escreve em um arquivo texto (jogadas.txt) a sequência de tiros do jogador vencedor (linha e coluna).
</p>
