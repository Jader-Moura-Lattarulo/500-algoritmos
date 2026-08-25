def executar():
    palavra = input("Digite a palavra escolhida: ").lower()

    lacunas_vazias = len(palavra)
    partes_corpo = 0
    maximo_partes_corpo = 6

    print()
    print("Montar o diagrama do jogo.")

    while lacunas_vazias > 0 and partes_corpo < maximo_partes_corpo:

        letra = input("Digite uma letra: ").lower()

        if letra in palavra:
            print("Acertou uma letra!")
            lacunas_vazias -= 1

        else:
            print("Errou!")
            partes_corpo += 1

        print(f"Lacunas vazias: {lacunas_vazias}")
        print(
            f"Partes do corpo: {partes_corpo}/{maximo_partes_corpo}"
        )

        print()

    if lacunas_vazias == 0:
        print("Parabéns! Você acertou a palavra.")

    else:
        print("Fim de jogo! o corpo foi completado na forca.")

executar()
