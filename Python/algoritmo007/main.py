def executar():
    print("Ler a prova.")

    numero_de_questoes = int(
        input("Quantas questões tem na prova? ")
    )

    contador_de_questoes = 1
    tempo_para_prova = 60

    while numero_de_questoes > 0 and tempo_para_prova > 0:

        resposta = input(
            f"Você sabe responder a {contador_de_questoes}ª questão? (s/n): "
        )

        if resposta.lower() == "s":
            print(
                f"Questão: {contador_de_questoes} respondida"
            )

            tempo_para_prova -= 3

        else:
            print(
                f"Você pulou a questão: {contador_de_questoes}"
            )

            tempo_para_prova -= 1

        contador_de_questoes += 1
        numero_de_questoes -= 1

    if tempo_para_prova <= 0:
        print("O tempo acabou.")
        print("Entregar a prova.")

    elif numero_de_questoes <= 0:
        print("Você terminou a prova.")
        print("Entregar a prova.")


executar()